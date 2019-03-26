﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Nest
{
	internal class AggregateJsonConverter : JsonConverter
	{
		private static readonly Regex _numeric = new Regex(@"^[\d.]+(\.[\d.]+)?$");

		static AggregateJsonConverter()
		{
			AllReservedAggregationNames = typeof(Parser)
				.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public)
				.Where(f => f.IsLiteral && !f.IsInitOnly)
#if DOTNETCORE
				.Select(f => (string)f.GetValue(null))
#else
				.Select(f => (string) f.GetRawConstantValue())
#endif
				.ToArray();

			var allKeys = string.Join(", ", AllReservedAggregationNames);
			UsingReservedAggNameFormat =
				"'{0}' is one of the reserved aggregation keywords"
				+ " we use a heuristics based response parser and using these reserved keywords"
				+ " could throw its heuristics off course. We are working on a solution in elasticsearch itself to make"
				+ " the response parseable. For now these are all the reserved keywords: "
				+ allKeys;
		}

		public static string[] AllReservedAggregationNames { get; private set; }

		public override bool CanWrite => false;
		public static string UsingReservedAggNameFormat { get; private set; }

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
			JsonSerializer serializer
		) => ReadAggregate(reader, serializer);

		public override bool CanConvert(Type objectType) => objectType == typeof(IAggregate);

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => throw new NotSupportedException();

		private IAggregate ReadAggregate(JsonReader reader, JsonSerializer serializer)
		{
			if (reader.TokenType != JsonToken.StartObject)
				return null;

			reader.Read();

			if (reader.TokenType != JsonToken.PropertyName)
				return null;

			IAggregate aggregate = null;

			var propertyName = (string)reader.Value;
			if (_numeric.IsMatch(propertyName))
				aggregate = GetPercentilesAggregate(reader, serializer, true);

			var meta = propertyName == Parser.Meta
				? GetMetadata(serializer, reader)
				: null;

			if (aggregate != null)
			{
				aggregate.Meta = meta;
				return aggregate;
			}

			propertyName = (string)reader.Value;
			switch (propertyName)
			{
				case Parser.Values:
					reader.Read();
					reader.Read();
					aggregate = GetPercentilesAggregate(reader, serializer);
					break;
				case Parser.Value:
					aggregate = GetValueAggregate(reader, serializer);
					break;
				case Parser.Buckets:
				case Parser.DocCountErrorUpperBound:
					aggregate = GetMultiBucketAggregate(reader, serializer);
					break;
				case Parser.Count:
					aggregate = GetStatsAggregate(reader, serializer);
					break;
				case Parser.DocCount:
					aggregate = GetSingleBucketAggregate(reader, serializer);
					break;
				case Parser.Bounds:
					aggregate = GetGeoBoundsAggregate(reader, serializer);
					break;
				case Parser.Hits:
					aggregate = GetTopHitsAggregate(reader, serializer);
					break;
				case Parser.Location:
					aggregate = GetGeoCentroidAggregate(reader, serializer);
					break;
				case Parser.Fields:
					aggregate = GetMatrixStatsAggregate(reader, serializer);
					break;
				default:
					return null;
			}
			aggregate.Meta = meta;
			return aggregate;
		}

		private IBucket ReadBucket(JsonReader reader, JsonSerializer serializer)
		{
			if (reader.TokenType != JsonToken.StartObject)
				return null;

			reader.Read();

			if (reader.TokenType != JsonToken.PropertyName)
				return null;

			IBucket item;
			var property = (string)reader.Value;
			switch (property)
			{
				case Parser.Key:
					item = GetKeyedBucket(reader, serializer);
					break;
				case Parser.From:
				case Parser.To:
					item = GetRangeBucket(reader, serializer);
					break;
				case Parser.KeyAsString:
					item = GetDateHistogramBucket(reader, serializer);
					break;
				case Parser.DocCount:
					item = GetFiltersBucket(reader, serializer);
					break;
				default:
					return null;
			}
			return item;
		}

		private Dictionary<string, object> GetMetadata(JsonSerializer serializer, JsonReader reader)
		{
			// read past "meta" property name to start of object
			reader.Read();
			var meta = serializer.Deserialize<Dictionary<string, object>>(reader);
			// read past the closing end object of "meta" object
			reader.Read();
			return meta;
		}

		private IAggregate GetMatrixStatsAggregate(JsonReader reader, JsonSerializer serializer, long? docCount = null)
		{
			reader.Read();
			var matrixStats = new MatrixStatsAggregate { DocCount = docCount };
			var array = JArray.Load(reader);
			matrixStats.Fields = array.ToObject<List<MatrixStatsField>>();
			return matrixStats;
		}

		private IAggregate GetTopHitsAggregate(JsonReader reader, JsonSerializer serializer)
		{
			reader.Read();
			var o = JObject.Load(reader);
			if (o == null)
				return null;

			var total = o[Parser.Total].ToObject<long>();
			var maxScore = o[Parser.MaxScore].ToObject<double?>();
			var hits = o[Parser.Hits].Children().OfType<JObject>();
			reader.Read();
			return new TopHitsAggregate(hits, serializer) { Total = total, MaxScore = maxScore };
		}

		private IAggregate GetGeoCentroidAggregate(JsonReader reader, JsonSerializer serializer)
		{
			reader.Read();
			var geoCentroid = new GeoCentroidAggregate { Location = serializer.Deserialize<GeoLocation>(reader) };
			reader.Read();
			if (reader.TokenType == JsonToken.PropertyName && (string)reader.Value == Parser.Count)
			{
				reader.Read();
				geoCentroid.Count = (long)reader.Value;
				reader.Read();
			}
			return geoCentroid;
		}

		private IAggregate GetGeoBoundsAggregate(JsonReader reader, JsonSerializer serializer)
		{
			reader.Read();
			var o = JObject.Load(reader);
			if (o == null)
				return null;

			var geoBoundsMetric = new GeoBoundsAggregate();
			JToken topLeftToken;
			if (o.TryGetValue(Parser.TopLeft, out topLeftToken) && topLeftToken != null)
			{
				var topLeft = topLeftToken.ToObject<LatLon>();
				if (topLeft != null)
					geoBoundsMetric.Bounds.TopLeft = topLeft;
			}

			JToken bottomRightToken;
			if (o.TryGetValue(Parser.BottomRight, out bottomRightToken) && bottomRightToken != null)
			{
				var bottomRight = bottomRightToken.ToObject<LatLon>();
				if (bottomRight != null)
					geoBoundsMetric.Bounds.BottomRight = bottomRight;
			}
			reader.Read();
			return geoBoundsMetric;
		}

		private IAggregate GetPercentilesAggregate(JsonReader reader, JsonSerializer serializer, bool oldFormat = false)
		{
			var metric = new PercentilesAggregate();
			var percentileItems = new List<PercentileItem>();
			if (reader.TokenType == JsonToken.StartObject)
				reader.Read();
			while (reader.TokenType != JsonToken.EndObject)
			{
				var propertyName = (string)reader.Value;
				if (propertyName.Contains(Parser.AsStringSuffix))
				{
					reader.Read();
					reader.Read();
				}
				if (reader.TokenType != JsonToken.EndObject)
				{
					var percentileValue = (string)reader.Value;
					var percentile = double.Parse(percentileValue, CultureInfo.InvariantCulture);
					reader.Read();
					var value = reader.Value as double?;
					percentileItems.Add(new PercentileItem()
					{
						Percentile = percentile,
						Value = value.GetValueOrDefault(0)
					});
					reader.Read();
				}
			}
			metric.Items = percentileItems;
			if (!oldFormat) reader.Read();
			return metric;
		}

		private IAggregate GetSingleBucketAggregate(JsonReader reader, JsonSerializer serializer)
		{
			reader.Read();
			var docCount = (reader.Value as long?).GetValueOrDefault(0);
			var bucket = new SingleBucketAggregate { DocCount = docCount };
			reader.Read();
			long? bgCount = null;
			if ((string)reader.Value == Parser.BgCount)
			{
				reader.Read();
				bgCount = (reader.Value as long?).GetValueOrDefault(0);
				reader.Read();
			}
			if ((string)reader.Value == Parser.Fields)
				return GetMatrixStatsAggregate(reader, serializer, docCount);

			if (reader.TokenType == JsonToken.PropertyName && (string)reader.Value == Parser.Buckets)
			{
				var b = GetMultiBucketAggregate(reader, serializer) as BucketAggregate;
				return new BucketAggregate
				{
					BgCount = bgCount,
					DocCount = docCount,
					Items = b.Items
				};
			}

			bucket.Aggregations = GetSubAggregates(reader, serializer);

			return bucket;
		}

		private IAggregate GetStatsAggregate(JsonReader reader, JsonSerializer serializer)
		{
			reader.Read();
			var count = (reader.Value as long?).GetValueOrDefault(0);
			reader.Read();
			if (reader.TokenType == JsonToken.EndObject)
				return new SingleBucketAggregate { DocCount = count };

			reader.Read();
			var min = reader.Value as double?;
			reader.Read();
			reader.Read();
			var max = reader.Value as double?;
			reader.Read();
			reader.Read();
			var average = reader.Value as double?;
			reader.Read();
			reader.Read();
			var sum = reader.Value as double?;

			var statsMetric = new StatsAggregate()
			{
				Average = average,
				Count = count,
				Max = max,
				Min = min,
				Sum = sum
			};

			reader.Read();

			if (reader.TokenType == JsonToken.EndObject)
				return statsMetric;

			var propertyName = (string)reader.Value;
			while (reader.TokenType != JsonToken.EndObject && propertyName.Contains(Parser.AsStringSuffix))
			{
				reader.Read();
				reader.Read();
			}

			if (reader.TokenType == JsonToken.EndObject)
				return statsMetric;

			return GetExtendedStatsAggregate(statsMetric, reader);
		}

		private IAggregate GetExtendedStatsAggregate(StatsAggregate statsMetric, JsonReader reader)
		{
			var extendedStatsMetric = new ExtendedStatsAggregate()
			{
				Average = statsMetric.Average,
				Count = statsMetric.Count,
				Max = statsMetric.Max,
				Min = statsMetric.Min,
				Sum = statsMetric.Sum
			};

			reader.Read();
			extendedStatsMetric.SumOfSquares = reader.Value as double?;
			reader.Read();
			reader.Read();
			extendedStatsMetric.Variance = reader.Value as double?;
			reader.Read();
			reader.Read();
			extendedStatsMetric.StdDeviation = reader.Value as double?;
			reader.Read();

			string propertyName;

			if (reader.TokenType != JsonToken.EndObject)
			{
				var bounds = new StandardDeviationBounds();
				reader.Read();
				reader.Read();

				propertyName = (string)reader.Value;
				if (propertyName == Parser.Upper)
				{
					reader.Read();
					bounds.Upper = reader.Value as double?;
				}
				reader.Read();

				propertyName = (string)reader.Value;
				if (propertyName == Parser.Lower)
				{
					reader.Read();
					bounds.Lower = reader.Value as double?;
				}
				extendedStatsMetric.StdDeviationBounds = bounds;
				reader.Read();
				reader.Read();
			}

			propertyName = (string)reader.Value;
			while (reader.TokenType != JsonToken.EndObject && propertyName.Contains(Parser.AsStringSuffix))
			{
				// std_deviation_bounds is an object, so we need to skip its properties
				if (propertyName.Equals(Parser.StdDeviationBoundsAsString))
				{
					reader.Read();
					reader.Read();
					reader.Read();
					reader.Read();
				}
				reader.Read();
				reader.Read();
			}
			return extendedStatsMetric;
		}

		private IReadOnlyDictionary<string, IAggregate> GetSubAggregates(JsonReader reader, JsonSerializer serializer)
		{
			if (reader.TokenType != JsonToken.PropertyName)
				return null;

			var nestedAggs = new Dictionary<string, IAggregate>();
			var currentDepth = reader.Depth;
			do
			{
				var fieldName = (string)reader.Value;
				reader.Read();
				var agg = ReadAggregate(reader, serializer);
				nestedAggs.Add(fieldName, agg);
				reader.Read();
				if (reader.Depth == currentDepth && reader.TokenType == JsonToken.EndObject || reader.Depth < currentDepth)
					break;
			} while (true);
			return nestedAggs;
		}

		private IAggregate GetMultiBucketAggregate(JsonReader reader, JsonSerializer serializer)
		{
			var bucket = new BucketAggregate();
			var propertyName = (string)reader.Value;
			if (propertyName == Parser.DocCountErrorUpperBound)
			{
				reader.Read();
				bucket.DocCountErrorUpperBound = reader.Value as long?;
				reader.Read();
			}
			propertyName = (string)reader.Value;
			if (propertyName == Parser.SumOtherDocCount)
			{
				reader.Read();
				bucket.SumOtherDocCount = reader.Value as long?;
				reader.Read();
			}
			var items = new List<IBucket>();
			reader.Read();

			if (reader.TokenType == JsonToken.StartObject)
			{
				reader.Read();
				var aggs = new Dictionary<string, IAggregate>();
				while (reader.TokenType != JsonToken.EndObject)
				{
					var name = reader.Value.ToString();
					reader.Read();
					var innerAgg = ReadAggregate(reader, serializer);
					aggs.Add(name, innerAgg);
					reader.Read();
				}

				reader.Read();
				return new FiltersAggregate(aggs);
			}

			if (reader.TokenType != JsonToken.StartArray)
				return null;

			reader.Read(); //move from start array to start object
			if (reader.TokenType == JsonToken.EndArray)
			{
				reader.Read();
				bucket.Items = EmptyReadOnly<IBucket>.Collection;
				return bucket;
			}
			do
			{
				var item = ReadBucket(reader, serializer);
				items.Add(item);
				reader.Read();
			} while (reader.TokenType != JsonToken.EndArray);
			bucket.Items = items;
			reader.Read();
			return bucket;
		}

		private IAggregate GetValueAggregate(JsonReader reader, JsonSerializer serializer)
		{
			reader.Read();
			var valueMetric = new ValueAggregate
			{
				Value = reader.Value as double?
			};
			if (valueMetric.Value == null && reader.ValueType == typeof(long))
				valueMetric.Value = reader.Value as long?;

			// https://github.com/elastic/elasticsearch-net/issues/3311
			// above code just checks for long through reader.ValueType, this is not always the case
			if (valueMetric.Value != null || reader.TokenType == JsonToken.Null)
			{
				reader.Read();
				if (reader.TokenType != JsonToken.EndObject)
				{
					if (reader.TokenType == JsonToken.PropertyName)
					{
						var propertyName = (string)reader.Value;

						if (propertyName == Parser.ValueAsString)
						{
							valueMetric.ValueAsString = reader.ReadAsString();
							reader.Read();
						}

						if (reader.TokenType == JsonToken.PropertyName)
						{
							propertyName = (string)reader.Value;
							if (propertyName == Parser.Keys)
							{
								var keyedValueMetric = new KeyedValueAggregate
								{
									Value = valueMetric.Value
								};
								var keys = new List<string>();
								reader.Read();
								reader.Read();
								while (reader.TokenType != JsonToken.EndArray)
								{
									keys.Add(reader.Value.ToString());
									reader.Read();
								}
								reader.Read();
								keyedValueMetric.Keys = keys;
								return keyedValueMetric;
							}
						}
					}
					else
					{
						reader.Read();
						reader.Read();
					}
				}
				return valueMetric;
			}

			var scriptedMetric = serializer.Deserialize(reader);


			reader.Read();
			if (scriptedMetric != null)
				return new ScriptedMetricAggregate { _Value = scriptedMetric };

			return valueMetric;
		}

		public IBucket GetRangeBucket(JsonReader reader, JsonSerializer serializer, string key = null)
		{
			string fromAsString = null, toAsString = null;
			long? docCount = null;
			double? toDouble = null, fromDouble = null;

			var readExpectedProperty = true;
			while (readExpectedProperty)
			{
				switch (reader.Value as string)
				{
					case Parser.From:
						reader.Read();
						if (reader.ValueType == typeof(double))
							fromDouble = (double)reader.Value;
						reader.Read();
						break;
					case Parser.To:
						reader.Read();
						if (reader.ValueType == typeof(double))
							toDouble = (double)reader.Value;
						reader.Read();
						break;
					case Parser.Key:
						key = reader.ReadAsString();
						reader.Read();
						break;
					case Parser.FromAsString:
						fromAsString = reader.ReadAsString();
						reader.Read();
						break;
					case Parser.ToAsString:
						toAsString = reader.ReadAsString();
						reader.Read();
						break;
					case Parser.DocCount:
						reader.Read();
						docCount = (reader.Value as long?).GetValueOrDefault(0);
						reader.Read();
						break;
					default:
						readExpectedProperty = false;
						break;
				}
			}

			var bucket = new RangeBucket
			{
				Key = key,
				From = fromDouble,
				To = toDouble,
				DocCount = docCount.GetValueOrDefault(),
				FromAsString = fromAsString,
				ToAsString = toAsString,
				Aggregations = GetSubAggregates(reader, serializer)
			};

			return bucket;
		}

		private IBucket GetDateHistogramBucket(JsonReader reader, JsonSerializer serializer)
		{
			var keyAsString = reader.ReadAsString();
			reader.Read();
			reader.Read();
			var key = (reader.Value as long?).GetValueOrDefault(0);
			reader.Read();
			reader.Read();
			var docCount = (reader.Value as long?).GetValueOrDefault(0);
			reader.Read();

			var dateHistogram = new DateHistogramBucket
			{
				Key = key,
				KeyAsString = keyAsString,
				DocCount = docCount,
				Aggregations = GetSubAggregates(reader, serializer)
			};

			return dateHistogram;
		}

		private IBucket GetKeyedBucket(JsonReader reader, JsonSerializer serializer)
		{
			reader.Read();
			var key = reader.Value;
			reader.Read();
			var propertyName = (string)reader.Value;
			if (propertyName == Parser.From || propertyName == Parser.To)
				return GetRangeBucket(reader, serializer, key as string);

			var bucket = new KeyedBucket<object> { Key = key };

			if (propertyName == Parser.KeyAsString)
			{
				bucket.KeyAsString = reader.ReadAsString();
				reader.Read();
			}

			reader.Read(); //doc_count;
			var docCount = reader.Value as long?;
			bucket.DocCount = docCount.GetValueOrDefault(0);
			reader.Read();

			var nextProperty = (string)reader.Value;
			if (nextProperty == Parser.Score)
				return GetSignificantTermsBucket(reader, serializer, bucket);

			if (nextProperty == Parser.DocCountErrorUpperBound)
			{
				reader.Read();
				bucket.DocCountErrorUpperBound = reader.Value as long?;
				reader.Read();
			}
			bucket.Aggregations = GetSubAggregates(reader, serializer);
			return bucket;
		}

		private IBucket GetSignificantTermsBucket(JsonReader reader, JsonSerializer serializer, KeyedBucket<object> keyItem)
		{
			reader.Read();
			var score = reader.Value as double?;
			reader.Read();
			reader.Read();
			var bgCount = reader.Value as long?;
			var significantTermItem = new SignificantTermsBucket()
			{
				Key = keyItem.Key as string,
				DocCount = keyItem.DocCount.GetValueOrDefault(0),
				BgCount = bgCount.GetValueOrDefault(0),
				Score = score.GetValueOrDefault(0)
			};
			reader.Read();
			significantTermItem.Aggregations = GetSubAggregates(reader, serializer);
			return significantTermItem;
		}

		private IBucket GetFiltersBucket(JsonReader reader, JsonSerializer serializer)
		{
			reader.Read();
			var filtersBucketItem = new FiltersBucketItem
			{
				DocCount = (reader.Value as long?).GetValueOrDefault(0)
			};
			reader.Read();
			filtersBucketItem.Aggregations = GetSubAggregates(reader, serializer);
			return filtersBucketItem;
		}

		private static class Parser
		{
			public const string AsStringSuffix = "_as_string";
			public const string BgCount = "bg_count";
			public const string BottomRight = "bottom_right";
			public const string Bounds = "bounds";
			public const string Buckets = "buckets";
			public const string Count = "count";
			public const string DocCount = "doc_count";
			public const string DocCountErrorUpperBound = "doc_count_error_upper_bound";
			public const string Fields = "fields";
			public const string From = "from";

			public const string FromAsString = "from_as_string";
			public const string Hits = "hits";

			public const string Key = "key";
			public const string KeyAsString = "key_as_string";
			public const string Keys = "keys";
			public const string Location = "location";
			public const string Lower = "lower";
			public const string MaxScore = "max_score";
			public const string Meta = "meta";

			public const string Score = "score";
			public const string StdDeviationBoundsAsString = "std_deviation_bounds_as_string";

			public const string SumOtherDocCount = "sum_other_doc_count";
			public const string To = "to";
			public const string ToAsString = "to_as_string";

			public const string TopLeft = "top_left";

			public const string Total = "total";

			public const string Upper = "upper";
			public const string Value = "value";

			public const string ValueAsString = "value_as_string";
			public const string Values = "values";
		}
	}
}
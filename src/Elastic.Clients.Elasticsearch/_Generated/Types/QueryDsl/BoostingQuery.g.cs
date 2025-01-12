// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.QueryDsl
{
	public partial class BoostingQuery : QueryDsl.QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "boosting";
		[JsonInclude]
		[JsonPropertyName("negative")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Negative { get; set; }

		[JsonInclude]
		[JsonPropertyName("negative_boost")]
		public double NegativeBoost { get; set; }

		[JsonInclude]
		[JsonPropertyName("positive")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Positive { get; set; }
	}

	public sealed partial class BoostingQueryDescriptor<TDocument> : DescriptorBase<BoostingQueryDescriptor<TDocument>>
	{
		public BoostingQueryDescriptor()
		{
		}

		internal BoostingQueryDescriptor(Action<BoostingQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer NegativeValue { get; private set; }

		internal double NegativeBoostValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer PositiveValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		internal float? BoostValue { get; private set; }

		internal QueryContainerDescriptor<TDocument> NegativeDescriptor { get; private set; }

		internal QueryContainerDescriptor<TDocument> PositiveDescriptor { get; private set; }

		internal Action<QueryContainerDescriptor<TDocument>> NegativeDescriptorAction { get; private set; }

		internal Action<QueryContainerDescriptor<TDocument>> PositiveDescriptorAction { get; private set; }

		public BoostingQueryDescriptor<TDocument> Negative(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer negative)
		{
			NegativeDescriptor = null;
			NegativeDescriptorAction = null;
			return Assign(negative, (a, v) => a.NegativeValue = v);
		}

		public BoostingQueryDescriptor<TDocument> Negative(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			NegativeValue = null;
			NegativeDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.NegativeDescriptor = v);
		}

		public BoostingQueryDescriptor<TDocument> Negative(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			NegativeValue = null;
			NegativeDescriptorAction = null;
			return Assign(configure, (a, v) => a.NegativeDescriptorAction = v);
		}

		public BoostingQueryDescriptor<TDocument> NegativeBoost(double negativeBoost) => Assign(negativeBoost, (a, v) => a.NegativeBoostValue = v);
		public BoostingQueryDescriptor<TDocument> Positive(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer positive)
		{
			PositiveDescriptor = null;
			PositiveDescriptorAction = null;
			return Assign(positive, (a, v) => a.PositiveValue = v);
		}

		public BoostingQueryDescriptor<TDocument> Positive(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			PositiveValue = null;
			PositiveDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.PositiveDescriptor = v);
		}

		public BoostingQueryDescriptor<TDocument> Positive(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			PositiveValue = null;
			PositiveDescriptorAction = null;
			return Assign(configure, (a, v) => a.PositiveDescriptorAction = v);
		}

		public BoostingQueryDescriptor<TDocument> QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		public BoostingQueryDescriptor<TDocument> Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (NegativeDescriptor is not null)
			{
				writer.WritePropertyName("negative");
				JsonSerializer.Serialize(writer, NegativeDescriptor, options);
			}
			else if (NegativeDescriptorAction is not null)
			{
				writer.WritePropertyName("negative");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(NegativeDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("negative");
				JsonSerializer.Serialize(writer, NegativeValue, options);
			}

			writer.WritePropertyName("negative_boost");
			writer.WriteNumberValue(NegativeBoostValue);
			if (PositiveDescriptor is not null)
			{
				writer.WritePropertyName("positive");
				JsonSerializer.Serialize(writer, PositiveDescriptor, options);
			}
			else if (PositiveDescriptorAction is not null)
			{
				writer.WritePropertyName("positive");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(PositiveDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("positive");
				JsonSerializer.Serialize(writer, PositiveValue, options);
			}

			if (!string.IsNullOrEmpty(QueryNameValue))
			{
				writer.WritePropertyName("_name");
				writer.WriteStringValue(QueryNameValue);
			}

			if (BoostValue.HasValue)
			{
				writer.WritePropertyName("boost");
				writer.WriteNumberValue(BoostValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}
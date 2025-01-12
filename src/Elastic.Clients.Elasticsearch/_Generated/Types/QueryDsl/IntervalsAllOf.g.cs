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
	public partial class IntervalsAllOf : IIntervalsContainerVariant, IIntervalsQueryVariant
	{
		[JsonIgnore]
		string QueryDsl.IIntervalsContainerVariant.IntervalsContainerVariantName => "all_of";
		[JsonIgnore]
		string QueryDsl.IIntervalsQueryVariant.IntervalsQueryVariantName => "all_of";
		[JsonInclude]
		[JsonPropertyName("filter")]
		public Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFilter? Filter { get; set; }

		[JsonInclude]
		[JsonPropertyName("intervals")]
		public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsContainer> Intervals { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_gaps")]
		public int? MaxGaps { get; set; }

		[JsonInclude]
		[JsonPropertyName("ordered")]
		public bool? Ordered { get; set; }
	}

	public sealed partial class IntervalsAllOfDescriptor : DescriptorBase<IntervalsAllOfDescriptor>
	{
		public IntervalsAllOfDescriptor()
		{
		}

		internal IntervalsAllOfDescriptor(Action<IntervalsAllOfDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFilter? FilterValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsContainer> IntervalsValue { get; private set; }

		internal int? MaxGapsValue { get; private set; }

		internal bool? OrderedValue { get; private set; }

		internal IntervalsFilterDescriptor FilterDescriptor { get; private set; }

		internal Action<IntervalsFilterDescriptor> FilterDescriptorAction { get; private set; }

		public IntervalsAllOfDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.IntervalsFilter? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			return Assign(filter, (a, v) => a.FilterValue = v);
		}

		public IntervalsAllOfDescriptor Filter(QueryDsl.IntervalsFilterDescriptor descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.FilterDescriptor = v);
		}

		public IntervalsAllOfDescriptor Filter(Action<QueryDsl.IntervalsFilterDescriptor> configure)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			return Assign(configure, (a, v) => a.FilterDescriptorAction = v);
		}

		public IntervalsAllOfDescriptor Intervals(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.IntervalsContainer> intervals) => Assign(intervals, (a, v) => a.IntervalsValue = v);
		public IntervalsAllOfDescriptor MaxGaps(int? maxGaps) => Assign(maxGaps, (a, v) => a.MaxGapsValue = v);
		public IntervalsAllOfDescriptor Ordered(bool? ordered = true) => Assign(ordered, (a, v) => a.OrderedValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryDsl.IntervalsFilterDescriptor(FilterDescriptorAction), options);
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			writer.WritePropertyName("intervals");
			JsonSerializer.Serialize(writer, IntervalsValue, options);
			if (MaxGapsValue.HasValue)
			{
				writer.WritePropertyName("max_gaps");
				writer.WriteNumberValue(MaxGapsValue.Value);
			}

			if (OrderedValue.HasValue)
			{
				writer.WritePropertyName("ordered");
				writer.WriteBooleanValue(OrderedValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}
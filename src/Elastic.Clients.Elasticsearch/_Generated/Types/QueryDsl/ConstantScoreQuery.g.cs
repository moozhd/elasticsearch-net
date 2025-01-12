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
	public partial class ConstantScoreQuery : QueryDsl.QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "constant_score";
		[JsonInclude]
		[JsonPropertyName("filter")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Filter { get; set; }
	}

	public sealed partial class ConstantScoreQueryDescriptor<TDocument> : DescriptorBase<ConstantScoreQueryDescriptor<TDocument>>
	{
		public ConstantScoreQueryDescriptor()
		{
		}

		internal ConstantScoreQueryDescriptor(Action<ConstantScoreQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer FilterValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		internal float? BoostValue { get; private set; }

		internal QueryContainerDescriptor<TDocument> FilterDescriptor { get; private set; }

		internal Action<QueryContainerDescriptor<TDocument>> FilterDescriptorAction { get; private set; }

		public ConstantScoreQueryDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			return Assign(filter, (a, v) => a.FilterValue = v);
		}

		public ConstantScoreQueryDescriptor<TDocument> Filter(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.FilterDescriptor = v);
		}

		public ConstantScoreQueryDescriptor<TDocument> Filter(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			return Assign(configure, (a, v) => a.FilterDescriptorAction = v);
		}

		public ConstantScoreQueryDescriptor<TDocument> QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		public ConstantScoreQueryDescriptor<TDocument> Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
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
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(FilterDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
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
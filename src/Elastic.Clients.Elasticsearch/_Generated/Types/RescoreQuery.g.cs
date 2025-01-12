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
namespace Elastic.Clients.Elasticsearch
{
	public partial class RescoreQuery
	{
		[JsonInclude]
		[JsonPropertyName("query_weight")]
		public double? QueryWeight { get; set; }

		[JsonInclude]
		[JsonPropertyName("rescore_query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("rescore_query_weight")]
		public double? RescoreQueryWeight { get; set; }

		[JsonInclude]
		[JsonPropertyName("score_mode")]
		public Elastic.Clients.Elasticsearch.ScoreMode? ScoreMode { get; set; }
	}

	public sealed partial class RescoreQueryDescriptor<TDocument> : DescriptorBase<RescoreQueryDescriptor<TDocument>>
	{
		public RescoreQueryDescriptor()
		{
		}

		internal RescoreQueryDescriptor(Action<RescoreQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal double? QueryWeightValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer QueryValue { get; private set; }

		internal double? RescoreQueryWeightValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.ScoreMode? ScoreModeValue { get; private set; }

		internal QueryDsl.QueryContainerDescriptor<TDocument> QueryDescriptor { get; private set; }

		internal Action<QueryDsl.QueryContainerDescriptor<TDocument>> QueryDescriptorAction { get; private set; }

		public RescoreQueryDescriptor<TDocument> QueryWeight(double? queryWeight) => Assign(queryWeight, (a, v) => a.QueryWeightValue = v);
		public RescoreQueryDescriptor<TDocument> Query(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer query)
		{
			QueryDescriptor = null;
			QueryDescriptorAction = null;
			return Assign(query, (a, v) => a.QueryValue = v);
		}

		public RescoreQueryDescriptor<TDocument> Query(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.QueryDescriptor = v);
		}

		public RescoreQueryDescriptor<TDocument> Query(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			QueryValue = null;
			QueryDescriptorAction = null;
			return Assign(configure, (a, v) => a.QueryDescriptorAction = v);
		}

		public RescoreQueryDescriptor<TDocument> RescoreQueryWeight(double? rescoreQueryWeight) => Assign(rescoreQueryWeight, (a, v) => a.RescoreQueryWeightValue = v);
		public RescoreQueryDescriptor<TDocument> ScoreMode(Elastic.Clients.Elasticsearch.ScoreMode? scoreMode) => Assign(scoreMode, (a, v) => a.ScoreModeValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (QueryWeightValue.HasValue)
			{
				writer.WritePropertyName("query_weight");
				writer.WriteNumberValue(QueryWeightValue.Value);
			}

			if (QueryDescriptor is not null)
			{
				writer.WritePropertyName("rescore_query");
				JsonSerializer.Serialize(writer, QueryDescriptor, options);
			}
			else if (QueryDescriptorAction is not null)
			{
				writer.WritePropertyName("rescore_query");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(QueryDescriptorAction), options);
			}
			else
			{
				writer.WritePropertyName("rescore_query");
				JsonSerializer.Serialize(writer, QueryValue, options);
			}

			if (RescoreQueryWeightValue.HasValue)
			{
				writer.WritePropertyName("rescore_query_weight");
				writer.WriteNumberValue(RescoreQueryWeightValue.Value);
			}

			if (ScoreModeValue is not null)
			{
				writer.WritePropertyName("score_mode");
				JsonSerializer.Serialize(writer, ScoreModeValue, options);
			}

			writer.WriteEndObject();
		}
	}
}
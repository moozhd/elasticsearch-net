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
	public partial class DisMaxQuery : QueryDsl.QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "dis_max";
		[JsonInclude]
		[JsonPropertyName("queries")]
		public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer> Queries { get; set; }

		[JsonInclude]
		[JsonPropertyName("tie_breaker")]
		public double? TieBreaker { get; set; }
	}

	public sealed partial class DisMaxQueryDescriptor : DescriptorBase<DisMaxQueryDescriptor>
	{
		public DisMaxQueryDescriptor()
		{
		}

		internal DisMaxQueryDescriptor(Action<DisMaxQueryDescriptor> configure) => configure.Invoke(this);
		internal IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer> QueriesValue { get; private set; }

		internal double? TieBreakerValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		internal float? BoostValue { get; private set; }

		public DisMaxQueryDescriptor Queries(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer> queries) => Assign(queries, (a, v) => a.QueriesValue = v);
		public DisMaxQueryDescriptor TieBreaker(double? tieBreaker) => Assign(tieBreaker, (a, v) => a.TieBreakerValue = v);
		public DisMaxQueryDescriptor QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		public DisMaxQueryDescriptor Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("queries");
			JsonSerializer.Serialize(writer, QueriesValue, options);
			if (TieBreakerValue.HasValue)
			{
				writer.WritePropertyName("tie_breaker");
				writer.WriteNumberValue(TieBreakerValue.Value);
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
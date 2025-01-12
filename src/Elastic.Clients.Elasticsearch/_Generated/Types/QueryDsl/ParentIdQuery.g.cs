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
	public partial class ParentIdQuery : QueryDsl.QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "parent_id";
		[JsonInclude]
		[JsonPropertyName("id")]
		public Elastic.Clients.Elasticsearch.Id? Id { get; set; }

		[JsonInclude]
		[JsonPropertyName("ignore_unmapped")]
		public bool? IgnoreUnmapped { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string? Type { get; set; }
	}

	public sealed partial class ParentIdQueryDescriptor : DescriptorBase<ParentIdQueryDescriptor>
	{
		public ParentIdQueryDescriptor()
		{
		}

		internal ParentIdQueryDescriptor(Action<ParentIdQueryDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Id? IdValue { get; private set; }

		internal bool? IgnoreUnmappedValue { get; private set; }

		internal string? TypeValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		internal float? BoostValue { get; private set; }

		public ParentIdQueryDescriptor Id(Elastic.Clients.Elasticsearch.Id? id) => Assign(id, (a, v) => a.IdValue = v);
		public ParentIdQueryDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true) => Assign(ignoreUnmapped, (a, v) => a.IgnoreUnmappedValue = v);
		public ParentIdQueryDescriptor Type(string? type) => Assign(type, (a, v) => a.TypeValue = v);
		public ParentIdQueryDescriptor QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		public ParentIdQueryDescriptor Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (IdValue is not null)
			{
				writer.WritePropertyName("id");
				JsonSerializer.Serialize(writer, IdValue, options);
			}

			if (IgnoreUnmappedValue.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
			}

			if (TypeValue is not null)
			{
				writer.WritePropertyName("type");
				JsonSerializer.Serialize(writer, TypeValue, options);
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
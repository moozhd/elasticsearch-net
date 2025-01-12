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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public partial class IndexSegmentSort
	{
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Fields? Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("missing")]
		public IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.SegmentSortMissing>? Missing { get; set; }

		[JsonInclude]
		[JsonPropertyName("mode")]
		public IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.SegmentSortMode>? Mode { get; set; }

		[JsonInclude]
		[JsonPropertyName("order")]
		public IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.SegmentSortOrder>? Order { get; set; }
	}

	public sealed partial class IndexSegmentSortDescriptor<TDocument> : DescriptorBase<IndexSegmentSortDescriptor<TDocument>>
	{
		public IndexSegmentSortDescriptor()
		{
		}

		internal IndexSegmentSortDescriptor(Action<IndexSegmentSortDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Fields? FieldValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.SegmentSortMissing>? MissingValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.SegmentSortMode>? ModeValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.SegmentSortOrder>? OrderValue { get; private set; }

		public IndexSegmentSortDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Fields? field) => Assign(field, (a, v) => a.FieldValue = v);
		public IndexSegmentSortDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public IndexSegmentSortDescriptor<TDocument> Missing(IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.SegmentSortMissing>? missing) => Assign(missing, (a, v) => a.MissingValue = v);
		public IndexSegmentSortDescriptor<TDocument> Mode(IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.SegmentSortMode>? mode) => Assign(mode, (a, v) => a.ModeValue = v);
		public IndexSegmentSortDescriptor<TDocument> Order(IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.SegmentSortOrder>? order) => Assign(order, (a, v) => a.OrderValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FieldValue is not null)
			{
				writer.WritePropertyName("field");
				JsonSerializer.Serialize(writer, FieldValue, options);
			}

			if (MissingValue is not null)
			{
				writer.WritePropertyName("missing");
				JsonSerializer.Serialize(writer, MissingValue, options);
			}

			if (ModeValue is not null)
			{
				writer.WritePropertyName("mode");
				JsonSerializer.Serialize(writer, ModeValue, options);
			}

			if (OrderValue is not null)
			{
				writer.WritePropertyName("order");
				JsonSerializer.Serialize(writer, OrderValue, options);
			}

			writer.WriteEndObject();
		}
	}
}
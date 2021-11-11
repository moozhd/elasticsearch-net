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
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ingest.Simulate
{
	public partial class Document
	{
		[JsonInclude]
		[JsonPropertyName("_id")]
		public Elastic.Clients.Elasticsearch.Id? Id { get; set; }

		[JsonInclude]
		[JsonPropertyName("_index")]
		public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("_source")]
		public object Source { get; set; }
	}

	[JsonConverter(typeof(DocumentDescriptorConverter))]
	public sealed partial class DocumentDescriptor : DescriptorBase<DocumentDescriptor>
	{
		public DocumentDescriptor()
		{
		}

		internal DocumentDescriptor(Action<DocumentDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Id? IdValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; private set; }

		internal object SourceValue { get; private set; }

		public DocumentDescriptor Id(Elastic.Clients.Elasticsearch.Id? id) => Assign(id, (a, v) => a.IdValue = v);
		public DocumentDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index) => Assign(index, (a, v) => a.IndexValue = v);
		public DocumentDescriptor Source(object source) => Assign(source, (a, v) => a.SourceValue = v);
	}

	internal sealed class DocumentDescriptorConverter : JsonConverter<DocumentDescriptor>
	{
		public override DocumentDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, DocumentDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.IdValue is not null)
			{
				writer.WritePropertyName("_id");
				JsonSerializer.Serialize(writer, value.IdValue, options);
			}

			if (value.IndexValue is not null)
			{
				writer.WritePropertyName("_index");
				JsonSerializer.Serialize(writer, value.IndexValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public partial class DocumentSimulation
	{
		[JsonInclude]
		[JsonPropertyName("_id")]
		public Elastic.Clients.Elasticsearch.Id Id { get; init; }

		[JsonInclude]
		[JsonPropertyName("_index")]
		public Elastic.Clients.Elasticsearch.IndexName Index { get; init; }

		[JsonInclude]
		[JsonPropertyName("_ingest")]
		public Elastic.Clients.Elasticsearch.Ingest.Simulate.Ingest Ingest { get; init; }

		[JsonInclude]
		[JsonPropertyName("_parent")]
		public string? Parent { get; init; }

		[JsonInclude]
		[JsonPropertyName("_routing")]
		public string? Routing { get; init; }

		[JsonInclude]
		[JsonPropertyName("_source")]
		public Dictionary<string, object> Source { get; init; }

		[JsonInclude]
		[JsonPropertyName("_type")]
		public string? Type { get; init; }
	}

	public partial class Ingest
	{
		[JsonInclude]
		[JsonPropertyName("timestamp")]
		public string Timestamp { get; init; }

		[JsonInclude]
		[JsonPropertyName("pipeline")]
		public Elastic.Clients.Elasticsearch.Name? Pipeline { get; init; }
	}

	public partial class PipelineSimulation
	{
		[JsonInclude]
		[JsonPropertyName("doc")]
		public Elastic.Clients.Elasticsearch.Ingest.Simulate.DocumentSimulation? Doc { get; init; }

		[JsonInclude]
		[JsonPropertyName("processor_results")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Ingest.Simulate.PipelineSimulation>? ProcessorResults { get; init; }

		[JsonInclude]
		[JsonPropertyName("tag")]
		public string? Tag { get; init; }

		[JsonInclude]
		[JsonPropertyName("processor_type")]
		public string? ProcessorType { get; init; }

		[JsonInclude]
		[JsonPropertyName("status")]
		public Elastic.Clients.Elasticsearch.Watcher.ActionStatusOptions? Status { get; init; }
	}
}
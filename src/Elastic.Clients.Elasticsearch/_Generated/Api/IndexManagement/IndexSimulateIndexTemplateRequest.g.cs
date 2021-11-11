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

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexSimulateIndexTemplateRequestParameters : RequestParameters<IndexSimulateIndexTemplateRequestParameters>
	{
	}

	public partial class IndexSimulateIndexTemplateRequest : PlainRequestBase<IndexSimulateIndexTemplateRequestParameters>
	{
		public IndexSimulateIndexTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementSimulateIndexTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonInclude]
		[JsonPropertyName("index_patterns")]
		public IEnumerable<Elastic.Clients.Elasticsearch.IndexName>? IndexPatterns { get; set; }

		[JsonInclude]
		[JsonPropertyName("composed_of")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Name>? ComposedOf { get; set; }

		[JsonInclude]
		[JsonPropertyName("overlapping")]
		public IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.OverlappingIndexTemplate>? Overlapping { get; set; }

		[JsonInclude]
		[JsonPropertyName("template")]
		public Elastic.Clients.Elasticsearch.IndexManagement.TemplateMapping? Template { get; set; }
	}

	[JsonConverter(typeof(IndexSimulateIndexTemplateRequestDescriptorConverter))]
	public sealed partial class IndexSimulateIndexTemplateRequestDescriptor : RequestDescriptorBase<IndexSimulateIndexTemplateRequestDescriptor, IndexSimulateIndexTemplateRequestParameters>
	{
		public IndexSimulateIndexTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		public IndexSimulateIndexTemplateRequestDescriptor()
		{
		}

		internal IndexSimulateIndexTemplateRequestDescriptor(Action<IndexSimulateIndexTemplateRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementSimulateIndexTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		internal IEnumerable<Elastic.Clients.Elasticsearch.IndexName>? IndexPatternsValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Name>? ComposedOfValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.OverlappingIndexTemplate>? OverlappingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.IndexManagement.TemplateMapping? TemplateValue { get; private set; }

		internal TemplateMappingDescriptor TemplateDescriptor { get; private set; }

		internal Action<TemplateMappingDescriptor> TemplateDescriptorAction { get; private set; }

		public IndexSimulateIndexTemplateRequestDescriptor IndexPatterns(IEnumerable<Elastic.Clients.Elasticsearch.IndexName>? indexPatterns) => Assign(indexPatterns, (a, v) => a.IndexPatternsValue = v);
		public IndexSimulateIndexTemplateRequestDescriptor ComposedOf(IEnumerable<Elastic.Clients.Elasticsearch.Name>? composedOf) => Assign(composedOf, (a, v) => a.ComposedOfValue = v);
		public IndexSimulateIndexTemplateRequestDescriptor Overlapping(IEnumerable<Elastic.Clients.Elasticsearch.IndexManagement.OverlappingIndexTemplate>? overlapping) => Assign(overlapping, (a, v) => a.OverlappingValue = v);
		public IndexSimulateIndexTemplateRequestDescriptor Template(Elastic.Clients.Elasticsearch.IndexManagement.TemplateMapping? template)
		{
			TemplateDescriptor = null;
			TemplateDescriptorAction = null;
			return Assign(template, (a, v) => a.TemplateValue = v);
		}

		public IndexSimulateIndexTemplateRequestDescriptor Template(Elastic.Clients.Elasticsearch.IndexManagement.TemplateMappingDescriptor descriptor)
		{
			TemplateValue = null;
			TemplateDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.TemplateDescriptor = v);
		}

		public IndexSimulateIndexTemplateRequestDescriptor Template(Action<Elastic.Clients.Elasticsearch.IndexManagement.TemplateMappingDescriptor> configure)
		{
			TemplateValue = null;
			TemplateDescriptorAction = null;
			return Assign(configure, (a, v) => a.TemplateDescriptorAction = v);
		}
	}

	internal sealed class IndexSimulateIndexTemplateRequestDescriptorConverter : JsonConverter<IndexSimulateIndexTemplateRequestDescriptor>
	{
		public override IndexSimulateIndexTemplateRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, IndexSimulateIndexTemplateRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.IndexPatternsValue is not null)
			{
				writer.WritePropertyName("index_patterns");
				JsonSerializer.Serialize(writer, value.IndexPatternsValue, options);
			}

			if (value.ComposedOfValue is not null)
			{
				writer.WritePropertyName("composed_of");
				JsonSerializer.Serialize(writer, value.ComposedOfValue, options);
			}

			if (value.OverlappingValue is not null)
			{
				writer.WritePropertyName("overlapping");
				JsonSerializer.Serialize(writer, value.OverlappingValue, options);
			}

			if (value.TemplateDescriptor is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, value.TemplateDescriptor, options);
			}
			else if (value.TemplateDescriptorAction is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, new TemplateMappingDescriptor(value.TemplateDescriptorAction), options);
			}
			else if (value.TemplateValue is not null)
			{
				writer.WritePropertyName("template");
				JsonSerializer.Serialize(writer, value.TemplateValue, options);
			}

			writer.WriteEndObject();
		}
	}
}
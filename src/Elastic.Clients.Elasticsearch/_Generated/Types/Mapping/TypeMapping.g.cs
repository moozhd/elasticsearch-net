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
namespace Elastic.Clients.Elasticsearch.Mapping
{
	public partial class TypeMapping
	{
		[JsonInclude]
		[JsonPropertyName("all_field")]
		public Elastic.Clients.Elasticsearch.Mapping.AllField? AllField { get; set; }

		[JsonInclude]
		[JsonPropertyName("date_detection")]
		public bool? DateDetection { get; set; }

		[JsonInclude]
		[JsonPropertyName("dynamic")]
		public Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? Dynamic { get; set; }

		[JsonInclude]
		[JsonPropertyName("dynamic_date_formats")]
		public IEnumerable<string>? DynamicDateFormats { get; set; }

		[JsonInclude]
		[JsonPropertyName("dynamic_templates")]
		public Union<Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.DynamicTemplate>?, IEnumerable<Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.DynamicTemplate>>?>? DynamicTemplates { get; set; }

		[JsonInclude]
		[JsonPropertyName("_field_names")]
		public Elastic.Clients.Elasticsearch.Mapping.FieldNamesField? FieldNames { get; set; }

		[JsonInclude]
		[JsonPropertyName("index_field")]
		public Elastic.Clients.Elasticsearch.Mapping.IndexField? IndexField { get; set; }

		[JsonInclude]
		[JsonPropertyName("_meta")]
		public Dictionary<string, object>? Meta { get; set; }

		[JsonInclude]
		[JsonPropertyName("numeric_detection")]
		public bool? NumericDetection { get; set; }

		[JsonInclude]
		[JsonPropertyName("properties")]
		public Elastic.Clients.Elasticsearch.Mapping.Properties? Properties { get; set; }

		[JsonInclude]
		[JsonPropertyName("_routing")]
		public Elastic.Clients.Elasticsearch.Mapping.RoutingField? Routing { get; set; }

		[JsonInclude]
		[JsonPropertyName("_size")]
		public Elastic.Clients.Elasticsearch.Mapping.SizeField? Size { get; set; }

		[JsonInclude]
		[JsonPropertyName("_source")]
		public Elastic.Clients.Elasticsearch.Mapping.SourceField? Source { get; set; }

		[JsonInclude]
		[JsonPropertyName("runtime")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? Runtime { get; set; }

		[JsonInclude]
		[JsonPropertyName("enabled")]
		public bool? Enabled { get; set; }
	}

	public sealed partial class TypeMappingDescriptor : DescriptorBase<TypeMappingDescriptor>
	{
		public TypeMappingDescriptor()
		{
		}

		internal TypeMappingDescriptor(Action<TypeMappingDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Mapping.AllField? AllFieldValue { get; private set; }

		internal bool? DateDetectionValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? DynamicValue { get; private set; }

		internal IEnumerable<string>? DynamicDateFormatsValue { get; private set; }

		internal Union<Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.DynamicTemplate>?, IEnumerable<Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.DynamicTemplate>>?>? DynamicTemplatesValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Mapping.FieldNamesField? FieldNamesValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Mapping.IndexField? IndexFieldValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal bool? NumericDetectionValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Mapping.Properties? PropertiesValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Mapping.RoutingField? RoutingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Mapping.SizeField? SizeValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Mapping.SourceField? SourceValue { get; private set; }

		internal Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>? RuntimeValue { get; private set; }

		internal bool? EnabledValue { get; private set; }

		internal AllFieldDescriptor AllFieldDescriptor { get; private set; }

		internal FieldNamesFieldDescriptor FieldNamesDescriptor { get; private set; }

		internal IndexFieldDescriptor IndexFieldDescriptor { get; private set; }

		internal RoutingFieldDescriptor RoutingDescriptor { get; private set; }

		internal SizeFieldDescriptor SizeDescriptor { get; private set; }

		internal SourceFieldDescriptor SourceDescriptor { get; private set; }

		internal Action<AllFieldDescriptor> AllFieldDescriptorAction { get; private set; }

		internal Action<FieldNamesFieldDescriptor> FieldNamesDescriptorAction { get; private set; }

		internal Action<IndexFieldDescriptor> IndexFieldDescriptorAction { get; private set; }

		internal Action<RoutingFieldDescriptor> RoutingDescriptorAction { get; private set; }

		internal Action<SizeFieldDescriptor> SizeDescriptorAction { get; private set; }

		internal Action<SourceFieldDescriptor> SourceDescriptorAction { get; private set; }

		public TypeMappingDescriptor AllField(Elastic.Clients.Elasticsearch.Mapping.AllField? allField)
		{
			AllFieldDescriptor = null;
			AllFieldDescriptorAction = null;
			return Assign(allField, (a, v) => a.AllFieldValue = v);
		}

		public TypeMappingDescriptor AllField(Mapping.AllFieldDescriptor descriptor)
		{
			AllFieldValue = null;
			AllFieldDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.AllFieldDescriptor = v);
		}

		public TypeMappingDescriptor AllField(Action<Mapping.AllFieldDescriptor> configure)
		{
			AllFieldValue = null;
			AllFieldDescriptorAction = null;
			return Assign(configure, (a, v) => a.AllFieldDescriptorAction = v);
		}

		public TypeMappingDescriptor DateDetection(bool? dateDetection = true) => Assign(dateDetection, (a, v) => a.DateDetectionValue = v);
		public TypeMappingDescriptor Dynamic(Elastic.Clients.Elasticsearch.Mapping.DynamicMapping? dynamic) => Assign(dynamic, (a, v) => a.DynamicValue = v);
		public TypeMappingDescriptor DynamicDateFormats(IEnumerable<string>? dynamicDateFormats) => Assign(dynamicDateFormats, (a, v) => a.DynamicDateFormatsValue = v);
		public TypeMappingDescriptor DynamicTemplates(Union<Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.DynamicTemplate>?, IEnumerable<Dictionary<string, Elastic.Clients.Elasticsearch.Mapping.DynamicTemplate>>?>? dynamicTemplates) => Assign(dynamicTemplates, (a, v) => a.DynamicTemplatesValue = v);
		public TypeMappingDescriptor FieldNames(Elastic.Clients.Elasticsearch.Mapping.FieldNamesField? fieldNames)
		{
			FieldNamesDescriptor = null;
			FieldNamesDescriptorAction = null;
			return Assign(fieldNames, (a, v) => a.FieldNamesValue = v);
		}

		public TypeMappingDescriptor FieldNames(Mapping.FieldNamesFieldDescriptor descriptor)
		{
			FieldNamesValue = null;
			FieldNamesDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.FieldNamesDescriptor = v);
		}

		public TypeMappingDescriptor FieldNames(Action<Mapping.FieldNamesFieldDescriptor> configure)
		{
			FieldNamesValue = null;
			FieldNamesDescriptorAction = null;
			return Assign(configure, (a, v) => a.FieldNamesDescriptorAction = v);
		}

		public TypeMappingDescriptor IndexField(Elastic.Clients.Elasticsearch.Mapping.IndexField? indexField)
		{
			IndexFieldDescriptor = null;
			IndexFieldDescriptorAction = null;
			return Assign(indexField, (a, v) => a.IndexFieldValue = v);
		}

		public TypeMappingDescriptor IndexField(Mapping.IndexFieldDescriptor descriptor)
		{
			IndexFieldValue = null;
			IndexFieldDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.IndexFieldDescriptor = v);
		}

		public TypeMappingDescriptor IndexField(Action<Mapping.IndexFieldDescriptor> configure)
		{
			IndexFieldValue = null;
			IndexFieldDescriptorAction = null;
			return Assign(configure, (a, v) => a.IndexFieldDescriptorAction = v);
		}

		public TypeMappingDescriptor Meta(Dictionary<string, object>? meta) => Assign(meta, (a, v) => a.MetaValue = v);
		public TypeMappingDescriptor NumericDetection(bool? numericDetection = true) => Assign(numericDetection, (a, v) => a.NumericDetectionValue = v);
		public TypeMappingDescriptor Properties(Elastic.Clients.Elasticsearch.Mapping.Properties? properties) => Assign(properties, (a, v) => a.PropertiesValue = v);
		public TypeMappingDescriptor Routing(Elastic.Clients.Elasticsearch.Mapping.RoutingField? routing)
		{
			RoutingDescriptor = null;
			RoutingDescriptorAction = null;
			return Assign(routing, (a, v) => a.RoutingValue = v);
		}

		public TypeMappingDescriptor Routing(Mapping.RoutingFieldDescriptor descriptor)
		{
			RoutingValue = null;
			RoutingDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.RoutingDescriptor = v);
		}

		public TypeMappingDescriptor Routing(Action<Mapping.RoutingFieldDescriptor> configure)
		{
			RoutingValue = null;
			RoutingDescriptorAction = null;
			return Assign(configure, (a, v) => a.RoutingDescriptorAction = v);
		}

		public TypeMappingDescriptor Size(Elastic.Clients.Elasticsearch.Mapping.SizeField? size)
		{
			SizeDescriptor = null;
			SizeDescriptorAction = null;
			return Assign(size, (a, v) => a.SizeValue = v);
		}

		public TypeMappingDescriptor Size(Mapping.SizeFieldDescriptor descriptor)
		{
			SizeValue = null;
			SizeDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.SizeDescriptor = v);
		}

		public TypeMappingDescriptor Size(Action<Mapping.SizeFieldDescriptor> configure)
		{
			SizeValue = null;
			SizeDescriptorAction = null;
			return Assign(configure, (a, v) => a.SizeDescriptorAction = v);
		}

		public TypeMappingDescriptor Source(Elastic.Clients.Elasticsearch.Mapping.SourceField? source)
		{
			SourceDescriptor = null;
			SourceDescriptorAction = null;
			return Assign(source, (a, v) => a.SourceValue = v);
		}

		public TypeMappingDescriptor Source(Mapping.SourceFieldDescriptor descriptor)
		{
			SourceValue = null;
			SourceDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.SourceDescriptor = v);
		}

		public TypeMappingDescriptor Source(Action<Mapping.SourceFieldDescriptor> configure)
		{
			SourceValue = null;
			SourceDescriptorAction = null;
			return Assign(configure, (a, v) => a.SourceDescriptorAction = v);
		}

		public TypeMappingDescriptor Runtime(Func<FluentDictionary<string, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>, FluentDictionary<string, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>> selector) => Assign(selector, (a, v) => a.RuntimeValue = v?.Invoke(new FluentDictionary<string, Elastic.Clients.Elasticsearch.Mapping.RuntimeField>()));
		public TypeMappingDescriptor Enabled(bool? enabled = true) => Assign(enabled, (a, v) => a.EnabledValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AllFieldDescriptor is not null)
			{
				writer.WritePropertyName("all_field");
				JsonSerializer.Serialize(writer, AllFieldDescriptor, options);
			}
			else if (AllFieldDescriptorAction is not null)
			{
				writer.WritePropertyName("all_field");
				JsonSerializer.Serialize(writer, new Mapping.AllFieldDescriptor(AllFieldDescriptorAction), options);
			}
			else if (AllFieldValue is not null)
			{
				writer.WritePropertyName("all_field");
				JsonSerializer.Serialize(writer, AllFieldValue, options);
			}

			if (DateDetectionValue.HasValue)
			{
				writer.WritePropertyName("date_detection");
				writer.WriteBooleanValue(DateDetectionValue.Value);
			}

			if (DynamicValue is not null)
			{
				writer.WritePropertyName("dynamic");
				JsonSerializer.Serialize(writer, DynamicValue, options);
			}

			if (DynamicDateFormatsValue is not null)
			{
				writer.WritePropertyName("dynamic_date_formats");
				JsonSerializer.Serialize(writer, DynamicDateFormatsValue, options);
			}

			if (DynamicTemplatesValue is not null)
			{
				writer.WritePropertyName("dynamic_templates");
				JsonSerializer.Serialize(writer, DynamicTemplatesValue, options);
			}

			if (FieldNamesDescriptor is not null)
			{
				writer.WritePropertyName("_field_names");
				JsonSerializer.Serialize(writer, FieldNamesDescriptor, options);
			}
			else if (FieldNamesDescriptorAction is not null)
			{
				writer.WritePropertyName("_field_names");
				JsonSerializer.Serialize(writer, new Mapping.FieldNamesFieldDescriptor(FieldNamesDescriptorAction), options);
			}
			else if (FieldNamesValue is not null)
			{
				writer.WritePropertyName("_field_names");
				JsonSerializer.Serialize(writer, FieldNamesValue, options);
			}

			if (IndexFieldDescriptor is not null)
			{
				writer.WritePropertyName("index_field");
				JsonSerializer.Serialize(writer, IndexFieldDescriptor, options);
			}
			else if (IndexFieldDescriptorAction is not null)
			{
				writer.WritePropertyName("index_field");
				JsonSerializer.Serialize(writer, new Mapping.IndexFieldDescriptor(IndexFieldDescriptorAction), options);
			}
			else if (IndexFieldValue is not null)
			{
				writer.WritePropertyName("index_field");
				JsonSerializer.Serialize(writer, IndexFieldValue, options);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("_meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (NumericDetectionValue.HasValue)
			{
				writer.WritePropertyName("numeric_detection");
				writer.WriteBooleanValue(NumericDetectionValue.Value);
			}

			if (PropertiesValue is not null)
			{
				writer.WritePropertyName("properties");
				JsonSerializer.Serialize(writer, PropertiesValue, options);
			}

			if (RoutingDescriptor is not null)
			{
				writer.WritePropertyName("_routing");
				JsonSerializer.Serialize(writer, RoutingDescriptor, options);
			}
			else if (RoutingDescriptorAction is not null)
			{
				writer.WritePropertyName("_routing");
				JsonSerializer.Serialize(writer, new Mapping.RoutingFieldDescriptor(RoutingDescriptorAction), options);
			}
			else if (RoutingValue is not null)
			{
				writer.WritePropertyName("_routing");
				JsonSerializer.Serialize(writer, RoutingValue, options);
			}

			if (SizeDescriptor is not null)
			{
				writer.WritePropertyName("_size");
				JsonSerializer.Serialize(writer, SizeDescriptor, options);
			}
			else if (SizeDescriptorAction is not null)
			{
				writer.WritePropertyName("_size");
				JsonSerializer.Serialize(writer, new Mapping.SizeFieldDescriptor(SizeDescriptorAction), options);
			}
			else if (SizeValue is not null)
			{
				writer.WritePropertyName("_size");
				JsonSerializer.Serialize(writer, SizeValue, options);
			}

			if (SourceDescriptor is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceDescriptor, options);
			}
			else if (SourceDescriptorAction is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, new Mapping.SourceFieldDescriptor(SourceDescriptorAction), options);
			}
			else if (SourceValue is not null)
			{
				writer.WritePropertyName("_source");
				JsonSerializer.Serialize(writer, SourceValue, options);
			}

			if (RuntimeValue is not null)
			{
				writer.WritePropertyName("runtime");
				JsonSerializer.Serialize(writer, RuntimeValue, options);
			}

			if (EnabledValue.HasValue)
			{
				writer.WritePropertyName("enabled");
				writer.WriteBooleanValue(EnabledValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}
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
namespace Elastic.Clients.Elasticsearch.IndexManagement.Rollover
{
	public partial class RolloverConditions
	{
		[JsonInclude]
		[JsonPropertyName("max_age")]
		public Elastic.Clients.Elasticsearch.Time? MaxAge { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_docs")]
		public long? MaxDocs { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_size")]
		public string? MaxSize { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_primary_shard_size")]
		public Elastic.Clients.Elasticsearch.ByteSize? MaxPrimaryShardSize { get; set; }
	}

	[JsonConverter(typeof(RolloverConditionsDescriptorConverter))]
	public sealed partial class RolloverConditionsDescriptor : DescriptorBase<RolloverConditionsDescriptor>
	{
		public RolloverConditionsDescriptor()
		{
		}

		internal RolloverConditionsDescriptor(Action<RolloverConditionsDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Time? MaxAgeValue { get; private set; }

		internal long? MaxDocsValue { get; private set; }

		internal string? MaxSizeValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.ByteSize? MaxPrimaryShardSizeValue { get; private set; }

		public RolloverConditionsDescriptor MaxAge(Elastic.Clients.Elasticsearch.Time? maxAge) => Assign(maxAge, (a, v) => a.MaxAgeValue = v);
		public RolloverConditionsDescriptor MaxDocs(long? maxDocs) => Assign(maxDocs, (a, v) => a.MaxDocsValue = v);
		public RolloverConditionsDescriptor MaxSize(string? maxSize) => Assign(maxSize, (a, v) => a.MaxSizeValue = v);
		public RolloverConditionsDescriptor MaxPrimaryShardSize(Elastic.Clients.Elasticsearch.ByteSize? maxPrimaryShardSize) => Assign(maxPrimaryShardSize, (a, v) => a.MaxPrimaryShardSizeValue = v);
	}

	internal sealed class RolloverConditionsDescriptorConverter : JsonConverter<RolloverConditionsDescriptor>
	{
		public override RolloverConditionsDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, RolloverConditionsDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			if (value.MaxAgeValue is not null)
			{
				writer.WritePropertyName("max_age");
				JsonSerializer.Serialize(writer, value.MaxAgeValue, options);
			}

			if (value.MaxDocsValue.HasValue)
			{
				writer.WritePropertyName("max_docs");
				writer.WriteNumberValue(value.MaxDocsValue.Value);
			}

			if (!string.IsNullOrEmpty(value.MaxSizeValue))
			{
				writer.WritePropertyName("max_size");
				writer.WriteStringValue(value.MaxSizeValue);
			}

			if (value.MaxPrimaryShardSizeValue is not null)
			{
				writer.WritePropertyName("max_primary_shard_size");
				JsonSerializer.Serialize(writer, value.MaxPrimaryShardSizeValue, options);
			}

			writer.WriteEndObject();
		}
	}
}
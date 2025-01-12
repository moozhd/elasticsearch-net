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
	public partial class SoftDeletes
	{
		[JsonInclude]
		[JsonPropertyName("enabled")]
		public bool Enabled { get; set; }

		[JsonInclude]
		[JsonPropertyName("retention_lease")]
		public Elastic.Clients.Elasticsearch.IndexManagement.RetentionLease? RetentionLease { get; set; }
	}

	public sealed partial class SoftDeletesDescriptor : DescriptorBase<SoftDeletesDescriptor>
	{
		public SoftDeletesDescriptor()
		{
		}

		internal SoftDeletesDescriptor(Action<SoftDeletesDescriptor> configure) => configure.Invoke(this);
		internal bool EnabledValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.IndexManagement.RetentionLease? RetentionLeaseValue { get; private set; }

		internal RetentionLeaseDescriptor RetentionLeaseDescriptor { get; private set; }

		internal Action<RetentionLeaseDescriptor> RetentionLeaseDescriptorAction { get; private set; }

		public SoftDeletesDescriptor Enabled(bool enabled = true) => Assign(enabled, (a, v) => a.EnabledValue = v);
		public SoftDeletesDescriptor RetentionLease(Elastic.Clients.Elasticsearch.IndexManagement.RetentionLease? retentionLease)
		{
			RetentionLeaseDescriptor = null;
			RetentionLeaseDescriptorAction = null;
			return Assign(retentionLease, (a, v) => a.RetentionLeaseValue = v);
		}

		public SoftDeletesDescriptor RetentionLease(IndexManagement.RetentionLeaseDescriptor descriptor)
		{
			RetentionLeaseValue = null;
			RetentionLeaseDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.RetentionLeaseDescriptor = v);
		}

		public SoftDeletesDescriptor RetentionLease(Action<IndexManagement.RetentionLeaseDescriptor> configure)
		{
			RetentionLeaseValue = null;
			RetentionLeaseDescriptorAction = null;
			return Assign(configure, (a, v) => a.RetentionLeaseDescriptorAction = v);
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("enabled");
			writer.WriteBooleanValue(EnabledValue);
			if (RetentionLeaseDescriptor is not null)
			{
				writer.WritePropertyName("retention_lease");
				JsonSerializer.Serialize(writer, RetentionLeaseDescriptor, options);
			}
			else if (RetentionLeaseDescriptorAction is not null)
			{
				writer.WritePropertyName("retention_lease");
				JsonSerializer.Serialize(writer, new IndexManagement.RetentionLeaseDescriptor(RetentionLeaseDescriptorAction), options);
			}
			else if (RetentionLeaseValue is not null)
			{
				writer.WritePropertyName("retention_lease");
				JsonSerializer.Serialize(writer, RetentionLeaseValue, options);
			}

			writer.WriteEndObject();
		}
	}
}
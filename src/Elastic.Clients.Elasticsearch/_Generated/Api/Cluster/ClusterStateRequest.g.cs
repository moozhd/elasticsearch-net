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
namespace Elastic.Clients.Elasticsearch.Cluster
{
	public class ClusterStateRequestParameters : RequestParameters<ClusterStateRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public long? WaitForMetadataVersion { get => Q<long?>("wait_for_metadata_version"); set => Q("wait_for_metadata_version", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? WaitForTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("wait_for_timeout"); set => Q("wait_for_timeout", value); }
	}

	public partial class ClusterStateRequest : PlainRequestBase<ClusterStateRequestParameters>
	{
		public ClusterStateRequest()
		{
		}

		public ClusterStateRequest(Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		public ClusterStateRequest(Elastic.Clients.Elasticsearch.Metrics? metric, Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("metric", metric).Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterState;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? FlatSettings { get => Q<bool?>("flat_settings"); set => Q("flat_settings", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Local { get => Q<bool?>("local"); set => Q("local", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public long? WaitForMetadataVersion { get => Q<long?>("wait_for_metadata_version"); set => Q("wait_for_metadata_version", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? WaitForTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("wait_for_timeout"); set => Q("wait_for_timeout", value); }
	}

	[JsonConverter(typeof(ClusterStateRequestDescriptorConverter))]
	public sealed partial class ClusterStateRequestDescriptor : RequestDescriptorBase<ClusterStateRequestDescriptor, ClusterStateRequestParameters>
	{
		public ClusterStateRequestDescriptor()
		{
		}

		public ClusterStateRequestDescriptor(Elastic.Clients.Elasticsearch.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		public ClusterStateRequestDescriptor(Elastic.Clients.Elasticsearch.Metrics? metric, Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("metric", metric).Optional("index", indices))
		{
		}

		internal ClusterStateRequestDescriptor(Action<ClusterStateRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterState;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		public ClusterStateRequestDescriptor AllowNoIndices(bool? allowNoIndices) => Qs("allow_no_indices", allowNoIndices);
		public ClusterStateRequestDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public ClusterStateRequestDescriptor FlatSettings(bool? flatSettings) => Qs("flat_settings", flatSettings);
		public ClusterStateRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable) => Qs("ignore_unavailable", ignoreUnavailable);
		public ClusterStateRequestDescriptor Local(bool? local) => Qs("local", local);
		public ClusterStateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public ClusterStateRequestDescriptor WaitForMetadataVersion(long? waitForMetadataVersion) => Qs("wait_for_metadata_version", waitForMetadataVersion);
		public ClusterStateRequestDescriptor WaitForTimeout(Elastic.Clients.Elasticsearch.Time? waitForTimeout) => Qs("wait_for_timeout", waitForTimeout);
	}

	internal sealed class ClusterStateRequestDescriptorConverter : JsonConverter<ClusterStateRequestDescriptor>
	{
		public override ClusterStateRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, ClusterStateRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}
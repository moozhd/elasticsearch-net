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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public class IngestGeoIpStatsRequestParameters : RequestParameters<IngestGeoIpStatsRequestParameters>
	{
	}

	public partial class IngestGeoIpStatsRequest : PlainRequestBase<IngestGeoIpStatsRequestParameters>
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestGeoIpStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	[JsonConverter(typeof(IngestGeoIpStatsRequestDescriptorConverter))]
	public sealed partial class IngestGeoIpStatsRequestDescriptor : RequestDescriptorBase<IngestGeoIpStatsRequestDescriptor, IngestGeoIpStatsRequestParameters>
	{
		public IngestGeoIpStatsRequestDescriptor()
		{
		}

		internal IngestGeoIpStatsRequestDescriptor(Action<IngestGeoIpStatsRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IngestGeoIpStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	internal sealed class IngestGeoIpStatsRequestDescriptorConverter : JsonConverter<IngestGeoIpStatsRequestDescriptor>
	{
		public override IngestGeoIpStatsRequestDescriptor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => throw new NotImplementedException();
		public override void Write(Utf8JsonWriter writer, IngestGeoIpStatsRequestDescriptor value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}
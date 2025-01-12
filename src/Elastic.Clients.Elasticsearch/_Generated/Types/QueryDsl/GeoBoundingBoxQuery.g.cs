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
	public partial class GeoBoundingBoxQuery : QueryDsl.QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "geo_bounding_box";
		[JsonInclude]
		[JsonPropertyName("ignore_unmapped")]
		public bool? IgnoreUnmapped { get; set; }

		[JsonInclude]
		[JsonPropertyName("validation_method")]
		public Elastic.Clients.Elasticsearch.QueryDsl.GeoValidationMethod? ValidationMethod { get; set; }
	}

	public sealed partial class GeoBoundingBoxQueryDescriptor : DescriptorBase<GeoBoundingBoxQueryDescriptor>
	{
		public GeoBoundingBoxQueryDescriptor()
		{
		}

		internal GeoBoundingBoxQueryDescriptor(Action<GeoBoundingBoxQueryDescriptor> configure) => configure.Invoke(this);
		internal bool? IgnoreUnmappedValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.GeoValidationMethod? ValidationMethodValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		internal float? BoostValue { get; private set; }

		public GeoBoundingBoxQueryDescriptor IgnoreUnmapped(bool? ignoreUnmapped = true) => Assign(ignoreUnmapped, (a, v) => a.IgnoreUnmappedValue = v);
		public GeoBoundingBoxQueryDescriptor ValidationMethod(Elastic.Clients.Elasticsearch.QueryDsl.GeoValidationMethod? validationMethod) => Assign(validationMethod, (a, v) => a.ValidationMethodValue = v);
		public GeoBoundingBoxQueryDescriptor QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		public GeoBoundingBoxQueryDescriptor Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (IgnoreUnmappedValue.HasValue)
			{
				writer.WritePropertyName("ignore_unmapped");
				writer.WriteBooleanValue(IgnoreUnmappedValue.Value);
			}

			if (ValidationMethodValue is not null)
			{
				writer.WritePropertyName("validation_method");
				JsonSerializer.Serialize(writer, ValidationMethodValue, options);
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
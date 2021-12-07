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
	public partial class DateProperty : Mapping.DocValuesPropertyBase
	{
		[JsonInclude]
		[JsonPropertyName("boost")]
		public double? Boost { get; init; }

		[JsonInclude]
		[JsonPropertyName("fielddata")]
		public Elastic.Clients.Elasticsearch.IndexManagement.NumericFielddata? Fielddata { get; init; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; init; }

		[JsonInclude]
		[JsonPropertyName("ignore_malformed")]
		public bool? IgnoreMalformed { get; init; }

		[JsonInclude]
		[JsonPropertyName("index")]
		public bool? Index { get; init; }

		[JsonInclude]
		[JsonPropertyName("null_value")]
		public string? NullValue { get; init; }

		[JsonInclude]
		[JsonPropertyName("precision_step")]
		public int? PrecisionStep { get; init; }

		[JsonInclude]
		[JsonPropertyName("locale")]
		public string? Locale { get; init; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "date";
	}
}
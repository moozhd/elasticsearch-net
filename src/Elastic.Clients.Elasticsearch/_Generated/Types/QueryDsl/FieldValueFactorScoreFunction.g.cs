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
	public partial class FieldValueFactorScoreFunction : QueryDsl.ScoreFunctionBase, IFunctionScoreContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IFunctionScoreContainerVariant.FunctionScoreContainerVariantName => "field_value_factor";
		[JsonInclude]
		[JsonPropertyName("factor")]
		public double? Factor { get; set; }

		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("missing")]
		public double? Missing { get; set; }

		[JsonInclude]
		[JsonPropertyName("modifier")]
		public Elastic.Clients.Elasticsearch.QueryDsl.FieldValueFactorModifier? Modifier { get; set; }
	}

	public sealed partial class FieldValueFactorScoreFunctionDescriptor<TDocument> : DescriptorBase<FieldValueFactorScoreFunctionDescriptor<TDocument>>
	{
		public FieldValueFactorScoreFunctionDescriptor()
		{
		}

		internal FieldValueFactorScoreFunctionDescriptor(Action<FieldValueFactorScoreFunctionDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal double? FactorValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field FieldValue { get; private set; }

		internal double? MissingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.FieldValueFactorModifier? ModifierValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? FilterValue { get; private set; }

		internal double? WeightValue { get; private set; }

		internal QueryContainerDescriptor<TDocument> FilterDescriptor { get; private set; }

		internal Action<QueryContainerDescriptor<TDocument>> FilterDescriptorAction { get; private set; }

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Factor(double? factor) => Assign(factor, (a, v) => a.FactorValue = v);
		public FieldValueFactorScoreFunctionDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field field) => Assign(field, (a, v) => a.FieldValue = v);
		public FieldValueFactorScoreFunctionDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public FieldValueFactorScoreFunctionDescriptor<TDocument> Missing(double? missing) => Assign(missing, (a, v) => a.MissingValue = v);
		public FieldValueFactorScoreFunctionDescriptor<TDocument> Modifier(Elastic.Clients.Elasticsearch.QueryDsl.FieldValueFactorModifier? modifier) => Assign(modifier, (a, v) => a.ModifierValue = v);
		public FieldValueFactorScoreFunctionDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer? filter)
		{
			FilterDescriptor = null;
			FilterDescriptorAction = null;
			return Assign(filter, (a, v) => a.FilterValue = v);
		}

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Filter(QueryDsl.QueryContainerDescriptor<TDocument> descriptor)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.FilterDescriptor = v);
		}

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Filter(Action<QueryDsl.QueryContainerDescriptor<TDocument>> configure)
		{
			FilterValue = null;
			FilterDescriptorAction = null;
			return Assign(configure, (a, v) => a.FilterDescriptorAction = v);
		}

		public FieldValueFactorScoreFunctionDescriptor<TDocument> Weight(double? weight) => Assign(weight, (a, v) => a.WeightValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FactorValue.HasValue)
			{
				writer.WritePropertyName("factor");
				writer.WriteNumberValue(FactorValue.Value);
			}

			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (MissingValue.HasValue)
			{
				writer.WritePropertyName("missing");
				writer.WriteNumberValue(MissingValue.Value);
			}

			if (ModifierValue is not null)
			{
				writer.WritePropertyName("modifier");
				JsonSerializer.Serialize(writer, ModifierValue, options);
			}

			if (FilterDescriptor is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterDescriptor, options);
			}
			else if (FilterDescriptorAction is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, new QueryDsl.QueryContainerDescriptor<TDocument>(FilterDescriptorAction), options);
			}
			else if (FilterValue is not null)
			{
				writer.WritePropertyName("filter");
				JsonSerializer.Serialize(writer, FilterValue, options);
			}

			if (WeightValue.HasValue)
			{
				writer.WritePropertyName("weight");
				writer.WriteNumberValue(WeightValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}
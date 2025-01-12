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
	public partial class MultiMatchQuery : QueryDsl.QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "multi_match";
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("auto_generate_synonyms_phrase_query")]
		public bool? AutoGenerateSynonymsPhraseQuery { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzziness")]
		public Elastic.Clients.Elasticsearch.Fuzziness? Fuzziness { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_rewrite")]
		public string? FuzzyRewrite { get; set; }

		[JsonInclude]
		[JsonPropertyName("fuzzy_transpositions")]
		public bool? FuzzyTranspositions { get; set; }

		[JsonInclude]
		[JsonPropertyName("lenient")]
		public bool? Lenient { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_expansions")]
		public int? MaxExpansions { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_should_match")]
		public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("operator")]
		public Elastic.Clients.Elasticsearch.QueryDsl.Operator? Operator { get; set; }

		[JsonInclude]
		[JsonPropertyName("prefix_length")]
		public int? PrefixLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("query")]
		public string Query { get; set; }

		[JsonInclude]
		[JsonPropertyName("slop")]
		public int? Slop { get; set; }

		[JsonInclude]
		[JsonPropertyName("tie_breaker")]
		public double? TieBreaker { get; set; }

		[JsonInclude]
		[JsonPropertyName("type")]
		public Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? Type { get; set; }

		[JsonInclude]
		[JsonPropertyName("zero_terms_query")]
		public Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQuery { get; set; }
	}

	public sealed partial class MultiMatchQueryDescriptor<TDocument> : DescriptorBase<MultiMatchQueryDescriptor<TDocument>>
	{
		public MultiMatchQueryDescriptor()
		{
		}

		internal MultiMatchQueryDescriptor(Action<MultiMatchQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal string? AnalyzerValue { get; private set; }

		internal bool? AutoGenerateSynonymsPhraseQueryValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Fields? FieldsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Fuzziness? FuzzinessValue { get; private set; }

		internal string? FuzzyRewriteValue { get; private set; }

		internal bool? FuzzyTranspositionsValue { get; private set; }

		internal bool? LenientValue { get; private set; }

		internal int? MaxExpansionsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.Operator? OperatorValue { get; private set; }

		internal int? PrefixLengthValue { get; private set; }

		internal string QueryValue { get; private set; }

		internal int? SlopValue { get; private set; }

		internal double? TieBreakerValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? TypeValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? ZeroTermsQueryValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		internal float? BoostValue { get; private set; }

		public MultiMatchQueryDescriptor<TDocument> Analyzer(string? analyzer) => Assign(analyzer, (a, v) => a.AnalyzerValue = v);
		public MultiMatchQueryDescriptor<TDocument> AutoGenerateSynonymsPhraseQuery(bool? autoGenerateSynonymsPhraseQuery = true) => Assign(autoGenerateSynonymsPhraseQuery, (a, v) => a.AutoGenerateSynonymsPhraseQueryValue = v);
		public MultiMatchQueryDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Assign(fields, (a, v) => a.FieldsValue = v);
		public MultiMatchQueryDescriptor<TDocument> Fields<TValue>(Expression<Func<TDocument, TValue>> fields) => Assign(fields, (a, v) => a.FieldsValue = v);
		public MultiMatchQueryDescriptor<TDocument> Fuzziness(Elastic.Clients.Elasticsearch.Fuzziness? fuzziness) => Assign(fuzziness, (a, v) => a.FuzzinessValue = v);
		public MultiMatchQueryDescriptor<TDocument> FuzzyRewrite(string? fuzzyRewrite) => Assign(fuzzyRewrite, (a, v) => a.FuzzyRewriteValue = v);
		public MultiMatchQueryDescriptor<TDocument> FuzzyTranspositions(bool? fuzzyTranspositions = true) => Assign(fuzzyTranspositions, (a, v) => a.FuzzyTranspositionsValue = v);
		public MultiMatchQueryDescriptor<TDocument> Lenient(bool? lenient = true) => Assign(lenient, (a, v) => a.LenientValue = v);
		public MultiMatchQueryDescriptor<TDocument> MaxExpansions(int? maxExpansions) => Assign(maxExpansions, (a, v) => a.MaxExpansionsValue = v);
		public MultiMatchQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch) => Assign(minimumShouldMatch, (a, v) => a.MinimumShouldMatchValue = v);
		public MultiMatchQueryDescriptor<TDocument> Operator(Elastic.Clients.Elasticsearch.QueryDsl.Operator? op) => Assign(op, (a, v) => a.OperatorValue = v);
		public MultiMatchQueryDescriptor<TDocument> PrefixLength(int? prefixLength) => Assign(prefixLength, (a, v) => a.PrefixLengthValue = v);
		public MultiMatchQueryDescriptor<TDocument> Query(string query) => Assign(query, (a, v) => a.QueryValue = v);
		public MultiMatchQueryDescriptor<TDocument> Slop(int? slop) => Assign(slop, (a, v) => a.SlopValue = v);
		public MultiMatchQueryDescriptor<TDocument> TieBreaker(double? tieBreaker) => Assign(tieBreaker, (a, v) => a.TieBreakerValue = v);
		public MultiMatchQueryDescriptor<TDocument> Type(Elastic.Clients.Elasticsearch.QueryDsl.TextQueryType? type) => Assign(type, (a, v) => a.TypeValue = v);
		public MultiMatchQueryDescriptor<TDocument> ZeroTermsQuery(Elastic.Clients.Elasticsearch.QueryDsl.ZeroTermsQuery? zeroTermsQuery) => Assign(zeroTermsQuery, (a, v) => a.ZeroTermsQueryValue = v);
		public MultiMatchQueryDescriptor<TDocument> QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		public MultiMatchQueryDescriptor<TDocument> Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (AutoGenerateSynonymsPhraseQueryValue.HasValue)
			{
				writer.WritePropertyName("auto_generate_synonyms_phrase_query");
				writer.WriteBooleanValue(AutoGenerateSynonymsPhraseQueryValue.Value);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (FuzzinessValue is not null)
			{
				writer.WritePropertyName("fuzziness");
				JsonSerializer.Serialize(writer, FuzzinessValue, options);
			}

			if (FuzzyRewriteValue is not null)
			{
				writer.WritePropertyName("fuzzy_rewrite");
				JsonSerializer.Serialize(writer, FuzzyRewriteValue, options);
			}

			if (FuzzyTranspositionsValue.HasValue)
			{
				writer.WritePropertyName("fuzzy_transpositions");
				writer.WriteBooleanValue(FuzzyTranspositionsValue.Value);
			}

			if (LenientValue.HasValue)
			{
				writer.WritePropertyName("lenient");
				writer.WriteBooleanValue(LenientValue.Value);
			}

			if (MaxExpansionsValue.HasValue)
			{
				writer.WritePropertyName("max_expansions");
				writer.WriteNumberValue(MaxExpansionsValue.Value);
			}

			if (MinimumShouldMatchValue is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
			}

			if (OperatorValue is not null)
			{
				writer.WritePropertyName("operator");
				JsonSerializer.Serialize(writer, OperatorValue, options);
			}

			if (PrefixLengthValue.HasValue)
			{
				writer.WritePropertyName("prefix_length");
				writer.WriteNumberValue(PrefixLengthValue.Value);
			}

			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
			if (SlopValue.HasValue)
			{
				writer.WritePropertyName("slop");
				writer.WriteNumberValue(SlopValue.Value);
			}

			if (TieBreakerValue.HasValue)
			{
				writer.WritePropertyName("tie_breaker");
				writer.WriteNumberValue(TieBreakerValue.Value);
			}

			if (TypeValue is not null)
			{
				writer.WritePropertyName("type");
				JsonSerializer.Serialize(writer, TypeValue, options);
			}

			if (ZeroTermsQueryValue is not null)
			{
				writer.WritePropertyName("zero_terms_query");
				JsonSerializer.Serialize(writer, ZeroTermsQueryValue, options);
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
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
	public partial class MoreLikeThisQuery : QueryDsl.QueryBase, IQueryContainerVariant
	{
		[JsonIgnore]
		string QueryDsl.IQueryContainerVariant.QueryContainerVariantName => "more_like_this";
		[JsonInclude]
		[JsonPropertyName("analyzer")]
		public string? Analyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("boost_terms")]
		public double? BoostTerms { get; set; }

		[JsonInclude]
		[JsonPropertyName("fail_on_unsupported_field")]
		public bool? FailOnUnsupportedField { get; set; }

		[JsonInclude]
		[JsonPropertyName("fields")]
		public IEnumerable<Elastic.Clients.Elasticsearch.Field>? Fields { get; set; }

		[JsonInclude]
		[JsonPropertyName("include")]
		public bool? Include { get; set; }

		[JsonInclude]
		[JsonPropertyName("like")]
		public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.Like> Like { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_doc_freq")]
		public int? MaxDocFreq { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_query_terms")]
		public int? MaxQueryTerms { get; set; }

		[JsonInclude]
		[JsonPropertyName("max_word_length")]
		public int? MaxWordLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_doc_freq")]
		public int? MinDocFreq { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_term_freq")]
		public int? MinTermFreq { get; set; }

		[JsonInclude]
		[JsonPropertyName("min_word_length")]
		public int? MinWordLength { get; set; }

		[JsonInclude]
		[JsonPropertyName("minimum_should_match")]
		public Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatch { get; set; }

		[JsonInclude]
		[JsonPropertyName("per_field_analyzer")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, string>? PerFieldAnalyzer { get; set; }

		[JsonInclude]
		[JsonPropertyName("routing")]
		public Elastic.Clients.Elasticsearch.Routing? Routing { get; set; }

		[JsonInclude]
		[JsonPropertyName("stop_words")]
		public Elastic.Clients.Elasticsearch.Analysis.StopWords? StopWords { get; set; }

		[JsonInclude]
		[JsonPropertyName("unlike")]
		public IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.Like>? Unlike { get; set; }

		[JsonInclude]
		[JsonPropertyName("version")]
		public long? Version { get; set; }

		[JsonInclude]
		[JsonPropertyName("version_type")]
		public Elastic.Clients.Elasticsearch.VersionType? VersionType { get; set; }
	}

	public sealed partial class MoreLikeThisQueryDescriptor<TDocument> : DescriptorBase<MoreLikeThisQueryDescriptor<TDocument>>
	{
		public MoreLikeThisQueryDescriptor()
		{
		}

		internal MoreLikeThisQueryDescriptor(Action<MoreLikeThisQueryDescriptor<TDocument>> configure) => configure.Invoke(this);
		internal string? AnalyzerValue { get; private set; }

		internal double? BoostTermsValue { get; private set; }

		internal bool? FailOnUnsupportedFieldValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Field>? FieldsValue { get; private set; }

		internal bool? IncludeValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.Like> LikeValue { get; private set; }

		internal int? MaxDocFreqValue { get; private set; }

		internal int? MaxQueryTermsValue { get; private set; }

		internal int? MaxWordLengthValue { get; private set; }

		internal int? MinDocFreqValue { get; private set; }

		internal int? MinTermFreqValue { get; private set; }

		internal int? MinWordLengthValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.MinimumShouldMatch? MinimumShouldMatchValue { get; private set; }

		internal Dictionary<Elastic.Clients.Elasticsearch.Field, string>? PerFieldAnalyzerValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Routing? RoutingValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Analysis.StopWords? StopWordsValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.Like>? UnlikeValue { get; private set; }

		internal long? VersionValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.VersionType? VersionTypeValue { get; private set; }

		internal string? QueryNameValue { get; private set; }

		internal float? BoostValue { get; private set; }

		public MoreLikeThisQueryDescriptor<TDocument> Analyzer(string? analyzer) => Assign(analyzer, (a, v) => a.AnalyzerValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> BoostTerms(double? boostTerms) => Assign(boostTerms, (a, v) => a.BoostTermsValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> FailOnUnsupportedField(bool? failOnUnsupportedField = true) => Assign(failOnUnsupportedField, (a, v) => a.FailOnUnsupportedFieldValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> Fields(IEnumerable<Elastic.Clients.Elasticsearch.Field>? fields) => Assign(fields, (a, v) => a.FieldsValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> Include(bool? include = true) => Assign(include, (a, v) => a.IncludeValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> Like(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.Like> like) => Assign(like, (a, v) => a.LikeValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> MaxDocFreq(int? maxDocFreq) => Assign(maxDocFreq, (a, v) => a.MaxDocFreqValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> MaxQueryTerms(int? maxQueryTerms) => Assign(maxQueryTerms, (a, v) => a.MaxQueryTermsValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> MaxWordLength(int? maxWordLength) => Assign(maxWordLength, (a, v) => a.MaxWordLengthValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> MinDocFreq(int? minDocFreq) => Assign(minDocFreq, (a, v) => a.MinDocFreqValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> MinTermFreq(int? minTermFreq) => Assign(minTermFreq, (a, v) => a.MinTermFreqValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> MinWordLength(int? minWordLength) => Assign(minWordLength, (a, v) => a.MinWordLengthValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> MinimumShouldMatch(Elastic.Clients.Elasticsearch.MinimumShouldMatch? minimumShouldMatch) => Assign(minimumShouldMatch, (a, v) => a.MinimumShouldMatchValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> PerFieldAnalyzer(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, string>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, string>> selector) => Assign(selector, (a, v) => a.PerFieldAnalyzerValue = v?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, string>()));
		public MoreLikeThisQueryDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Routing? routing) => Assign(routing, (a, v) => a.RoutingValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> StopWords(Elastic.Clients.Elasticsearch.Analysis.StopWords? stopWords) => Assign(stopWords, (a, v) => a.StopWordsValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> Unlike(IEnumerable<Elastic.Clients.Elasticsearch.QueryDsl.Like>? unlike) => Assign(unlike, (a, v) => a.UnlikeValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> Version(long? version) => Assign(version, (a, v) => a.VersionValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> VersionType(Elastic.Clients.Elasticsearch.VersionType? versionType) => Assign(versionType, (a, v) => a.VersionTypeValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> QueryName(string? queryName) => Assign(queryName, (a, v) => a.QueryNameValue = v);
		public MoreLikeThisQueryDescriptor<TDocument> Boost(float? boost) => Assign(boost, (a, v) => a.BoostValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (!string.IsNullOrEmpty(AnalyzerValue))
			{
				writer.WritePropertyName("analyzer");
				writer.WriteStringValue(AnalyzerValue);
			}

			if (BoostTermsValue.HasValue)
			{
				writer.WritePropertyName("boost_terms");
				writer.WriteNumberValue(BoostTermsValue.Value);
			}

			if (FailOnUnsupportedFieldValue.HasValue)
			{
				writer.WritePropertyName("fail_on_unsupported_field");
				writer.WriteBooleanValue(FailOnUnsupportedFieldValue.Value);
			}

			if (FieldsValue is not null)
			{
				writer.WritePropertyName("fields");
				JsonSerializer.Serialize(writer, FieldsValue, options);
			}

			if (IncludeValue.HasValue)
			{
				writer.WritePropertyName("include");
				writer.WriteBooleanValue(IncludeValue.Value);
			}

			writer.WritePropertyName("like");
			JsonSerializer.Serialize(writer, LikeValue, options);
			if (MaxDocFreqValue.HasValue)
			{
				writer.WritePropertyName("max_doc_freq");
				writer.WriteNumberValue(MaxDocFreqValue.Value);
			}

			if (MaxQueryTermsValue.HasValue)
			{
				writer.WritePropertyName("max_query_terms");
				writer.WriteNumberValue(MaxQueryTermsValue.Value);
			}

			if (MaxWordLengthValue.HasValue)
			{
				writer.WritePropertyName("max_word_length");
				writer.WriteNumberValue(MaxWordLengthValue.Value);
			}

			if (MinDocFreqValue.HasValue)
			{
				writer.WritePropertyName("min_doc_freq");
				writer.WriteNumberValue(MinDocFreqValue.Value);
			}

			if (MinTermFreqValue.HasValue)
			{
				writer.WritePropertyName("min_term_freq");
				writer.WriteNumberValue(MinTermFreqValue.Value);
			}

			if (MinWordLengthValue.HasValue)
			{
				writer.WritePropertyName("min_word_length");
				writer.WriteNumberValue(MinWordLengthValue.Value);
			}

			if (MinimumShouldMatchValue is not null)
			{
				writer.WritePropertyName("minimum_should_match");
				JsonSerializer.Serialize(writer, MinimumShouldMatchValue, options);
			}

			if (PerFieldAnalyzerValue is not null)
			{
				writer.WritePropertyName("per_field_analyzer");
				JsonSerializer.Serialize(writer, PerFieldAnalyzerValue, options);
			}

			if (RoutingValue is not null)
			{
				writer.WritePropertyName("routing");
				JsonSerializer.Serialize(writer, RoutingValue, options);
			}

			if (StopWordsValue is not null)
			{
				writer.WritePropertyName("stop_words");
				JsonSerializer.Serialize(writer, StopWordsValue, options);
			}

			if (UnlikeValue is not null)
			{
				writer.WritePropertyName("unlike");
				JsonSerializer.Serialize(writer, UnlikeValue, options);
			}

			if (VersionValue is not null)
			{
				writer.WritePropertyName("version");
				JsonSerializer.Serialize(writer, VersionValue, options);
			}

			if (VersionTypeValue is not null)
			{
				writer.WritePropertyName("version_type");
				JsonSerializer.Serialize(writer, VersionTypeValue, options);
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
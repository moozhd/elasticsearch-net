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
namespace Elastic.Clients.Elasticsearch.Analysis
{
	public partial class AsciiFoldingTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "asciifolding";
		[JsonInclude]
		[JsonPropertyName("preserve_original")]
		public bool PreserveOriginal { get; init; }
	}

	public abstract partial class CharFilterBase
	{
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }
	}

	public partial class CharGroupTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "char_group";
		[JsonInclude]
		[JsonPropertyName("tokenize_on_chars")]
		public IReadOnlyCollection<string> TokenizeOnChars { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_token_length")]
		public int? MaxTokenLength { get; init; }
	}

	public partial class CommonGramsTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "common_grams";
		[JsonInclude]
		[JsonPropertyName("common_words")]
		public IReadOnlyCollection<string>? CommonWords { get; init; }

		[JsonInclude]
		[JsonPropertyName("common_words_path")]
		public string? CommonWordsPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("ignore_case")]
		public bool? IgnoreCase { get; init; }

		[JsonInclude]
		[JsonPropertyName("query_mode")]
		public bool? QueryMode { get; init; }
	}

	public abstract partial class CompoundWordTokenFilterBase : Analysis.TokenFilterBase
	{
		[JsonInclude]
		[JsonPropertyName("hyphenation_patterns_path")]
		public string? HyphenationPatternsPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_subword_size")]
		public int? MaxSubwordSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("min_subword_size")]
		public int? MinSubwordSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("min_word_size")]
		public int? MinWordSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("only_longest_match")]
		public bool? OnlyLongestMatch { get; init; }

		[JsonInclude]
		[JsonPropertyName("word_list")]
		public IReadOnlyCollection<string>? WordList { get; init; }

		[JsonInclude]
		[JsonPropertyName("word_list_path")]
		public string? WordListPath { get; init; }
	}

	public partial class ConditionTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "condition";
		[JsonInclude]
		[JsonPropertyName("filter")]
		public IReadOnlyCollection<string> Filter { get; init; }

		[JsonInclude]
		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script Script { get; init; }
	}

	public partial class CustomAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "custom";
		[JsonInclude]
		[JsonPropertyName("char_filter")]
		public IReadOnlyCollection<string>? CharFilter { get; init; }

		[JsonInclude]
		[JsonPropertyName("filter")]
		public IReadOnlyCollection<string>? Filter { get; init; }

		[JsonInclude]
		[JsonPropertyName("position_increment_gap")]
		public int? PositionIncrementGap { get; init; }

		[JsonInclude]
		[JsonPropertyName("position_offset_gap")]
		public int? PositionOffsetGap { get; init; }

		[JsonInclude]
		[JsonPropertyName("tokenizer")]
		public string Tokenizer { get; init; }
	}

	public partial class CustomNormalizer : INormalizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "custom";
		[JsonInclude]
		[JsonPropertyName("char_filter")]
		public IReadOnlyCollection<string>? CharFilter { get; init; }

		[JsonInclude]
		[JsonPropertyName("filter")]
		public IReadOnlyCollection<string>? Filter { get; init; }
	}

	public partial class DelimitedPayloadTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "delimited_payload";
		[JsonInclude]
		[JsonPropertyName("delimiter")]
		public string Delimiter { get; init; }

		[JsonInclude]
		[JsonPropertyName("encoding")]
		public Elastic.Clients.Elasticsearch.Analysis.DelimitedPayloadEncoding Encoding { get; init; }
	}

	public partial class DictionaryDecompounderTokenFilter : Analysis.CompoundWordTokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "dictionary_decompounder";
	}

	public partial class DutchAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "dutch";
		[JsonInclude]
		[JsonPropertyName("stopwords")]
		public Elastic.Clients.Elasticsearch.Analysis.StopWords? Stopwords { get; init; }
	}

	public partial class EdgeNGramTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "edge_ngram";
		[JsonInclude]
		[JsonPropertyName("max_gram")]
		public int MaxGram { get; init; }

		[JsonInclude]
		[JsonPropertyName("min_gram")]
		public int MinGram { get; init; }

		[JsonInclude]
		[JsonPropertyName("side")]
		public Elastic.Clients.Elasticsearch.Analysis.EdgeNGramSide? Side { get; init; }

		[JsonInclude]
		[JsonPropertyName("preserve_original")]
		public bool? PreserveOriginal { get; init; }
	}

	public partial class EdgeNGramTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "edge_ngram";
		[JsonInclude]
		[JsonPropertyName("custom_token_chars")]
		public string? CustomTokenChars { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_gram")]
		public int MaxGram { get; init; }

		[JsonInclude]
		[JsonPropertyName("min_gram")]
		public int MinGram { get; init; }

		[JsonInclude]
		[JsonPropertyName("token_chars")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Analysis.TokenChar> TokenChars { get; init; }
	}

	public partial class ElisionTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "elision";
		[JsonInclude]
		[JsonPropertyName("articles")]
		public IReadOnlyCollection<string> Articles { get; init; }

		[JsonInclude]
		[JsonPropertyName("articles_case")]
		public bool ArticlesCase { get; init; }
	}

	public partial class FingerprintAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "fingerprint";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_output_size")]
		public int MaxOutputSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("preserve_original")]
		public bool PreserveOriginal { get; init; }

		[JsonInclude]
		[JsonPropertyName("separator")]
		public string Separator { get; init; }

		[JsonInclude]
		[JsonPropertyName("stopwords")]
		public Elastic.Clients.Elasticsearch.Analysis.StopWords? Stopwords { get; init; }

		[JsonInclude]
		[JsonPropertyName("stopwords_path")]
		public string? StopwordsPath { get; init; }
	}

	public partial class FingerprintTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "fingerprint";
		[JsonInclude]
		[JsonPropertyName("max_output_size")]
		public int MaxOutputSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("separator")]
		public string Separator { get; init; }
	}

	public partial class HtmlStripCharFilter : Analysis.CharFilterBase, ICharFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "html_strip";
	}

	public partial class HunspellTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "hunspell";
		[JsonInclude]
		[JsonPropertyName("dedup")]
		public bool Dedup { get; init; }

		[JsonInclude]
		[JsonPropertyName("dictionary")]
		public string Dictionary { get; init; }

		[JsonInclude]
		[JsonPropertyName("locale")]
		public string Locale { get; init; }

		[JsonInclude]
		[JsonPropertyName("longest_only")]
		public bool LongestOnly { get; init; }
	}

	public partial class HyphenationDecompounderTokenFilter : Analysis.CompoundWordTokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "hyphenation_decompounder";
	}

	public partial class IcuAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "icu_analyzer";
		[JsonInclude]
		[JsonPropertyName("method")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationType Method { get; init; }

		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationMode Mode { get; init; }
	}

	public partial class IcuCollationTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "icu_collation";
		[JsonInclude]
		[JsonPropertyName("alternate")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuCollationAlternate Alternate { get; init; }

		[JsonInclude]
		[JsonPropertyName("caseFirst")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuCollationCaseFirst Casefirst { get; init; }

		[JsonInclude]
		[JsonPropertyName("caseLevel")]
		public bool Caselevel { get; init; }

		[JsonInclude]
		[JsonPropertyName("country")]
		public string Country { get; init; }

		[JsonInclude]
		[JsonPropertyName("decomposition")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuCollationDecomposition Decomposition { get; init; }

		[JsonInclude]
		[JsonPropertyName("hiraganaQuaternaryMode")]
		public bool Hiraganaquaternarymode { get; init; }

		[JsonInclude]
		[JsonPropertyName("language")]
		public string Language { get; init; }

		[JsonInclude]
		[JsonPropertyName("numeric")]
		public bool Numeric { get; init; }

		[JsonInclude]
		[JsonPropertyName("strength")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuCollationStrength Strength { get; init; }

		[JsonInclude]
		[JsonPropertyName("variableTop")]
		public string? Variabletop { get; init; }

		[JsonInclude]
		[JsonPropertyName("variant")]
		public string Variant { get; init; }
	}

	public partial class IcuFoldingTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "icu_folding";
		[JsonInclude]
		[JsonPropertyName("unicode_set_filter")]
		public string UnicodeSetFilter { get; init; }
	}

	public partial class IcuNormalizationCharFilter : Analysis.CharFilterBase, ICharFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "icu_normalizer";
		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationMode? Mode { get; init; }

		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationType? Name { get; init; }
	}

	public partial class IcuNormalizationTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "icu_normalizer";
		[JsonInclude]
		[JsonPropertyName("name")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuNormalizationType Name { get; init; }
	}

	public partial class IcuTokenizer : Analysis.TokenizerBase, ITokenFiltersVariant, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "icu_tokenizer";
		[JsonInclude]
		[JsonPropertyName("rule_files")]
		public string RuleFiles { get; init; }
	}

	public partial class IcuTransformTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "icu_transform";
		[JsonInclude]
		[JsonPropertyName("dir")]
		public Elastic.Clients.Elasticsearch.Analysis.IcuTransformDirection Dir { get; init; }

		[JsonInclude]
		[JsonPropertyName("id")]
		public string Id { get; init; }
	}

	public partial class KeepTypesTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "keep_types";
		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.Analysis.KeepTypesMode? Mode { get; init; }

		[JsonInclude]
		[JsonPropertyName("types")]
		public IReadOnlyCollection<string>? Types { get; init; }
	}

	public partial class KeepWordsTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "keep";
		[JsonInclude]
		[JsonPropertyName("keep_words")]
		public IReadOnlyCollection<string>? KeepWords { get; init; }

		[JsonInclude]
		[JsonPropertyName("keep_words_case")]
		public bool? KeepWordsCase { get; init; }

		[JsonInclude]
		[JsonPropertyName("keep_words_path")]
		public string? KeepWordsPath { get; init; }
	}

	public partial class KeywordAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "keyword";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }
	}

	public partial class KeywordMarkerTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "keyword_marker";
		[JsonInclude]
		[JsonPropertyName("ignore_case")]
		public bool? IgnoreCase { get; init; }

		[JsonInclude]
		[JsonPropertyName("keywords")]
		public IReadOnlyCollection<string>? Keywords { get; init; }

		[JsonInclude]
		[JsonPropertyName("keywords_path")]
		public string? KeywordsPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("keywords_pattern")]
		public string? KeywordsPattern { get; init; }
	}

	public partial class KeywordTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "keyword";
		[JsonInclude]
		[JsonPropertyName("buffer_size")]
		public int BufferSize { get; init; }
	}

	public partial class KStemTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "kstem";
	}

	public partial class KuromojiAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "kuromoji";
		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.Analysis.KuromojiTokenizationMode Mode { get; init; }

		[JsonInclude]
		[JsonPropertyName("user_dictionary")]
		public string? UserDictionary { get; init; }
	}

	public partial class KuromojiIterationMarkCharFilter : Analysis.CharFilterBase, ICharFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "kuromoji_iteration_mark";
		[JsonInclude]
		[JsonPropertyName("normalize_kana")]
		public bool NormalizeKana { get; init; }

		[JsonInclude]
		[JsonPropertyName("normalize_kanji")]
		public bool NormalizeKanji { get; init; }
	}

	public partial class KuromojiPartOfSpeechTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "kuromoji_part_of_speech";
		[JsonInclude]
		[JsonPropertyName("stoptags")]
		public IReadOnlyCollection<string> Stoptags { get; init; }
	}

	public partial class KuromojiReadingFormTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "kuromoji_readingform";
		[JsonInclude]
		[JsonPropertyName("use_romaji")]
		public bool UseRomaji { get; init; }
	}

	public partial class KuromojiStemmerTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "kuromoji_stemmer";
		[JsonInclude]
		[JsonPropertyName("minimum_length")]
		public int MinimumLength { get; init; }
	}

	public partial class KuromojiTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "kuromoji_tokenizer";
		[JsonInclude]
		[JsonPropertyName("discard_punctuation")]
		public bool? DiscardPunctuation { get; init; }

		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.Analysis.KuromojiTokenizationMode Mode { get; init; }

		[JsonInclude]
		[JsonPropertyName("nbest_cost")]
		public int? NbestCost { get; init; }

		[JsonInclude]
		[JsonPropertyName("nbest_examples")]
		public string? NbestExamples { get; init; }

		[JsonInclude]
		[JsonPropertyName("user_dictionary")]
		public string? UserDictionary { get; init; }

		[JsonInclude]
		[JsonPropertyName("user_dictionary_rules")]
		public IReadOnlyCollection<string>? UserDictionaryRules { get; init; }

		[JsonInclude]
		[JsonPropertyName("discard_compound_token")]
		public bool? DiscardCompoundToken { get; init; }
	}

	public partial class LanguageAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "language";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		[JsonInclude]
		[JsonPropertyName("language")]
		public Elastic.Clients.Elasticsearch.Analysis.Language Language { get; init; }

		[JsonInclude]
		[JsonPropertyName("stem_exclusion")]
		public IReadOnlyCollection<string> StemExclusion { get; init; }

		[JsonInclude]
		[JsonPropertyName("stopwords")]
		public Elastic.Clients.Elasticsearch.Analysis.StopWords? Stopwords { get; init; }

		[JsonInclude]
		[JsonPropertyName("stopwords_path")]
		public string? StopwordsPath { get; init; }
	}

	public partial class LengthTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "length";
		[JsonInclude]
		[JsonPropertyName("max")]
		public int Max { get; init; }

		[JsonInclude]
		[JsonPropertyName("min")]
		public int Min { get; init; }
	}

	public partial class LetterTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "letter";
	}

	public partial class LimitTokenCountTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "limit";
		[JsonInclude]
		[JsonPropertyName("consume_all_tokens")]
		public bool ConsumeAllTokens { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_token_count")]
		public int MaxTokenCount { get; init; }
	}

	public partial class LowercaseNormalizer : INormalizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "lowercase";
	}

	public partial class LowercaseTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "lowercase";
		[JsonInclude]
		[JsonPropertyName("language")]
		public string? Language { get; init; }
	}

	public partial class LowercaseTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "lowercase";
	}

	public partial class MappingCharFilter : Analysis.CharFilterBase, ICharFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "mapping";
		[JsonInclude]
		[JsonPropertyName("mappings")]
		public IReadOnlyCollection<string> Mappings { get; init; }

		[JsonInclude]
		[JsonPropertyName("mappings_path")]
		public string? MappingsPath { get; init; }
	}

	public partial class MultiplexerTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "multiplexer";
		[JsonInclude]
		[JsonPropertyName("filters")]
		public IReadOnlyCollection<string> Filters { get; init; }

		[JsonInclude]
		[JsonPropertyName("preserve_original")]
		public bool PreserveOriginal { get; init; }
	}

	public partial class NGramTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "ngram";
		[JsonInclude]
		[JsonPropertyName("max_gram")]
		public int? MaxGram { get; init; }

		[JsonInclude]
		[JsonPropertyName("min_gram")]
		public int? MinGram { get; init; }

		[JsonInclude]
		[JsonPropertyName("preserve_original")]
		public bool? PreserveOriginal { get; init; }
	}

	public partial class NGramTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "ngram";
		[JsonInclude]
		[JsonPropertyName("custom_token_chars")]
		public string? CustomTokenChars { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_gram")]
		public int MaxGram { get; init; }

		[JsonInclude]
		[JsonPropertyName("min_gram")]
		public int MinGram { get; init; }

		[JsonInclude]
		[JsonPropertyName("token_chars")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Analysis.TokenChar> TokenChars { get; init; }
	}

	public partial class NoriAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "nori";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		[JsonInclude]
		[JsonPropertyName("decompound_mode")]
		public Elastic.Clients.Elasticsearch.Analysis.NoriDecompoundMode? DecompoundMode { get; init; }

		[JsonInclude]
		[JsonPropertyName("stoptags")]
		public IReadOnlyCollection<string>? Stoptags { get; init; }

		[JsonInclude]
		[JsonPropertyName("user_dictionary")]
		public string? UserDictionary { get; init; }
	}

	public partial class NoriPartOfSpeechTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "nori_part_of_speech";
		[JsonInclude]
		[JsonPropertyName("stoptags")]
		public IReadOnlyCollection<string> Stoptags { get; init; }
	}

	public partial class NoriTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "nori_tokenizer";
		[JsonInclude]
		[JsonPropertyName("decompound_mode")]
		public Elastic.Clients.Elasticsearch.Analysis.NoriDecompoundMode? DecompoundMode { get; init; }

		[JsonInclude]
		[JsonPropertyName("discard_punctuation")]
		public bool? DiscardPunctuation { get; init; }

		[JsonInclude]
		[JsonPropertyName("user_dictionary")]
		public string? UserDictionary { get; init; }

		[JsonInclude]
		[JsonPropertyName("user_dictionary_rules")]
		public IReadOnlyCollection<string>? UserDictionaryRules { get; init; }
	}

	public partial class PathHierarchyTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "path_hierarchy";
		[JsonInclude]
		[JsonPropertyName("buffer_size")]
		public int BufferSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("delimiter")]
		public string Delimiter { get; init; }

		[JsonInclude]
		[JsonPropertyName("replacement")]
		public string Replacement { get; init; }

		[JsonInclude]
		[JsonPropertyName("reverse")]
		public bool Reverse { get; init; }

		[JsonInclude]
		[JsonPropertyName("skip")]
		public int Skip { get; init; }
	}

	public partial class PatternAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "pattern";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		[JsonInclude]
		[JsonPropertyName("flags")]
		public string? Flags { get; init; }

		[JsonInclude]
		[JsonPropertyName("lowercase")]
		public bool? Lowercase { get; init; }

		[JsonInclude]
		[JsonPropertyName("pattern")]
		public string Pattern { get; init; }

		[JsonInclude]
		[JsonPropertyName("stopwords")]
		public Elastic.Clients.Elasticsearch.Analysis.StopWords? Stopwords { get; init; }
	}

	public partial class PatternCaptureTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "pattern_capture";
		[JsonInclude]
		[JsonPropertyName("patterns")]
		public IReadOnlyCollection<string> Patterns { get; init; }

		[JsonInclude]
		[JsonPropertyName("preserve_original")]
		public bool PreserveOriginal { get; init; }
	}

	public partial class PatternReplaceCharFilter : Analysis.CharFilterBase, ICharFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "pattern_replace";
		[JsonInclude]
		[JsonPropertyName("flags")]
		public string Flags { get; init; }

		[JsonInclude]
		[JsonPropertyName("pattern")]
		public string Pattern { get; init; }

		[JsonInclude]
		[JsonPropertyName("replacement")]
		public string Replacement { get; init; }
	}

	public partial class PatternReplaceTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "pattern_replace";
		[JsonInclude]
		[JsonPropertyName("flags")]
		public string Flags { get; init; }

		[JsonInclude]
		[JsonPropertyName("pattern")]
		public string Pattern { get; init; }

		[JsonInclude]
		[JsonPropertyName("replacement")]
		public string Replacement { get; init; }
	}

	public partial class PatternTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "pattern";
		[JsonInclude]
		[JsonPropertyName("flags")]
		public string Flags { get; init; }

		[JsonInclude]
		[JsonPropertyName("group")]
		public int Group { get; init; }

		[JsonInclude]
		[JsonPropertyName("pattern")]
		public string Pattern { get; init; }
	}

	public partial class PhoneticTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "phonetic";
		[JsonInclude]
		[JsonPropertyName("encoder")]
		public Elastic.Clients.Elasticsearch.Analysis.PhoneticEncoder Encoder { get; init; }

		[JsonInclude]
		[JsonPropertyName("languageset")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Analysis.PhoneticLanguage> Languageset { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_code_len")]
		public int? MaxCodeLen { get; init; }

		[JsonInclude]
		[JsonPropertyName("name_type")]
		public Elastic.Clients.Elasticsearch.Analysis.PhoneticNameType NameType { get; init; }

		[JsonInclude]
		[JsonPropertyName("replace")]
		public bool? Replace { get; init; }

		[JsonInclude]
		[JsonPropertyName("rule_type")]
		public Elastic.Clients.Elasticsearch.Analysis.PhoneticRuleType RuleType { get; init; }
	}

	public partial class PorterStemTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "porter_stem";
	}

	public partial class PredicateTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "predicate_token_filter";
		[JsonInclude]
		[JsonPropertyName("script")]
		public Elastic.Clients.Elasticsearch.Script Script { get; init; }
	}

	public partial class RemoveDuplicatesTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "remove_duplicates";
	}

	public partial class ReverseTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "reverse";
	}

	public partial class ShingleTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "shingle";
		[JsonInclude]
		[JsonPropertyName("filler_token")]
		public string? FillerToken { get; init; }

		[JsonInclude]
		[JsonPropertyName("max_shingle_size")]
		public Union<int?, string?>? MaxShingleSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("min_shingle_size")]
		public Union<int?, string?>? MinShingleSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("output_unigrams")]
		public bool? OutputUnigrams { get; init; }

		[JsonInclude]
		[JsonPropertyName("output_unigrams_if_no_shingles")]
		public bool? OutputUnigramsIfNoShingles { get; init; }

		[JsonInclude]
		[JsonPropertyName("token_separator")]
		public string? TokenSeparator { get; init; }
	}

	public partial class SimpleAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "simple";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }
	}

	public partial class SnowballAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "snowball";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		[JsonInclude]
		[JsonPropertyName("language")]
		public Elastic.Clients.Elasticsearch.Analysis.SnowballLanguage Language { get; init; }

		[JsonInclude]
		[JsonPropertyName("stopwords")]
		public Elastic.Clients.Elasticsearch.Analysis.StopWords? Stopwords { get; init; }
	}

	public partial class SnowballTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "snowball";
		[JsonInclude]
		[JsonPropertyName("language")]
		public Elastic.Clients.Elasticsearch.Analysis.SnowballLanguage Language { get; init; }
	}

	public partial class StandardAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "standard";
		[JsonInclude]
		[JsonPropertyName("max_token_length")]
		public int? MaxTokenLength { get; init; }

		[JsonInclude]
		[JsonPropertyName("stopwords")]
		public Elastic.Clients.Elasticsearch.Analysis.StopWords? Stopwords { get; init; }
	}

	public partial class StandardTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "standard";
		[JsonInclude]
		[JsonPropertyName("max_token_length")]
		public int? MaxTokenLength { get; init; }
	}

	public partial class StemmerOverrideTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "stemmer_override";
		[JsonInclude]
		[JsonPropertyName("rules")]
		public IReadOnlyCollection<string>? Rules { get; init; }

		[JsonInclude]
		[JsonPropertyName("rules_path")]
		public string? RulesPath { get; init; }
	}

	public partial class StemmerTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "stemmer";
		[JsonInclude]
		[JsonPropertyName("language")]
		public string Language { get; init; }
	}

	public partial class StopAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "stop";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }

		[JsonInclude]
		[JsonPropertyName("stopwords")]
		public Elastic.Clients.Elasticsearch.Analysis.StopWords? Stopwords { get; init; }

		[JsonInclude]
		[JsonPropertyName("stopwords_path")]
		public string? StopwordsPath { get; init; }
	}

	public partial class StopTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "stop";
		[JsonInclude]
		[JsonPropertyName("ignore_case")]
		public bool? IgnoreCase { get; init; }

		[JsonInclude]
		[JsonPropertyName("remove_trailing")]
		public bool? RemoveTrailing { get; init; }

		[JsonInclude]
		[JsonPropertyName("stopwords")]
		public Elastic.Clients.Elasticsearch.Analysis.StopWords Stopwords { get; init; }

		[JsonInclude]
		[JsonPropertyName("stopwords_path")]
		public string? StopwordsPath { get; init; }
	}

	public partial class SynonymGraphTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "synonym_graph";
		[JsonInclude]
		[JsonPropertyName("expand")]
		public bool? Expand { get; init; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public Elastic.Clients.Elasticsearch.Analysis.SynonymFormat? Format { get; init; }

		[JsonInclude]
		[JsonPropertyName("lenient")]
		public bool? Lenient { get; init; }

		[JsonInclude]
		[JsonPropertyName("synonyms")]
		public IReadOnlyCollection<string>? Synonyms { get; init; }

		[JsonInclude]
		[JsonPropertyName("synonyms_path")]
		public string? SynonymsPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("tokenizer")]
		public string? Tokenizer { get; init; }

		[JsonInclude]
		[JsonPropertyName("updateable")]
		public bool? Updateable { get; init; }
	}

	public partial class SynonymTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "synonym";
		[JsonInclude]
		[JsonPropertyName("expand")]
		public bool? Expand { get; init; }

		[JsonInclude]
		[JsonPropertyName("format")]
		public Elastic.Clients.Elasticsearch.Analysis.SynonymFormat? Format { get; init; }

		[JsonInclude]
		[JsonPropertyName("lenient")]
		public bool? Lenient { get; init; }

		[JsonInclude]
		[JsonPropertyName("synonyms")]
		public IReadOnlyCollection<string>? Synonyms { get; init; }

		[JsonInclude]
		[JsonPropertyName("synonyms_path")]
		public string? SynonymsPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("tokenizer")]
		public string? Tokenizer { get; init; }

		[JsonInclude]
		[JsonPropertyName("updateable")]
		public bool? Updateable { get; init; }
	}

	public abstract partial class TokenFilterBase
	{
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }
	}

	public abstract partial class TokenizerBase
	{
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }
	}

	public partial class TrimTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "trim";
	}

	public partial class TruncateTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "truncate";
		[JsonInclude]
		[JsonPropertyName("length")]
		public int Length { get; init; }
	}

	public partial class UaxEmailUrlTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "uax_url_email";
		[JsonInclude]
		[JsonPropertyName("max_token_length")]
		public int? MaxTokenLength { get; init; }
	}

	public partial class UniqueTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "unique";
		[JsonInclude]
		[JsonPropertyName("only_on_same_position")]
		public bool? OnlyOnSamePosition { get; init; }
	}

	public partial class UppercaseTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "uppercase";
	}

	public partial class WhitespaceAnalyzer : IAnalyzersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "whitespace";
		[JsonInclude]
		[JsonPropertyName("version")]
		public string? Version { get; init; }
	}

	public partial class WhitespaceTokenizer : Analysis.TokenizerBase, ITokenizersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "whitespace";
		[JsonInclude]
		[JsonPropertyName("max_token_length")]
		public int? MaxTokenLength { get; init; }
	}

	public partial class WordDelimiterGraphTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "word_delimiter_graph";
		[JsonInclude]
		[JsonPropertyName("adjust_offsets")]
		public bool? AdjustOffsets { get; init; }

		[JsonInclude]
		[JsonPropertyName("catenate_all")]
		public bool? CatenateAll { get; init; }

		[JsonInclude]
		[JsonPropertyName("catenate_numbers")]
		public bool? CatenateNumbers { get; init; }

		[JsonInclude]
		[JsonPropertyName("catenate_words")]
		public bool? CatenateWords { get; init; }

		[JsonInclude]
		[JsonPropertyName("generate_number_parts")]
		public bool? GenerateNumberParts { get; init; }

		[JsonInclude]
		[JsonPropertyName("generate_word_parts")]
		public bool? GenerateWordParts { get; init; }

		[JsonInclude]
		[JsonPropertyName("ignore_keywords")]
		public bool? IgnoreKeywords { get; init; }

		[JsonInclude]
		[JsonPropertyName("preserve_original")]
		public bool? PreserveOriginal { get; init; }

		[JsonInclude]
		[JsonPropertyName("protected_words")]
		public IReadOnlyCollection<string>? ProtectedWords { get; init; }

		[JsonInclude]
		[JsonPropertyName("protected_words_path")]
		public string? ProtectedWordsPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("split_on_case_change")]
		public bool? SplitOnCaseChange { get; init; }

		[JsonInclude]
		[JsonPropertyName("split_on_numerics")]
		public bool? SplitOnNumerics { get; init; }

		[JsonInclude]
		[JsonPropertyName("stem_english_possessive")]
		public bool? StemEnglishPossessive { get; init; }

		[JsonInclude]
		[JsonPropertyName("type_table")]
		public IReadOnlyCollection<string>? TypeTable { get; init; }

		[JsonInclude]
		[JsonPropertyName("type_table_path")]
		public string? TypeTablePath { get; init; }
	}

	public partial class WordDelimiterTokenFilter : Analysis.TokenFilterBase, ITokenFiltersVariant
	{
		[JsonInclude]
		[JsonPropertyName("type")]
		public string Type => "word_delimiter";
		[JsonInclude]
		[JsonPropertyName("catenate_all")]
		public bool? CatenateAll { get; init; }

		[JsonInclude]
		[JsonPropertyName("catenate_numbers")]
		public bool? CatenateNumbers { get; init; }

		[JsonInclude]
		[JsonPropertyName("catenate_words")]
		public bool? CatenateWords { get; init; }

		[JsonInclude]
		[JsonPropertyName("generate_number_parts")]
		public bool? GenerateNumberParts { get; init; }

		[JsonInclude]
		[JsonPropertyName("generate_word_parts")]
		public bool? GenerateWordParts { get; init; }

		[JsonInclude]
		[JsonPropertyName("preserve_original")]
		public bool? PreserveOriginal { get; init; }

		[JsonInclude]
		[JsonPropertyName("protected_words")]
		public IReadOnlyCollection<string>? ProtectedWords { get; init; }

		[JsonInclude]
		[JsonPropertyName("protected_words_path")]
		public string? ProtectedWordsPath { get; init; }

		[JsonInclude]
		[JsonPropertyName("split_on_case_change")]
		public bool? SplitOnCaseChange { get; init; }

		[JsonInclude]
		[JsonPropertyName("split_on_numerics")]
		public bool? SplitOnNumerics { get; init; }

		[JsonInclude]
		[JsonPropertyName("stem_english_possessive")]
		public bool? StemEnglishPossessive { get; init; }

		[JsonInclude]
		[JsonPropertyName("type_table")]
		public IReadOnlyCollection<string>? TypeTable { get; init; }

		[JsonInclude]
		[JsonPropertyName("type_table_path")]
		public string? TypeTablePath { get; init; }
	}
}
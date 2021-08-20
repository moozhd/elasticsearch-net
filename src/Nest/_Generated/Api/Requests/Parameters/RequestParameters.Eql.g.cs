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
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest.Eql
{
	public class DeleteRequestParameters : RequestParameters<DeleteRequestParameters>
	{
	}

	public class GetRequestParameters : RequestParameters<GetRequestParameters>
	{
		[JsonIgnore]
		public Nest.Time? KeepAlive { get => Q<Nest.Time?>("keep_alive"); set => Q("keep_alive", value); }

		[JsonIgnore]
		public Nest.Time? WaitForCompletionTimeout { get => Q<Nest.Time?>("wait_for_completion_timeout"); set => Q("wait_for_completion_timeout", value); }
	}

	public class GetStatusRequestParameters : RequestParameters<GetStatusRequestParameters>
	{
	}

	public class SearchRequestParameters : RequestParameters<SearchRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Nest.ExpandWildcards? ExpandWildcards { get => Q<Nest.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public Nest.Time? KeepAlive { get => Q<Nest.Time?>("keep_alive"); set => Q("keep_alive", value); }

		[JsonIgnore]
		public bool? KeepOnCompletion { get => Q<bool?>("keep_on_completion"); set => Q("keep_on_completion", value); }

		[JsonIgnore]
		public Nest.Time? WaitForCompletionTimeout { get => Q<Nest.Time?>("wait_for_completion_timeout"); set => Q("wait_for_completion_timeout", value); }
	}
}
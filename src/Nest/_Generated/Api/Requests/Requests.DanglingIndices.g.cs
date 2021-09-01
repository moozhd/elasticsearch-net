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
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.DanglingIndices
{
	[ConvertAs(typeof(DeleteDanglingIndexRequest))]
	public partial interface IDeleteDanglingIndexRequest : IRequest<DeleteDanglingIndexRequestParameters>
	{
	}

	public partial class DeleteDanglingIndexRequest : PlainRequestBase<DeleteDanglingIndexRequestParameters>, IDeleteDanglingIndexRequest
	{
		protected IDeleteDanglingIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.DanglingIndicesDeleteDanglingIndex;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_dangling/{index_uuid}</summary>
  //      public DeleteDanglingIndexRequest(string index_uuid) : base(r => r.Required("index_uuid", index_uuid))
		//{
		//}

		[JsonIgnore]
		public bool AcceptDataLoss { get => Q<bool>("accept_data_loss"); set => Q("accept_data_loss", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	[ConvertAs(typeof(ImportDanglingIndexRequest))]
	public partial interface IImportDanglingIndexRequest : IRequest<ImportDanglingIndexRequestParameters>
	{
	}

	public partial class ImportDanglingIndexRequest : PlainRequestBase<ImportDanglingIndexRequestParameters>, IImportDanglingIndexRequest
	{
		protected IImportDanglingIndexRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.DanglingIndicesImportDanglingIndex;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_dangling/{index_uuid}</summary>
  //      public ImportDanglingIndexRequest(string index_uuid) : base(r => r.Required("index_uuid", index_uuid))
		//{
		//}

		[JsonIgnore]
		public bool AcceptDataLoss { get => Q<bool>("accept_data_loss"); set => Q("accept_data_loss", value); }

		[JsonIgnore]
		public Nest.Time? MasterTimeout { get => Q<Nest.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Nest.Time? Timeout { get => Q<Nest.Time?>("timeout"); set => Q("timeout", value); }
	}

	[ConvertAs(typeof(ListDanglingIndicesRequest))]
	public partial interface IListDanglingIndicesRequest : IRequest<ListDanglingIndicesRequestParameters>
	{
	}

	public partial class ListDanglingIndicesRequest : PlainRequestBase<ListDanglingIndicesRequestParameters>, IListDanglingIndicesRequest
	{
		protected IListDanglingIndicesRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.DanglingIndicesListDanglingIndices;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_dangling</summary>
        public ListDanglingIndicesRequest() : base()
		{
		}
	}
}
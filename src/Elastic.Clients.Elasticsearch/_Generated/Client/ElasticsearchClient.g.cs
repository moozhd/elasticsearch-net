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

using Elastic.Clients.Elasticsearch.AsyncSearch;
using Elastic.Clients.Elasticsearch.Cluster;
using Elastic.Clients.Elasticsearch.IndexManagement;
using System;
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Elastic.Clients.Elasticsearch
{
	public partial class ElasticsearchClient : IElasticsearchClient
	{
		public AsyncSearchNamespace AsyncSearch { get; private set; }

		public ClusterNamespace Cluster { get; private set; }

		public IndexManagementNamespace IndexManagement { get; private set; }

		private partial void SetupNamespaces()
		{
			AsyncSearch = new AsyncSearchNamespace(this);
			Cluster = new ClusterNamespace(this);
			IndexManagement = new IndexManagementNamespace(this);
		}

		public BulkResponse Bulk(BulkRequest request)
		{
			request.BeforeRequest();
			return DoRequest<BulkRequest, BulkResponse>(request);
		}

		public Task<BulkResponse> BulkAsync(BulkRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<BulkRequest, BulkResponse>(request, cancellationToken);
		}

		public BulkResponse Bulk(Action<BulkRequestDescriptor> configureRequest = null)
		{
			var descriptor = new BulkRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<BulkRequestDescriptor, BulkResponse>(descriptor);
		}

		public Task<BulkResponse> BulkAsync(Action<BulkRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new BulkRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<BulkRequestDescriptor, BulkResponse>(descriptor);
		}

		public ClosePointInTimeResponse ClosePointInTime(ClosePointInTimeRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ClosePointInTimeRequest, ClosePointInTimeResponse>(request);
		}

		public Task<ClosePointInTimeResponse> ClosePointInTimeAsync(ClosePointInTimeRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ClosePointInTimeRequest, ClosePointInTimeResponse>(request, cancellationToken);
		}

		public ClosePointInTimeResponse ClosePointInTime(Action<ClosePointInTimeRequestDescriptor> configureRequest = null)
		{
			var descriptor = new ClosePointInTimeRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<ClosePointInTimeRequestDescriptor, ClosePointInTimeResponse>(descriptor);
		}

		public Task<ClosePointInTimeResponse> ClosePointInTimeAsync(Action<ClosePointInTimeRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new ClosePointInTimeRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<ClosePointInTimeRequestDescriptor, ClosePointInTimeResponse>(descriptor);
		}

		public CountResponse Count(CountRequest request)
		{
			request.BeforeRequest();
			return DoRequest<CountRequest, CountResponse>(request);
		}

		public Task<CountResponse> CountAsync(CountRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<CountRequest, CountResponse>(request, cancellationToken);
		}

		public CountResponse Count<TDocument>(Action<CountRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new CountRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<CountRequestDescriptor<TDocument>, CountResponse>(descriptor);
		}

		public Task<CountResponse> CountAsync<TDocument>(Action<CountRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new CountRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<CountRequestDescriptor<TDocument>, CountResponse>(descriptor);
		}

		public CreateResponse Create<TDocument>(CreateRequest<TDocument> request)
		{
			request.BeforeRequest();
			return DoRequest<CreateRequest<TDocument>, CreateResponse>(request);
		}

		public Task<CreateResponse> CreateAsync<TDocument>(CreateRequest<TDocument> request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<CreateRequest<TDocument>, CreateResponse>(request, cancellationToken);
		}

		public CreateResponse Create<TDocument>(TDocument document, Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<CreateRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new CreateRequestDescriptor<TDocument>(index, id);
			configureRequest?.Invoke(descriptor);
			descriptor.Document(document);
			return DoRequest<CreateRequestDescriptor<TDocument>, CreateResponse>(descriptor);
		}

		public Task<CreateResponse> CreateAsync<TDocument>(TDocument document, Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<CreateRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new CreateRequestDescriptor<TDocument>(index, id);
			configureRequest?.Invoke(descriptor);
			descriptor.Document(document);
			return DoRequestAsync<CreateRequestDescriptor<TDocument>, CreateResponse>(descriptor);
		}

		public DeleteResponse Delete(DeleteRequest request)
		{
			request.BeforeRequest();
			return DoRequest<DeleteRequest, DeleteResponse>(request);
		}

		public Task<DeleteResponse> DeleteAsync(DeleteRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<DeleteRequest, DeleteResponse>(request, cancellationToken);
		}

		public DeleteResponse Delete(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<DeleteRequestDescriptor> configureRequest = null)
		{
			var descriptor = new DeleteRequestDescriptor(index, id);
			configureRequest?.Invoke(descriptor);
			return DoRequest<DeleteRequestDescriptor, DeleteResponse>(descriptor);
		}

		public Task<DeleteResponse> DeleteAsync(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<DeleteRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new DeleteRequestDescriptor(index, id);
			configureRequest?.Invoke(descriptor);
			return DoRequestAsync<DeleteRequestDescriptor, DeleteResponse>(descriptor);
		}

		public ExistsResponse Exists(ExistsRequest request)
		{
			request.BeforeRequest();
			return DoRequest<ExistsRequest, ExistsResponse>(request);
		}

		public Task<ExistsResponse> ExistsAsync(ExistsRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<ExistsRequest, ExistsResponse>(request, cancellationToken);
		}

		public ExistsResponse Exists<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<ExistsRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new ExistsRequestDescriptor<TDocument>(index, id);
			configureRequest?.Invoke(descriptor);
			return DoRequest<ExistsRequestDescriptor<TDocument>, ExistsResponse>(descriptor);
		}

		public Task<ExistsResponse> ExistsAsync<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<ExistsRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new ExistsRequestDescriptor<TDocument>(index, id);
			configureRequest?.Invoke(descriptor);
			return DoRequestAsync<ExistsRequestDescriptor<TDocument>, ExistsResponse>(descriptor);
		}

		public GetResponse<TDocument> Get<TDocument>(GetRequest request)
		{
			request.BeforeRequest();
			return DoRequest<GetRequest, GetResponse<TDocument>>(request);
		}

		public Task<GetResponse<TDocument>> GetAsync<TDocument>(GetRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<GetRequest, GetResponse<TDocument>>(request, cancellationToken);
		}

		public GetResponse<TDocument> Get<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<GetRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new GetRequestDescriptor<TDocument>(index, id);
			configureRequest?.Invoke(descriptor);
			return DoRequest<GetRequestDescriptor<TDocument>, GetResponse<TDocument>>(descriptor);
		}

		public Task<GetResponse<TDocument>> GetAsync<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<GetRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new GetRequestDescriptor<TDocument>(index, id);
			configureRequest?.Invoke(descriptor);
			return DoRequestAsync<GetRequestDescriptor<TDocument>, GetResponse<TDocument>>(descriptor);
		}

		public IndexResponse Index<TDocument>(IndexRequest<TDocument> request)
		{
			request.BeforeRequest();
			return DoRequest<IndexRequest<TDocument>, IndexResponse>(request);
		}

		public Task<IndexResponse> IndexAsync<TDocument>(IndexRequest<TDocument> request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<IndexRequest<TDocument>, IndexResponse>(request, cancellationToken);
		}

		public IndexResponse Index<TDocument>(TDocument document, Elastic.Clients.Elasticsearch.IndexName index, Action<IndexRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new IndexRequestDescriptor<TDocument>(index);
			configureRequest?.Invoke(descriptor);
			descriptor.Document(document);
			return DoRequest<IndexRequestDescriptor<TDocument>, IndexResponse>(descriptor);
		}

		public Task<IndexResponse> IndexAsync<TDocument>(TDocument document, Elastic.Clients.Elasticsearch.IndexName index, Action<IndexRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new IndexRequestDescriptor<TDocument>(index);
			configureRequest?.Invoke(descriptor);
			descriptor.Document(document);
			return DoRequestAsync<IndexRequestDescriptor<TDocument>, IndexResponse>(descriptor);
		}

		public OpenPointInTimeResponse OpenPointInTime(OpenPointInTimeRequest request)
		{
			request.BeforeRequest();
			return DoRequest<OpenPointInTimeRequest, OpenPointInTimeResponse>(request);
		}

		public Task<OpenPointInTimeResponse> OpenPointInTimeAsync(OpenPointInTimeRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<OpenPointInTimeRequest, OpenPointInTimeResponse>(request, cancellationToken);
		}

		public OpenPointInTimeResponse OpenPointInTime(Elastic.Clients.Elasticsearch.Indices indices, Action<OpenPointInTimeRequestDescriptor> configureRequest = null)
		{
			var descriptor = new OpenPointInTimeRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			return DoRequest<OpenPointInTimeRequestDescriptor, OpenPointInTimeResponse>(descriptor);
		}

		public Task<OpenPointInTimeResponse> OpenPointInTimeAsync(Elastic.Clients.Elasticsearch.Indices indices, Action<OpenPointInTimeRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new OpenPointInTimeRequestDescriptor(indices);
			configureRequest?.Invoke(descriptor);
			return DoRequestAsync<OpenPointInTimeRequestDescriptor, OpenPointInTimeResponse>(descriptor);
		}

		public PingResponse Ping(PingRequest request)
		{
			request.BeforeRequest();
			return DoRequest<PingRequest, PingResponse>(request);
		}

		public Task<PingResponse> PingAsync(PingRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<PingRequest, PingResponse>(request, cancellationToken);
		}

		public PingResponse Ping(Action<PingRequestDescriptor> configureRequest = null)
		{
			var descriptor = new PingRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<PingRequestDescriptor, PingResponse>(descriptor);
		}

		public Task<PingResponse> PingAsync(Action<PingRequestDescriptor> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new PingRequestDescriptor();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<PingRequestDescriptor, PingResponse>(descriptor);
		}

		public SearchResponse<TDocument> Search<TDocument>(SearchRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SearchRequest, SearchResponse<TDocument>>(request);
		}

		public Task<SearchResponse<TDocument>> SearchAsync<TDocument>(SearchRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SearchRequest, SearchResponse<TDocument>>(request, cancellationToken);
		}

		public SearchResponse<TDocument> Search<TDocument>(Action<SearchRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new SearchRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequest<SearchRequestDescriptor<TDocument>, SearchResponse<TDocument>>(descriptor);
		}

		public Task<SearchResponse<TDocument>> SearchAsync<TDocument>(Action<SearchRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new SearchRequestDescriptor<TDocument>();
			configureRequest?.Invoke(descriptor);
			descriptor.BeforeRequest();
			return DoRequestAsync<SearchRequestDescriptor<TDocument>, SearchResponse<TDocument>>(descriptor);
		}

		public SourceResponse<TDocument> Source<TDocument>(SourceRequest request)
		{
			request.BeforeRequest();
			return DoRequest<SourceRequest, SourceResponse<TDocument>>(request);
		}

		public Task<SourceResponse<TDocument>> SourceAsync<TDocument>(SourceRequest request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<SourceRequest, SourceResponse<TDocument>>(request, cancellationToken);
		}

		public SourceResponse<TDocument> Source<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<SourceRequestDescriptor<TDocument>> configureRequest = null)
		{
			var descriptor = new SourceRequestDescriptor<TDocument>(index, id);
			configureRequest?.Invoke(descriptor);
			return DoRequest<SourceRequestDescriptor<TDocument>, SourceResponse<TDocument>>(descriptor);
		}

		public Task<SourceResponse<TDocument>> SourceAsync<TDocument>(Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<SourceRequestDescriptor<TDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new SourceRequestDescriptor<TDocument>(index, id);
			configureRequest?.Invoke(descriptor);
			return DoRequestAsync<SourceRequestDescriptor<TDocument>, SourceResponse<TDocument>>(descriptor);
		}

		public UpdateResponse<TDocument> Update<TDocument, TPartialDocument>(UpdateRequest<TDocument, TPartialDocument> request)
		{
			request.BeforeRequest();
			return DoRequest<UpdateRequest<TDocument, TPartialDocument>, UpdateResponse<TDocument>>(request);
		}

		public Task<UpdateResponse<TDocument>> UpdateAsync<TDocument, TPartialDocument>(UpdateRequest<TDocument, TPartialDocument> request, CancellationToken cancellationToken = default)
		{
			request.BeforeRequest();
			return DoRequestAsync<UpdateRequest<TDocument, TPartialDocument>, UpdateResponse<TDocument>>(request, cancellationToken);
		}

		public UpdateResponse<TDocument> Update<TDocument, TPartialDocument>(TDocument document, TPartialDocument partialDocument, Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<UpdateRequestDescriptor<TDocument, TPartialDocument>> configureRequest = null)
		{
			var descriptor = new UpdateRequestDescriptor<TDocument, TPartialDocument>(index, id);
			configureRequest?.Invoke(descriptor);
			descriptor.Document(document);
			descriptor.PartialDocument(partialDocument);
			return DoRequest<UpdateRequestDescriptor<TDocument, TPartialDocument>, UpdateResponse<TDocument>>(descriptor);
		}

		public Task<UpdateResponse<TDocument>> UpdateAsync<TDocument, TPartialDocument>(TDocument document, TPartialDocument partialDocument, Elastic.Clients.Elasticsearch.IndexName index, Elastic.Clients.Elasticsearch.Id id, Action<UpdateRequestDescriptor<TDocument, TPartialDocument>> configureRequest = null, CancellationToken cancellationToken = default)
		{
			var descriptor = new UpdateRequestDescriptor<TDocument, TPartialDocument>(index, id);
			configureRequest?.Invoke(descriptor);
			descriptor.Document(document);
			descriptor.PartialDocument(partialDocument);
			return DoRequestAsync<UpdateRequestDescriptor<TDocument, TPartialDocument>, UpdateResponse<TDocument>>(descriptor);
		}
	}
}
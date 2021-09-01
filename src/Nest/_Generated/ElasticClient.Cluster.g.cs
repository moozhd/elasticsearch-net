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
using System.Threading;
using System.Threading.Tasks;

#nullable restore
namespace Nest.Cluster
{
	public class ClusterNamespace : NamespacedClientProxy
	{
		internal ClusterNamespace(ElasticClient client) : base(client)
		{
		}

		public AllocationExplainResponse AllocationExplain(IAllocationExplainRequest request) => DoRequest<IAllocationExplainRequest, AllocationExplainResponse>(request, request.RequestParameters);
		public Task<AllocationExplainResponse> AllocationExplainAsync(IAllocationExplainRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IAllocationExplainRequest, AllocationExplainResponse>(request, request.RequestParameters, cancellationToken);
		public AllocationExplainResponse AllocationExplain(Func<AllocationExplainDescriptor, IAllocationExplainRequest> selector = null) => AllocationExplain(selector.InvokeOrDefault(new AllocationExplainDescriptor()));
		public Task<AllocationExplainResponse> AllocationExplainAsync(Func<AllocationExplainDescriptor, IAllocationExplainRequest> selector = null, CancellationToken cancellationToken = default) => AllocationExplainAsync(selector.InvokeOrDefault(new AllocationExplainDescriptor()), cancellationToken);
		public DeleteComponentTemplateResponse DeleteComponentTemplate(IDeleteComponentTemplateRequest request) => DoRequest<IDeleteComponentTemplateRequest, DeleteComponentTemplateResponse>(request, request.RequestParameters);
		public Task<DeleteComponentTemplateResponse> DeleteComponentTemplateAsync(IDeleteComponentTemplateRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IDeleteComponentTemplateRequest, DeleteComponentTemplateResponse>(request, request.RequestParameters, cancellationToken);
		public DeleteComponentTemplateResponse DeleteComponentTemplate(Nest.Name name, Func<DeleteComponentTemplateDescriptor, IDeleteComponentTemplateRequest> selector = null) => DeleteComponentTemplate(selector.InvokeOrDefault(new DeleteComponentTemplateDescriptor(name)));
		public Task<DeleteComponentTemplateResponse> DeleteComponentTemplateAsync(Nest.Name name, Func<DeleteComponentTemplateDescriptor, IDeleteComponentTemplateRequest> selector = null, CancellationToken cancellationToken = default) => DeleteComponentTemplateAsync(selector.InvokeOrDefault(new DeleteComponentTemplateDescriptor(name)), cancellationToken);
		public DeleteVotingConfigExclusionsResponse DeleteVotingConfigExclusions(IDeleteVotingConfigExclusionsRequest request) => DoRequest<IDeleteVotingConfigExclusionsRequest, DeleteVotingConfigExclusionsResponse>(request, request.RequestParameters);
		public Task<DeleteVotingConfigExclusionsResponse> DeleteVotingConfigExclusionsAsync(IDeleteVotingConfigExclusionsRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IDeleteVotingConfigExclusionsRequest, DeleteVotingConfigExclusionsResponse>(request, request.RequestParameters, cancellationToken);
		public DeleteVotingConfigExclusionsResponse DeleteVotingConfigExclusions(Func<DeleteVotingConfigExclusionsDescriptor, IDeleteVotingConfigExclusionsRequest> selector = null) => DeleteVotingConfigExclusions(selector.InvokeOrDefault(new DeleteVotingConfigExclusionsDescriptor()));
		public Task<DeleteVotingConfigExclusionsResponse> DeleteVotingConfigExclusionsAsync(Func<DeleteVotingConfigExclusionsDescriptor, IDeleteVotingConfigExclusionsRequest> selector = null, CancellationToken cancellationToken = default) => DeleteVotingConfigExclusionsAsync(selector.InvokeOrDefault(new DeleteVotingConfigExclusionsDescriptor()), cancellationToken);
		public ExistsComponentTemplateResponse ExistsComponentTemplate(IExistsComponentTemplateRequest request) => DoRequest<IExistsComponentTemplateRequest, ExistsComponentTemplateResponse>(request, request.RequestParameters);
		public Task<ExistsComponentTemplateResponse> ExistsComponentTemplateAsync(IExistsComponentTemplateRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IExistsComponentTemplateRequest, ExistsComponentTemplateResponse>(request, request.RequestParameters, cancellationToken);
		public ExistsComponentTemplateResponse ExistsComponentTemplate(Nest.Names name, Func<ExistsComponentTemplateDescriptor, IExistsComponentTemplateRequest> selector = null) => ExistsComponentTemplate(selector.InvokeOrDefault(new ExistsComponentTemplateDescriptor(name)));
		public Task<ExistsComponentTemplateResponse> ExistsComponentTemplateAsync(Nest.Names name, Func<ExistsComponentTemplateDescriptor, IExistsComponentTemplateRequest> selector = null, CancellationToken cancellationToken = default) => ExistsComponentTemplateAsync(selector.InvokeOrDefault(new ExistsComponentTemplateDescriptor(name)), cancellationToken);
		public GetComponentTemplateResponse GetComponentTemplate(IGetComponentTemplateRequest request) => DoRequest<IGetComponentTemplateRequest, GetComponentTemplateResponse>(request, request.RequestParameters);
		public Task<GetComponentTemplateResponse> GetComponentTemplateAsync(IGetComponentTemplateRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IGetComponentTemplateRequest, GetComponentTemplateResponse>(request, request.RequestParameters, cancellationToken);
		public GetComponentTemplateResponse GetComponentTemplate(Func<GetComponentTemplateDescriptor, IGetComponentTemplateRequest> selector = null) => GetComponentTemplate(selector.InvokeOrDefault(new GetComponentTemplateDescriptor()));
		public Task<GetComponentTemplateResponse> GetComponentTemplateAsync(Func<GetComponentTemplateDescriptor, IGetComponentTemplateRequest> selector = null, CancellationToken cancellationToken = default) => GetComponentTemplateAsync(selector.InvokeOrDefault(new GetComponentTemplateDescriptor()), cancellationToken);
		public GetSettingsResponse GetSettings(IGetSettingsRequest request) => DoRequest<IGetSettingsRequest, GetSettingsResponse>(request, request.RequestParameters);
		public Task<GetSettingsResponse> GetSettingsAsync(IGetSettingsRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IGetSettingsRequest, GetSettingsResponse>(request, request.RequestParameters, cancellationToken);
		public GetSettingsResponse GetSettings(Func<GetSettingsDescriptor, IGetSettingsRequest> selector = null) => GetSettings(selector.InvokeOrDefault(new GetSettingsDescriptor()));
		public Task<GetSettingsResponse> GetSettingsAsync(Func<GetSettingsDescriptor, IGetSettingsRequest> selector = null, CancellationToken cancellationToken = default) => GetSettingsAsync(selector.InvokeOrDefault(new GetSettingsDescriptor()), cancellationToken);
		public HealthResponse Health(IHealthRequest request) => DoRequest<IHealthRequest, HealthResponse>(request, request.RequestParameters);
		public Task<HealthResponse> HealthAsync(IHealthRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IHealthRequest, HealthResponse>(request, request.RequestParameters, cancellationToken);
		public HealthResponse Health(Func<HealthDescriptor, IHealthRequest> selector = null) => Health(selector.InvokeOrDefault(new HealthDescriptor()));
		public Task<HealthResponse> HealthAsync(Func<HealthDescriptor, IHealthRequest> selector = null, CancellationToken cancellationToken = default) => HealthAsync(selector.InvokeOrDefault(new HealthDescriptor()), cancellationToken);
		public PendingTasksResponse PendingTasks(IPendingTasksRequest request) => DoRequest<IPendingTasksRequest, PendingTasksResponse>(request, request.RequestParameters);
		public Task<PendingTasksResponse> PendingTasksAsync(IPendingTasksRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IPendingTasksRequest, PendingTasksResponse>(request, request.RequestParameters, cancellationToken);
		public PendingTasksResponse PendingTasks(Func<PendingTasksDescriptor, IPendingTasksRequest> selector = null) => PendingTasks(selector.InvokeOrDefault(new PendingTasksDescriptor()));
		public Task<PendingTasksResponse> PendingTasksAsync(Func<PendingTasksDescriptor, IPendingTasksRequest> selector = null, CancellationToken cancellationToken = default) => PendingTasksAsync(selector.InvokeOrDefault(new PendingTasksDescriptor()), cancellationToken);
		public PostVotingConfigExclusionsResponse PostVotingConfigExclusions(IPostVotingConfigExclusionsRequest request) => DoRequest<IPostVotingConfigExclusionsRequest, PostVotingConfigExclusionsResponse>(request, request.RequestParameters);
		public Task<PostVotingConfigExclusionsResponse> PostVotingConfigExclusionsAsync(IPostVotingConfigExclusionsRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IPostVotingConfigExclusionsRequest, PostVotingConfigExclusionsResponse>(request, request.RequestParameters, cancellationToken);
		public PostVotingConfigExclusionsResponse PostVotingConfigExclusions(Func<PostVotingConfigExclusionsDescriptor, IPostVotingConfigExclusionsRequest> selector = null) => PostVotingConfigExclusions(selector.InvokeOrDefault(new PostVotingConfigExclusionsDescriptor()));
		public Task<PostVotingConfigExclusionsResponse> PostVotingConfigExclusionsAsync(Func<PostVotingConfigExclusionsDescriptor, IPostVotingConfigExclusionsRequest> selector = null, CancellationToken cancellationToken = default) => PostVotingConfigExclusionsAsync(selector.InvokeOrDefault(new PostVotingConfigExclusionsDescriptor()), cancellationToken);
		public PutComponentTemplateResponse PutComponentTemplate(IPutComponentTemplateRequest request) => DoRequest<IPutComponentTemplateRequest, PutComponentTemplateResponse>(request, request.RequestParameters);
		public Task<PutComponentTemplateResponse> PutComponentTemplateAsync(IPutComponentTemplateRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IPutComponentTemplateRequest, PutComponentTemplateResponse>(request, request.RequestParameters, cancellationToken);
		public PutComponentTemplateResponse PutComponentTemplate(Nest.Name name, Func<PutComponentTemplateDescriptor, IPutComponentTemplateRequest> selector = null) => PutComponentTemplate(selector.InvokeOrDefault(new PutComponentTemplateDescriptor(name)));
		public Task<PutComponentTemplateResponse> PutComponentTemplateAsync(Nest.Name name, Func<PutComponentTemplateDescriptor, IPutComponentTemplateRequest> selector = null, CancellationToken cancellationToken = default) => PutComponentTemplateAsync(selector.InvokeOrDefault(new PutComponentTemplateDescriptor(name)), cancellationToken);
		public PutSettingsResponse PutSettings(IPutSettingsRequest request) => DoRequest<IPutSettingsRequest, PutSettingsResponse>(request, request.RequestParameters);
		public Task<PutSettingsResponse> PutSettingsAsync(IPutSettingsRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IPutSettingsRequest, PutSettingsResponse>(request, request.RequestParameters, cancellationToken);
		public PutSettingsResponse PutSettings(Func<PutSettingsDescriptor, IPutSettingsRequest> selector = null) => PutSettings(selector.InvokeOrDefault(new PutSettingsDescriptor()));
		public Task<PutSettingsResponse> PutSettingsAsync(Func<PutSettingsDescriptor, IPutSettingsRequest> selector = null, CancellationToken cancellationToken = default) => PutSettingsAsync(selector.InvokeOrDefault(new PutSettingsDescriptor()), cancellationToken);
		public RemoteInfoResponse RemoteInfo(IRemoteInfoRequest request) => DoRequest<IRemoteInfoRequest, RemoteInfoResponse>(request, request.RequestParameters);
		public Task<RemoteInfoResponse> RemoteInfoAsync(IRemoteInfoRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IRemoteInfoRequest, RemoteInfoResponse>(request, request.RequestParameters, cancellationToken);
		public RemoteInfoResponse RemoteInfo(Func<RemoteInfoDescriptor, IRemoteInfoRequest> selector = null) => RemoteInfo(selector.InvokeOrDefault(new RemoteInfoDescriptor()));
		public Task<RemoteInfoResponse> RemoteInfoAsync(Func<RemoteInfoDescriptor, IRemoteInfoRequest> selector = null, CancellationToken cancellationToken = default) => RemoteInfoAsync(selector.InvokeOrDefault(new RemoteInfoDescriptor()), cancellationToken);
		public RerouteResponse Reroute(IRerouteRequest request) => DoRequest<IRerouteRequest, RerouteResponse>(request, request.RequestParameters);
		public Task<RerouteResponse> RerouteAsync(IRerouteRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IRerouteRequest, RerouteResponse>(request, request.RequestParameters, cancellationToken);
		public RerouteResponse Reroute(Func<RerouteDescriptor, IRerouteRequest> selector = null) => Reroute(selector.InvokeOrDefault(new RerouteDescriptor()));
		public Task<RerouteResponse> RerouteAsync(Func<RerouteDescriptor, IRerouteRequest> selector = null, CancellationToken cancellationToken = default) => RerouteAsync(selector.InvokeOrDefault(new RerouteDescriptor()), cancellationToken);
		public StateResponse State(IStateRequest request) => DoRequest<IStateRequest, StateResponse>(request, request.RequestParameters);
		public Task<StateResponse> StateAsync(IStateRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IStateRequest, StateResponse>(request, request.RequestParameters, cancellationToken);
		public StateResponse State(Func<StateDescriptor, IStateRequest> selector = null) => State(selector.InvokeOrDefault(new StateDescriptor()));
		public Task<StateResponse> StateAsync(Func<StateDescriptor, IStateRequest> selector = null, CancellationToken cancellationToken = default) => StateAsync(selector.InvokeOrDefault(new StateDescriptor()), cancellationToken);
		public StatsResponse Stats(IStatsRequest request) => DoRequest<IStatsRequest, StatsResponse>(request, request.RequestParameters);
		public Task<StatsResponse> StatsAsync(IStatsRequest request, CancellationToken cancellationToken = default) => DoRequestAsync<IStatsRequest, StatsResponse>(request, request.RequestParameters, cancellationToken);
		public StatsResponse Stats(Func<StatsDescriptor, IStatsRequest> selector = null) => Stats(selector.InvokeOrDefault(new StatsDescriptor()));
		public Task<StatsResponse> StatsAsync(Func<StatsDescriptor, IStatsRequest> selector = null, CancellationToken cancellationToken = default) => StatsAsync(selector.InvokeOrDefault(new StatsDescriptor()), cancellationToken);
	}
}
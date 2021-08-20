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

#nullable restore
namespace Nest.Cluster
{
	public partial class AllocationExplainDescriptor : RequestDescriptorBase<AllocationExplainDescriptor, AllocationExplainRequestParameters, IAllocationExplainRequest>, IAllocationExplainRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterAllocationExplain;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/allocation/explain</summary>
        public AllocationExplainDescriptor() : base()
		{
		}
	}

	public partial class DeleteComponentTemplateDescriptor : RequestDescriptorBase<DeleteComponentTemplateDescriptor, DeleteComponentTemplateRequestParameters, IDeleteComponentTemplateRequest>, IDeleteComponentTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterDeleteComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_component_template/{name}</summary>
        public DeleteComponentTemplateDescriptor(Nest.Name name) : base(r => r.Required("name", name))
		{
		}
	}

	public partial class DeleteVotingConfigExclusionsDescriptor : RequestDescriptorBase<DeleteVotingConfigExclusionsDescriptor, DeleteVotingConfigExclusionsRequestParameters, IDeleteVotingConfigExclusionsRequest>, IDeleteVotingConfigExclusionsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterDeleteVotingConfigExclusions;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/voting_config_exclusions</summary>
        public DeleteVotingConfigExclusionsDescriptor() : base()
		{
		}
	}

	public partial class GetComponentTemplateDescriptor : RequestDescriptorBase<GetComponentTemplateDescriptor, GetComponentTemplateRequestParameters, IGetComponentTemplateRequest>, IGetComponentTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterGetComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_component_template</summary>
        public GetComponentTemplateDescriptor() : base()
		{
		}

		///<summary>/_component_template/{name}</summary>
        public GetComponentTemplateDescriptor(Nest.Name? name) : base(r => r.Optional("name", name))
		{
		}
	}

	public partial class GetSettingsDescriptor : RequestDescriptorBase<GetSettingsDescriptor, GetSettingsRequestParameters, IGetSettingsRequest>, IGetSettingsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterGetSettings;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/settings</summary>
        public GetSettingsDescriptor() : base()
		{
		}
	}

	public partial class HealthDescriptor : RequestDescriptorBase<HealthDescriptor, HealthRequestParameters, IHealthRequest>, IHealthRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterHealth;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/health</summary>
        public HealthDescriptor() : base()
		{
		}

		///<summary>/_cluster/health/{index}</summary>
        public HealthDescriptor(Nest.Indices? index) : base(r => r.Optional("index", index))
		{
		}
	}

	public partial class PendingTasksDescriptor : RequestDescriptorBase<PendingTasksDescriptor, PendingTasksRequestParameters, IPendingTasksRequest>, IPendingTasksRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPendingTasks;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/pending_tasks</summary>
        public PendingTasksDescriptor() : base()
		{
		}
	}

	public partial class PostVotingConfigExclusionsDescriptor : RequestDescriptorBase<PostVotingConfigExclusionsDescriptor, PostVotingConfigExclusionsRequestParameters, IPostVotingConfigExclusionsRequest>, IPostVotingConfigExclusionsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPostVotingConfigExclusions;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/voting_config_exclusions</summary>
        public PostVotingConfigExclusionsDescriptor() : base()
		{
		}
	}

	public partial class PutComponentTemplateDescriptor : RequestDescriptorBase<PutComponentTemplateDescriptor, PutComponentTemplateRequestParameters, IPutComponentTemplateRequest>, IPutComponentTemplateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutComponentTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_component_template/{name}</summary>
        public PutComponentTemplateDescriptor(Nest.Name name) : base(r => r.Required("name", name))
		{
		}
	}

	public partial class PutSettingsDescriptor : RequestDescriptorBase<PutSettingsDescriptor, PutSettingsRequestParameters, IPutSettingsRequest>, IPutSettingsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterPutSettings;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/settings</summary>
        public PutSettingsDescriptor() : base()
		{
		}
	}

	public partial class RemoteInfoDescriptor : RequestDescriptorBase<RemoteInfoDescriptor, RemoteInfoRequestParameters, IRemoteInfoRequest>, IRemoteInfoRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterRemoteInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_remote/info</summary>
        public RemoteInfoDescriptor() : base()
		{
		}
	}

	public partial class RerouteDescriptor : RequestDescriptorBase<RerouteDescriptor, RerouteRequestParameters, IRerouteRequest>, IRerouteRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterReroute;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/reroute</summary>
        public RerouteDescriptor() : base()
		{
		}
	}

	public partial class StateDescriptor : RequestDescriptorBase<StateDescriptor, StateRequestParameters, IStateRequest>, IStateRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterState;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/state</summary>
        public StateDescriptor() : base()
		{
		}

		///<summary>/_cluster/state/{metric}</summary>
        public StateDescriptor(Nest.Metrics? metric) : base(r => r.Optional("metric", metric))
		{
		}

		///<summary>/_cluster/state/{metric}/{index}</summary>
        public StateDescriptor(Nest.Metrics? metric, Nest.Indices? index) : base(r => r.Optional("metric", metric).Optional("index", index))
		{
		}
	}

	public partial class StatsDescriptor : RequestDescriptorBase<StatsDescriptor, StatsRequestParameters, IStatsRequest>, IStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.ClusterStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		///<summary>/_cluster/stats</summary>
        public StatsDescriptor() : base()
		{
		}

		///<summary>/_cluster/stats/nodes/{node_id}</summary>
        public StatsDescriptor(Nest.NodeIds? node_id) : base(r => r.Optional("node_id", node_id))
		{
		}
	}
}
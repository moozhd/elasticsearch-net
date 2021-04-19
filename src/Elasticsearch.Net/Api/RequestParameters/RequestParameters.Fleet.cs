// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Specification.FleetApi
{
	///<summary>Request options for GlobalCheckpoints</summary>
	public class GlobalCheckpointsRequestParameters : RequestParameters<GlobalCheckpointsRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		public override bool SupportsBody => false;
		///<summary>Comma separated list of checkpoints</summary>
		public string[] Checkpoints
		{
			get => Q<string[]>("checkpoints");
			set => Q("checkpoints", value);
		}

		///<summary>Timeout to wait for global checkpoint to advance</summary>
		public TimeSpan Timeout
		{
			get => Q<TimeSpan>("timeout");
			set => Q("timeout", value);
		}

		///<summary>Whether to wait for the global checkpoint to advance past the specified current checkpoints</summary>
		public bool? WaitForAdvance
		{
			get => Q<bool? >("wait_for_advance");
			set => Q("wait_for_advance", value);
		}
	}
}
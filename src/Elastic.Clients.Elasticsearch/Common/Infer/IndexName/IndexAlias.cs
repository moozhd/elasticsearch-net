// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using System;
using Elastic.Transport;

namespace Elastic.Clients.Elasticsearch;

// TODO - Implement
public class IndexAlias : IUrlParameter
{
	public string GetString(ITransportConfiguration settings) => throw new NotImplementedException();
}

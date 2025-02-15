// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDB
{
    internal class CassandraClusterOperationSource : IOperationSource<CassandraClusterResource>
    {
        private readonly ArmClient _client;

        internal CassandraClusterOperationSource(ArmClient client)
        {
            _client = client;
        }

        CassandraClusterResource IOperationSource<CassandraClusterResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = CassandraClusterData.DeserializeCassandraClusterData(document.RootElement);
            return new CassandraClusterResource(_client, data);
        }

        async ValueTask<CassandraClusterResource> IOperationSource<CassandraClusterResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = CassandraClusterData.DeserializeCassandraClusterData(document.RootElement);
            return new CassandraClusterResource(_client, data);
        }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Media;
using Azure.ResourceManager.Media.Models;

namespace Azure.ResourceManager.Media.Samples
{
    public partial class Sample_MediaAssetFilterCollection
    {
        // List all Asset Filters
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListAllAssetFilters()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2022-08-01/examples/assetFilters-list-all.json
            // this example is just showing the usage of "AssetFilters_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaAssetResource created on azure
            // for more information of creating MediaAssetResource, please refer to the document of MediaAssetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso";
            string accountName = "contosomedia";
            string assetName = "ClimbingMountRainer";
            ResourceIdentifier mediaAssetResourceId = MediaAssetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, assetName);
            MediaAssetResource mediaAsset = client.GetMediaAssetResource(mediaAssetResourceId);

            // get the collection of this MediaAssetFilterResource
            MediaAssetFilterCollection collection = mediaAsset.GetMediaAssetFilters();

            // invoke the operation and iterate over the result
            await foreach (MediaAssetFilterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                MediaAssetFilterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }

        // Get an Asset Filter by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetAnAssetFilterByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2022-08-01/examples/assetFilters-get-by-name.json
            // this example is just showing the usage of "AssetFilters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaAssetResource created on azure
            // for more information of creating MediaAssetResource, please refer to the document of MediaAssetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso";
            string accountName = "contosomedia";
            string assetName = "ClimbingMountRainer";
            ResourceIdentifier mediaAssetResourceId = MediaAssetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, assetName);
            MediaAssetResource mediaAsset = client.GetMediaAssetResource(mediaAssetResourceId);

            // get the collection of this MediaAssetFilterResource
            MediaAssetFilterCollection collection = mediaAsset.GetMediaAssetFilters();

            // invoke the operation
            string filterName = "assetFilterWithTimeWindowAndTrack";
            MediaAssetFilterResource result = await collection.GetAsync(filterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaAssetFilterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Get an Asset Filter by name
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GetAnAssetFilterByName()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2022-08-01/examples/assetFilters-get-by-name.json
            // this example is just showing the usage of "AssetFilters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaAssetResource created on azure
            // for more information of creating MediaAssetResource, please refer to the document of MediaAssetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso";
            string accountName = "contosomedia";
            string assetName = "ClimbingMountRainer";
            ResourceIdentifier mediaAssetResourceId = MediaAssetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, assetName);
            MediaAssetResource mediaAsset = client.GetMediaAssetResource(mediaAssetResourceId);

            // get the collection of this MediaAssetFilterResource
            MediaAssetFilterCollection collection = mediaAsset.GetMediaAssetFilters();

            // invoke the operation
            string filterName = "assetFilterWithTimeWindowAndTrack";
            bool result = await collection.ExistsAsync(filterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // Create an Asset Filter
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_CreateAnAssetFilter()
        {
            // Generated from example definition: specification/mediaservices/resource-manager/Microsoft.Media/Metadata/stable/2022-08-01/examples/assetFilters-create.json
            // this example is just showing the usage of "AssetFilters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this MediaAssetResource created on azure
            // for more information of creating MediaAssetResource, please refer to the document of MediaAssetResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "contoso";
            string accountName = "contosomedia";
            string assetName = "ClimbingMountRainer";
            ResourceIdentifier mediaAssetResourceId = MediaAssetResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, accountName, assetName);
            MediaAssetResource mediaAsset = client.GetMediaAssetResource(mediaAssetResourceId);

            // get the collection of this MediaAssetFilterResource
            MediaAssetFilterCollection collection = mediaAsset.GetMediaAssetFilters();

            // invoke the operation
            string filterName = "newAssetFilter";
            MediaAssetFilterData data = new MediaAssetFilterData()
            {
                PresentationTimeRange = new PresentationTimeRange()
                {
                    StartTimestamp = 0,
                    EndTimestamp = 170000000,
                    PresentationWindowDuration = 9223372036854775000,
                    LiveBackoffDuration = 0,
                    Timescale = 10000000,
                    ForceEndTimestamp = false,
                },
                FirstQualityBitrate = 128000,
                Tracks =
{
new FilterTrackSelection(new FilterTrackPropertyCondition[]
{
new FilterTrackPropertyCondition(FilterTrackPropertyType.Type,"Audio",FilterTrackPropertyCompareOperation.Equal),new FilterTrackPropertyCondition(FilterTrackPropertyType.Language,"en",FilterTrackPropertyCompareOperation.NotEqual),new FilterTrackPropertyCondition(FilterTrackPropertyType.FourCC,"EC-3",FilterTrackPropertyCompareOperation.NotEqual)
}),new FilterTrackSelection(new FilterTrackPropertyCondition[]
{
new FilterTrackPropertyCondition(FilterTrackPropertyType.Type,"Video",FilterTrackPropertyCompareOperation.Equal),new FilterTrackPropertyCondition(FilterTrackPropertyType.Bitrate,"3000000-5000000",FilterTrackPropertyCompareOperation.Equal)
})
},
            };
            ArmOperation<MediaAssetFilterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, filterName, data);
            MediaAssetFilterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            MediaAssetFilterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

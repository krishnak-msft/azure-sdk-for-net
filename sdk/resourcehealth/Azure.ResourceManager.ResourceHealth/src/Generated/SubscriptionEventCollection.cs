// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ResourceHealth
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionEventResource" /> and their operations.
    /// Each <see cref="SubscriptionEventResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SubscriptionEventCollection" /> instance call the GetSubscriptionEvents method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SubscriptionEventCollection : ArmCollection, IEnumerable<SubscriptionEventResource>, IAsyncEnumerable<SubscriptionEventResource>
    {
        private readonly ClientDiagnostics _subscriptionEventEventClientDiagnostics;
        private readonly EventRestOperations _subscriptionEventEventRestClient;
        private readonly ClientDiagnostics _subscriptionEventEventsClientDiagnostics;
        private readonly EventsRestOperations _subscriptionEventEventsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionEventCollection"/> class for mocking. </summary>
        protected SubscriptionEventCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionEventCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubscriptionEventCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionEventEventClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", SubscriptionEventResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionEventResource.ResourceType, out string subscriptionEventEventApiVersion);
            _subscriptionEventEventRestClient = new EventRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionEventEventApiVersion);
            _subscriptionEventEventsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ResourceHealth", SubscriptionEventResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionEventResource.ResourceType, out string subscriptionEventEventsApiVersion);
            _subscriptionEventEventsRestClient = new EventsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionEventEventsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Service health event in the subscription by event tracking id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        public virtual async Task<Response<SubscriptionEventResource>> GetAsync(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var scope = _subscriptionEventEventClientDiagnostics.CreateScope("SubscriptionEventCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionEventEventRestClient.GetBySubscriptionIdAndTrackingIdAsync(Id.SubscriptionId, eventTrackingId, filter, queryStartTime, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Service health event in the subscription by event tracking id
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        public virtual Response<SubscriptionEventResource> Get(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var scope = _subscriptionEventEventClientDiagnostics.CreateScope("SubscriptionEventCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionEventEventRestClient.GetBySubscriptionIdAndTrackingId(Id.SubscriptionId, eventTrackingId, filter, queryStartTime, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionEventResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists service health events in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Events_ListBySubscriptionId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionEventResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionEventResource> GetAllAsync(string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionEventEventsRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId, filter, queryStartTime);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionEventEventsRestClient.CreateListBySubscriptionIdNextPageRequest(nextLink, Id.SubscriptionId, filter, queryStartTime);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SubscriptionEventResource(Client, EventData.DeserializeEventData(e)), _subscriptionEventEventsClientDiagnostics, Pipeline, "SubscriptionEventCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists service health events in the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Events_ListBySubscriptionId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionEventResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionEventResource> GetAll(string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionEventEventsRestClient.CreateListBySubscriptionIdRequest(Id.SubscriptionId, filter, queryStartTime);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionEventEventsRestClient.CreateListBySubscriptionIdNextPageRequest(nextLink, Id.SubscriptionId, filter, queryStartTime);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SubscriptionEventResource(Client, EventData.DeserializeEventData(e)), _subscriptionEventEventsClientDiagnostics, Pipeline, "SubscriptionEventCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var scope = _subscriptionEventEventClientDiagnostics.CreateScope("SubscriptionEventCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionEventEventRestClient.GetBySubscriptionIdAndTrackingIdAsync(Id.SubscriptionId, eventTrackingId, filter, queryStartTime, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ResourceHealth/events/{eventTrackingId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Event_GetBySubscriptionIdAndTrackingId</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="eventTrackingId"> Event Id which uniquely identifies ServiceHealth event. </param>
        /// <param name="filter"> The filter to apply on the operation. For more information please see https://docs.microsoft.com/en-us/rest/api/apimanagement/apis?redirectedfrom=MSDN. </param>
        /// <param name="queryStartTime"> Specifies from when to return events, based on the lastUpdateTime property. For example, queryStartTime = 7/24/2020 OR queryStartTime=7%2F24%2F2020. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="eventTrackingId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="eventTrackingId"/> is null. </exception>
        public virtual Response<bool> Exists(string eventTrackingId, string filter = null, string queryStartTime = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(eventTrackingId, nameof(eventTrackingId));

            using var scope = _subscriptionEventEventClientDiagnostics.CreateScope("SubscriptionEventCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionEventEventRestClient.GetBySubscriptionIdAndTrackingId(Id.SubscriptionId, eventTrackingId, filter, queryStartTime, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionEventResource> IEnumerable<SubscriptionEventResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionEventResource> IAsyncEnumerable<SubscriptionEventResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}

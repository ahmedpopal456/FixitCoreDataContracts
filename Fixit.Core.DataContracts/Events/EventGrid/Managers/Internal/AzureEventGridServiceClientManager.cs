using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Fixit.Core.DataContracts.Events.EventGrid.Adapters;
using Fixit.Core.DataContracts.Events.EventGrid.Adapters.Internal;
using Microsoft.Azure.EventGrid.Models;

namespace Fixit.Core.DataContracts.Events.EventGrid.Managers.Internal
{
  internal class AzureEventGridServiceClientManager : IEventGridTopicServiceClient
  {
    IEventGridServiceClientAdapter<EventGridEvent> _eventGridClient;

    public AzureEventGridServiceClientManager(string topicEndpoint, string topicKey)
    {
      if (string.IsNullOrWhiteSpace(topicEndpoint))
      {
        throw new ArgumentNullException($"{nameof(AzureEventGridServiceClientManager)} expects a value for {nameof(topicEndpoint)}... invalid argument was provided");
      }

      if (string.IsNullOrWhiteSpace(topicKey))
      {
        throw new ArgumentNullException($"{nameof(AzureEventGridServiceClientManager)} expects a value for {nameof(topicKey)}... invalid argument was provided");
      }

      _eventGridClient = new AzureEventGridServiceClientAdapter(topicEndpoint, topicKey);
    }

    public async Task<OperationStatus> PublishEventsToTopicAsync(IList<EventGridEvent> cloudEvents, CancellationToken cancellationToken = new CancellationToken())
    {
      var operationStatus = new OperationStatus { IsOperationSuccessful = true, OperationException = null };

      try
      {
        await _eventGridClient.PublishEventsToTopicAsync(cloudEvents, cancellationToken);
      }
      catch (Exception exception)
      {
        operationStatus.IsOperationSuccessful = false;
        operationStatus.OperationException = exception;
      }

      return operationStatus;
    }
  }
}

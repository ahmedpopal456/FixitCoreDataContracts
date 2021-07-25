using System;
using Fixit.Core.DataContracts.Events.EventGrid.Managers;
using Fixit.Core.DataContracts.Events.EventGrid.Managers.Internal;

namespace Fixit.Core.DataContracts.Events
{
  public static class AzureEventGridTopicServiceClientFactory
  {
    public static IEventGridTopicServiceClient CreateEventGridTopicServiceClient(string topicEndpoint, string topicKey)
    {
      if (string.IsNullOrWhiteSpace(topicEndpoint))
      {
        throw new ArgumentNullException($"{nameof(AzureEventGridTopicServiceClientFactory)}: A value for {nameof(topicEndpoint)} was expected... Null value was provided.");
      }

      if (string.IsNullOrWhiteSpace(topicKey))
      {
        throw new ArgumentNullException($"{nameof(AzureEventGridTopicServiceClientFactory)}: A value for {nameof(topicKey)} was expected... Null value was provided.");
      }

      return new AzureEventGridServiceClientManager(topicEndpoint, topicKey);
    }

    public static IEventGridTopicSubscriberClient CreateEventGridTopicSubscriberClient()
    {
      return new AzureEventGridSubscriberClientManager();
    }
  }
}

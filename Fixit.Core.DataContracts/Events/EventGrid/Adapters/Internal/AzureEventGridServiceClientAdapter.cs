using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.EventGrid;
using Microsoft.Azure.EventGrid.Models;

namespace Fixit.Core.DataContracts.Events.EventGrid.Adapters.Internal
{
	internal class AzureEventGridServiceClientAdapter : IEventGridServiceClientAdapter<EventGridEvent>
	{
		private readonly string _topicHostName;
		private readonly EventGridClient _eventGridClient;

		public AzureEventGridServiceClientAdapter(string topicEndpoint, string topicKey)
		{
			if (string.IsNullOrWhiteSpace(topicEndpoint) || !Uri.TryCreate(topicEndpoint, UriKind.Absolute, out var endpointUri))
			{
				throw new ArgumentNullException($"{nameof(AzureEventGridServiceClientAdapter)} expects a value for {nameof(topicEndpoint)}... invalid argument was provided");
			}

			if (string.IsNullOrWhiteSpace(topicKey))
			{
				throw new ArgumentNullException($"{nameof(AzureEventGridServiceClientAdapter)} expects a value for {nameof(topicKey)}... invalid argument was provided");
			}

			var topicCredentials = new TopicCredentials(topicKey);
			_eventGridClient = new EventGridClient(topicCredentials);
			_topicHostName = endpointUri.Host;
		}

		public async Task PublishEventsToTopicAsync(IList<EventGridEvent> cloudEvents, CancellationToken cancellationToken = new CancellationToken())
		{
			await _eventGridClient.PublishEventsAsync(_topicHostName, cloudEvents, cancellationToken);
		}
	}
}

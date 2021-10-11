using System;
using System.Collections.Generic;
using System.Linq;
using Fixit.Core.DataContracts.Events.EventGrid.Adapters;
using Fixit.Core.DataContracts.Events.EventGrid.Adapters.Internal;
using Microsoft.Azure.EventGrid.Models;
using Newtonsoft.Json;

namespace Fixit.Core.DataContracts.Events.EventGrid.Managers.Internal
{
	internal class AzureEventGridSubscriberClientManager : IEventGridTopicSubscriberClient
	{
		IEventGridSubscriberClientAdapter<EventGridEvent> _eventGridSubscriberClient;

		public AzureEventGridSubscriberClientManager()
		{
			_eventGridSubscriberClient = new AzureEventGridSubscriberClientAdapter();
		}

		public IList<EventGridEvent> DeserializeEventGridEvents(string requestContent)
		{
			var results = new List<EventGridEvent>();

			try
			{
				if (!string.IsNullOrWhiteSpace(requestContent))
				{
					var events = _eventGridSubscriberClient.DeserializeEventGridEvents(requestContent).ToList();
					results.AddRange(events);
				}
			}
			catch { }

			return results;
		}

		public IList<EventGridEvent> DeserializeEventGridEvents(string requestContent, JsonSerializer jsonSerializer)
		{
			var results = new List<EventGridEvent>();

			try
			{
				if (!string.IsNullOrWhiteSpace(requestContent) && jsonSerializer != null)
				{
					var events = _eventGridSubscriberClient.DeserializeEventGridEvents(requestContent, jsonSerializer).ToList();
					results.AddRange(events);
				}
			}
			catch (Exception _) { }

			return results;
		}
	}
}

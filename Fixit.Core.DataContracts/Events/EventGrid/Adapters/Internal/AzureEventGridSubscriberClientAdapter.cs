using Microsoft.Azure.EventGrid;
using Microsoft.Azure.EventGrid.Models;
using Newtonsoft.Json;

namespace Fixit.Core.DataContracts.Events.EventGrid.Adapters.Internal
{
	internal class AzureEventGridSubscriberClientAdapter : IEventGridSubscriberClientAdapter<EventGridEvent>
	{
		private readonly EventGridSubscriber _eventGridSubscriber;

		public AzureEventGridSubscriberClientAdapter()
		{
			_eventGridSubscriber = new EventGridSubscriber();
		}

		public EventGridEvent[] DeserializeEventGridEvents(string requestContent)
		{
			return _eventGridSubscriber.DeserializeEventGridEvents(requestContent);
		}

		public EventGridEvent[]DeserializeEventGridEvents(string requestContent, JsonSerializer jsonSerializer)
		{
			return _eventGridSubscriber.DeserializeEventGridEvents(requestContent, jsonSerializer);
		}
	}
}

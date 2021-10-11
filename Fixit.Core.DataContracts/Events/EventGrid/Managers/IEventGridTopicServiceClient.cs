using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.EventGrid.Models;

namespace Fixit.Core.DataContracts.Events.EventGrid.Managers
{
	public interface IEventGridTopicServiceClient
	{
		/// <summary>
		/// Publish Events to an event topic
		/// </summary>
		/// <param name="cloudEvents">Events to publish</param>
		/// <param name="cancellationToken">Cancellation Token</param>
		/// <returns></returns>
		Task<OperationStatus> PublishEventsToTopicAsync(IList<EventGridEvent> cloudEvents, CancellationToken cancellationToken = new CancellationToken());
	}
}

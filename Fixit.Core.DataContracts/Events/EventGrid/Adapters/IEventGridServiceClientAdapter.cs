using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Fixit.Core.DataContracts.Events.EventGrid.Adapters
{
	public interface IEventGridServiceClientAdapter<T>
	{
		/// <summary>
		/// Adapter to publish event to a topic asynchronously
		/// </summary>
		/// <param name="cloudEvents">Events to publish</param>
		/// <param name="cancellationToken">Cancellation Token</param>
		/// <returns></returns>
		Task PublishEventsToTopicAsync(IList<T> cloudEvents, CancellationToken cancellationToken = new CancellationToken());
	}
}

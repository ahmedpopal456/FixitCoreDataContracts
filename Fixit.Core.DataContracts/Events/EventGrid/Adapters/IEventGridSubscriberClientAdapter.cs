using Newtonsoft.Json;

namespace Fixit.Core.DataContracts.Events.EventGrid.Adapters
{
	public interface IEventGridSubscriberClientAdapter<T>
	{
		/// <summary>
		/// Deserialize the subscribed topic event content
		/// </summary>
		/// <param name="requestContent">Subscribed topic event content</param>
		/// <returns>Collection of deserialized events</returns>
		T[] DeserializeEventGridEvents(string requestContent);

		/// <summary>
		/// 		/// Deserialize the subscribed topic event content with a custom json serializer
		/// </summary>
		/// <param name="requestContent">Subscribed topic event content</param>
		/// <param name="jsonSerializer">Custom Json Serializer</param>
		/// <returns>Collection of deserialized events</returns>
		T[] DeserializeEventGridEvents(string requestContent, JsonSerializer jsonSerializer);
	}
}

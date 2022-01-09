using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Notifications.Payloads
{
  /// <summary>
  /// Payload for <see cref="NotificationTypes"/> NewMessage
  /// </summary>
  [DataContract]
  public class ConversationMessagePayloadDto : PayloadBaseDto
  {

    [DataMember]
    public UserBaseDto SentByUser { get; set; }

    [DataMember]
    public string Message { get; set; }
  }
}

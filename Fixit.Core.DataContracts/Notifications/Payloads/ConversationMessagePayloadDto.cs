using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Chat.Enums;
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
    public UserSummaryDto SentByUser { get; set; }

    [DataMember]
    public MessageType Type { get; set; }

    [DataMember]
    public string Message { get; set; }
  }
}

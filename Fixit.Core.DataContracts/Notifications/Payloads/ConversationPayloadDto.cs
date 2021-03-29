using System;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Notifications.Payloads
{
  /// <summary>
  /// Payload for <see cref="NotificationTypes"/> NewConversation
  /// </summary>
  [DataContract]
  public class ConversationPayloadDto : PayloadBaseDto
  {
    [DataMember]
    public Guid FixInstanceId { get; set; }

    [DataMember]
    public UserSummaryDto SentByUser { get; set; }
  }
}

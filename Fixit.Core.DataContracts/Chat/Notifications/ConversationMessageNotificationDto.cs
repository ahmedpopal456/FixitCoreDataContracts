using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Chat.Notifications
{
  [DataContract]
  public class ConversationMessageNotificationDto
  {
    [DataMember]
    public string ConversationId { get; set; }
  }
}

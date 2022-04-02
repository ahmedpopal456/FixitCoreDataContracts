using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Chat.Operations.Messages
{
  [DataContract]
  public class OnConversationAction
  {
    [DataMember]
    public ConversationDto Conversation { get; set; }

    [DataMember]
    public Guid ConversationId { get; set; }
  }
}

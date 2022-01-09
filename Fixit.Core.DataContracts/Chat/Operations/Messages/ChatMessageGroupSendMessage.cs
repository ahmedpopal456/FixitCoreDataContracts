using System;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Chat.Operations.Requests;

namespace Fixit.Core.DataContracts.Chat.Operations.Messages
{
  [DataContract]
  public class ChatMessageGroupSendMessage
  {
    [DataMember]
    public Guid SentByUserId { get; set; }

    [DataMember]
    public long SentTimestampUtc { get; set; }

    [DataMember]
    public Guid ConversationId { get; set; }

    [DataMember]
    public ConversationMessageUpsertRequestDto MessageCreateRequest { get; set; }
  }
}

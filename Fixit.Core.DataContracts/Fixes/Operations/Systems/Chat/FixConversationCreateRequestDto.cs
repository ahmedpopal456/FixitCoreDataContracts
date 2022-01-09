using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Chat.Operations.Requests
{
  [DataContract]
  public class FixConversationCreateRequestDto : ConversationCreateRequestDto
  {
    [DataMember]
    public Guid FixInstanceId { get; set; }
  }
}

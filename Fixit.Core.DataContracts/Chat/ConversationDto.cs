using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Chat.Details;
using Fixit.Core.DataContracts.Chat.Messages;

namespace Fixit.Core.DataContracts.Chat
{
  [DataContract]
  public class ConversationDto
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string EntityId { get; set; }

    [DataMember]
    public ContextDetails Details { get; set; }

    [DataMember]
    public IList<ParticipantDto> Participants { get; set; }

    [DataMember]
    public ConversationMessageDto LastMessage { get; set; }

    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimestampUtc { get; set; }

    [DataMember]
    public bool IsDeleted { get; set; }

    [DataMember]
    public long DeletedTimestampUtc { get; set; }
  }
}

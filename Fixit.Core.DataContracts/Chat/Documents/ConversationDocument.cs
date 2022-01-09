using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Auditables;
using Fixit.Core.DataContracts.Chat.Details;
using Fixit.Core.DataContracts.Chat.Messages;

namespace Fixit.Core.DataContracts.Chat.Documents
{
  [DataContract]
  public class ConversationDocument : DocumentBase, ITimeTraceableEntity, ISoftDeletableEntity
  {
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

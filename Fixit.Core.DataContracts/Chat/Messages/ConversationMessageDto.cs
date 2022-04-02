using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Auditables;
using Fixit.Core.DataContracts.Chat.Attachments;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Chat.Messages
{
  [DataContract]
  public class ConversationMessageDto : ITimeTraceableEntity
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string Message { get; set; }

    [DataMember]
    public IEnumerable<MessageAttachmentDto> Attachments { get; set; }

    [DataMember]
    public UserBaseDto CreatedByUser { get; set; }

    [DataMember]
    public UserBaseDto UpdatedByUser { get; set; }

    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimestampUtc { get; set; }
  }
}

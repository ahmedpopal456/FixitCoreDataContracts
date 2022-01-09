using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.QueryBuilders;
using Fixit.Core.DataContracts.QueryBuilders.Auditables;

namespace Fixit.Core.DataContracts.Chat.Operations.Queries
{
  [DataContract]
  public class ConversationQueryDto : IQuerySoftDeletable, IDtoValidator
  {
    [DataMember]
    public IEnumerable<Guid> Ids { get; set; }

    [DataMember]
    public IEnumerable<Guid> EntityIds { get; set; }

    [DataMember]
    public ContextDetailsQueryDto ContextDetailsQuery { get; set; }

    [DataMember]
    public ParticipantQueryDto ParticipantQuery { get; set; }

    [DataMember]
    public bool? IsDeleted { get; set; }

    [DataMember]
    public TimestampsQueryDto DeletedTimestampUtcQuery { get; set; }

    public bool Validate()
    {
      return this != null;
    }
  }
}

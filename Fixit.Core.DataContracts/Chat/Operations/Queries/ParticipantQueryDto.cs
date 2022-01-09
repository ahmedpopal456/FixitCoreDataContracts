using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.QueryBuilders;

namespace Fixit.Core.DataContracts.Chat.Operations.Queries
{
  [DataContract]
  public class ParticipantQueryDto
  {
    [DataMember]
    public UserQueryDto User { get; set; }

    [DataMember]
    public bool? HasUnreadMessages { get; set; }
  }
}

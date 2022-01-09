using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Chat.Operations.Requests
{
  [DataContract]
  public class AddConversationParticipantsRequestDto
  {
    [DataMember]
    public List<UserSummaryDto> Participants { get; set; }

    [DataMember]
    public Guid ConversationId { get; set; }
  }
}

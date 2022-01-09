using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Chat.Details;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Chat.Operations.Requests
{
  [DataContract]
  public class ConversationCreateRequestDto : IDtoValidator
  {
    [DataMember]
    public ContextDetails Details { get; set; }

    [DataMember]
    public IList<UserSummaryDto> Participants { get; set; }

    public bool Validate()
    {
      bool isValid = (Participants == null || Participants.Any()) 
                     && (Details != null && !string.IsNullOrWhiteSpace(Details.Id) && !string.IsNullOrWhiteSpace(Details.Name));

      return isValid;
    }
  }
}

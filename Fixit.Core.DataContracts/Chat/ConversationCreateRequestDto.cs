using System;
using System.Collections.Generic;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Chat
{
  public class ConversationCreateRequestDto
  {
    public Guid FixInstanceId { get; set; }
    
    public ICollection<UserSummaryDto> Participants { get; set; }
  }
}

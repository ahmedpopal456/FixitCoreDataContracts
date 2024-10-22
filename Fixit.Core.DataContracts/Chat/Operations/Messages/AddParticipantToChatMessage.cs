﻿using System;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Chat.Operations.Messages
{
  [DataContract]
  public class AddParticipantToChatMessage : OnConversationAction
  {
    [DataMember]
    public UserSummaryDto User { get; set; }
  }
}

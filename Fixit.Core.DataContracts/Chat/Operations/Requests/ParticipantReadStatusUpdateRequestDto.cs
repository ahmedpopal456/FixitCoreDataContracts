using System;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts;

namespace Fixit.Core.DataContracts.Chat.Operations.Requests
{
  [DataContract]
  public class ParticipantReadStatusUpdateRequestDto : IDtoValidator
  {
    [DataMember]
    public Guid ParticipantId { get; set; }

    [DataMember]
    public bool HasUnreadMessages { get; set; }

    public bool Validate()
    {
      var isValid = this != null;
      return isValid;
    }
  }
}

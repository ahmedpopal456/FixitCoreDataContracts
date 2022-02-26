using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Notifications.Payloads;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Notifications.Operations
{
  [DataContract]
  public class EnqueueNotificationRequestDto : IDtoValidator
  {
    [DataMember]
    public string Title { get; set; }

    [DataMember]
    public string Message { get; set; }

    [DataMember]
    public NotificationPayloadDto Payload { get; set; }

    [DataMember]
    public IList<NotificationTagDto> Tags { get; set; }

    [DataMember]
    public IEnumerable<UserBaseDto> RecipientUsers { get; set; }

    [DataMember]
    public bool Silent { get; set; }

    public bool Validate()
    {
      bool isValid = ((Title != null)
                     && (Payload != null || !string.IsNullOrWhiteSpace(Message))
                     || ((Tags != null && Tags.Any())
                     || (RecipientUsers != null && RecipientUsers.Any() && RecipientUsers.All(user => user != null && user.Id != Guid.Empty))));

      return isValid;
    }
  }
}

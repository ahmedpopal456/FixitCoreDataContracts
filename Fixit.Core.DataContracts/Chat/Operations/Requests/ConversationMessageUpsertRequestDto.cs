using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts;
using Fixit.Core.DataContracts.Chat.Attachments;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Chat.Operations.Requests
{
  [DataContract]
  public class ConversationMessageUpsertRequestDto : IDtoValidator
  {
    [DataMember]
    public string Message { get; set; }

    [DataMember]
    public UserBaseDto SentByUser { get; set; }

    [DataMember]
    public IEnumerable<MessageAttachmentDto> Attachments { get; set; }

    public bool Validate()
    {
      var isValid = ((!string.IsNullOrWhiteSpace(Message)) || (Attachments is { } || (Attachments.Any()) && Attachments.All(attachment => attachment.Validate()))) 
                    && SentByUser != null;

      return isValid;
    }
  }
}

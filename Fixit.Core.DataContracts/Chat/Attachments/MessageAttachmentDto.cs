using System.Runtime.Serialization;
using Fixit.Core.DataContracts;

namespace Fixit.Core.DataContracts.Chat.Attachments
{
  [DataContract]
  public class MessageAttachmentDto : IDtoValidator
  {
    [DataMember]
    public string FileId { get; set; }

    [DataMember]
    public string AttachmentUrl { get; set; }

    [DataMember]
    public string AttachmentThumbnailUrl { get; set; }

    public bool Validate()
    {
      var isValid = !string.IsNullOrWhiteSpace(FileId)
        && !string.IsNullOrWhiteSpace(AttachmentUrl)
        && !string.IsNullOrWhiteSpace(AttachmentThumbnailUrl);

      return isValid;
    }
  }
}

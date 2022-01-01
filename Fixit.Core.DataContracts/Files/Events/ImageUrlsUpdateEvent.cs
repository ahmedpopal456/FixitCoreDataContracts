using System;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Files.Files;

namespace Fixit.Core.DataContracts.Files.Events
{
  [DataContract]
  public class ImageUrlsUpdateEvent
  {
    [DataMember]
    public Guid FileId { get; set; }

    [DataMember]
    public string ThumbnailUrl { get; set; }

    [DataMember]
    public ImageUrlDto ImageUrl { get; set; }
  }
}

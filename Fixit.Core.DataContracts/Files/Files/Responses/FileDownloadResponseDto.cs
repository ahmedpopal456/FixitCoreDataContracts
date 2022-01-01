using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Files.Files.Responses
{
  [DataContract]
  public class FileDownloadResponseDto : OperationStatus
  {
    [DataMember]
    public Guid FileId { get; set; }

    [DataMember]
    public string FilePath { get; set; }

    [DataMember]
    public string DownloadUrl { get; set; }
  }
}
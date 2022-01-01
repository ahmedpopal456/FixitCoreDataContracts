using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Files.Files.Responses
{
  [DataContract]
  public class FileResponseDto : OperationStatus
  {
    [DataMember]
    public FileInfoDto FileInfo { get; set; }

    [DataMember]
    public Guid FileId { get; set; }

    [DataMember]
    public string FileName { get; set; }
  }
}
using System;
using System.IO;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Files.Files.Responses
{
  [DataContract]
  public class FileDataResponseDto : OperationStatus
  {
    [DataMember]
    public Stream FileStream { get; set; }

    [DataMember]
    public Guid FileId { get; set; }
  }
}
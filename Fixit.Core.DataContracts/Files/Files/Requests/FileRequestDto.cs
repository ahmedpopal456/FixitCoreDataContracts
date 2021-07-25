using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Files.Files.Requests
{
  [DataContract]
  public class FileRequestDto
  {
    [DataMember]
    public Guid FileId { get; set; }
  }
}
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Files.Files.Requests
{
  [DataContract]
  public class FileRenameRequestDto
  {
    [DataMember]
    public string RenamedFilePath { get; set; }
  }
}
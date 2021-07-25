using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Files.Directories.Requests
{
  [DataContract]
  public class DirectoryCreateRequestDto
  {
    [DataMember]
    public string DirectoryPathToCreate { get; set; }
  }
}
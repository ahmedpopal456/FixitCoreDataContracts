using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Files.Directories.Requests
{
  [DataContract]
  public class DirectoryDeleteRequestDto
  {
    [DataMember]
    public string DirectoryPathToDelete { get; set; }
  }
}
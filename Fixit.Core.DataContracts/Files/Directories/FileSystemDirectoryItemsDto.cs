using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Files.Files;

namespace Fixit.Core.DataContracts.Files.Directories
{
  [DataContract]
  public class FileSystemDirectoryItemsDto
  {
    [DataMember]
    public string Path { get; set; }

    [DataMember]
    public IList<FileSystemFileDto> DirectoryItems { get; set; } = new List<FileSystemFileDto>();
  }
}

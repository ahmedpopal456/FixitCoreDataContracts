using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Files.Files;

namespace Fixit.Core.DataContracts.Files.Directories
{
  [DataContract]
  public class FileSystemRootDirectoryDto
  {
    [DataMember]
    public FileSystemDirectoryDto DirectoryInfo { get; set; } = new FileSystemDirectoryDto();

    [DataMember]
    public IEnumerable<FileTagDto> DirectoryTags { get; set; }
  }
}

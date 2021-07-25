using System.Runtime.Serialization;
using Microsoft.AspNetCore.Http;

namespace Fixit.Core.DataContracts.Files.Files.Requests
{
  [DataContract]
  public class FileUploadRequestDto
  {
    [DataMember]
    public string FilePathToCreate { get; set; }

    [DataMember]
    public IFormFile FormFile { get; set; }

    [DataMember] 
    public FileMetadataSummary FileMetadataSummary { get; set; }
  }
}

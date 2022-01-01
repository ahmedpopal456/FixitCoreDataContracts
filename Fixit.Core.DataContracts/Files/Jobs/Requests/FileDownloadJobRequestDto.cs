using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Files.Jobs.Requests
{
  [DataContract]
  public class FileDownloadJobRequestDto
  {
    [DataMember]
    public IEnumerable<string> FilePathsRequested { get; set; }
  }
}
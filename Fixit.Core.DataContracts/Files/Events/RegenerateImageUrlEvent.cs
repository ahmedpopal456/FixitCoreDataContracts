using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Files.Files;

namespace Fixit.Core.DataContracts.Files.Events
{
  public class RegenerateImageUrlEvent
  {
    [DataMember]
    public IEnumerable<FileToRegenerateUrlDto> FilesToRegenerateUrls { get; set; }
  }
}

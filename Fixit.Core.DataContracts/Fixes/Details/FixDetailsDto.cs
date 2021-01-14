using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Fixes.Details.Sections;

namespace Fixit.Core.DataContracts.Fixes.Details
{
  [DataContract]
  public class FixDetailsDto
  {
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string Description { get; set; }

    [DataMember]
    public string Category { get; set; }

    [DataMember]
    public string Type { get; set; }

    [DataMember]
    public IEnumerable<FixSectionDto> Sections { get; set; }
  }
}

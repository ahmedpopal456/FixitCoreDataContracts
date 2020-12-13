using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Details.Craftsman
{
  [DataContract]
  public class CraftsmanDetailsDto : UserDetailsDto
  {
    [DataMember]
    public IEnumerable<SkillDto> Skills { get; set; }
  }
}

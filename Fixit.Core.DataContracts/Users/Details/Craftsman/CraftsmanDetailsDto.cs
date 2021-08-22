using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Skill;

namespace Fixit.Core.DataContracts.Users.Details.Craftsman
{
  [DataContract]
  public class CraftsmanDetailsDto
  {
    [DataMember]
    public IEnumerable<SkillDto> Skills { get; set; }
  }
}

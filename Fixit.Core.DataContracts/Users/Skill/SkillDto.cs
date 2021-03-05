using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Skills
{
  public class SkillDto
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public string Name { get; set; }
  }
}

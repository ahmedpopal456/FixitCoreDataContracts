using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Skills
{
  public class SkillsDto
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public long AttributedAtTimestampUtc { get; set; }

    [DataMember]
    public long ExpiresAtTimestampUtc { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;

namespace Fixit.Core.DataContracts.Users.Operations
{
  public class UpdateUserSkillRequestDto : OperationStatus, IFakeSeederAdapter<UpdateUserSkillRequestDto>
  {
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public long AttributedAtTimeStampUtc { get; set; }

    [DataMember]
    public long ExpiredAtTimeStampUtc { get; set; }

    public IList<UpdateUserSkillRequestDto> SeedFakeDtos()
    {
      UpdateUserSkillRequestDto firstSkill = new UpdateUserSkillRequestDto
      {
        Name = "Skill 1",
        AttributedAtTimeStampUtc = DateTimeOffset.Now.ToUnixTimeSeconds(),
        ExpiredAtTimeStampUtc = DateTimeOffset.Now.ToUnixTimeSeconds()
      };

      UpdateUserSkillRequestDto secondSkill = null;

      return new List<UpdateUserSkillRequestDto>
      {
        firstSkill,
        secondSkill
      };
    }
  }
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;

namespace Fixit.Core.DataContracts.Users.Operations
{
  public class UpdateUserSkillRequestDto : OperationStatus, IFakeSeederAdapter<UpdateUserSkillRequestDto>
  {
    [DataMember]
    public Guid UserId { get; set; }

    [DataMember]
    public string SkillName { get; set; }

    [DataMember]
    public long AttributedAtTimestampUtc { get; set; }

    [DataMember]
    public long ExpiresTimestampUtc { get; set; }

    public IList<UpdateUserSkillRequestDto> SeedFakeDtos()
    {
      UpdateUserSkillRequestDto firstSkill = new UpdateUserSkillRequestDto
      {
        SkillName = "Skill 1",
        AttributedAtTimestampUtc = DateTimeOffset.Now.ToUnixTimeSeconds(),
        ExpiresTimestampUtc = DateTimeOffset.Now.ToUnixTimeSeconds()
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

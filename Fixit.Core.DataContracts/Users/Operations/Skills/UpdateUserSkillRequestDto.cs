using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;
using Fixit.Core.DataContracts.Users.License;

namespace Fixit.Core.DataContracts.Users.Operations.Skills
{
  public class UpdateUserSkillRequestDto : OperationStatus, IFakeSeederAdapter<UpdateUserSkillRequestDto>
  {
    [DataMember]
    public Guid UserId { get; set; }

    [DataMember]
    public IEnumerable<UserLicenseDto> Skills { get; set; }

    [DataMember]
    public long AttributedAtTimestampUtc { get; set; }

    [DataMember]
    public long ExpiresAtTimestampUtc { get; set; }

    public IList<UpdateUserSkillRequestDto> SeedFakeDtos()
    {
      UpdateUserSkillRequestDto firstSkill = new UpdateUserSkillRequestDto
      {
        Skills = new List<UserLicenseDto> { new UserLicenseDto { Id = Guid.NewGuid(), Name = "Hello" } },
        AttributedAtTimestampUtc = DateTimeOffset.Now.ToUnixTimeSeconds(),
        ExpiresAtTimestampUtc = DateTimeOffset.Now.ToUnixTimeSeconds()
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

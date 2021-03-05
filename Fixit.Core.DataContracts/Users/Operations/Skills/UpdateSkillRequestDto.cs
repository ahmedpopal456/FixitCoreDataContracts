using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;

namespace Fixit.Core.DataContracts.Users.Operations
{
  public class UpdateSkillRequestDto : OperationStatus, IFakeSeederAdapter<UpdateSkillRequestDto>
  {
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public long AttributedAtTimeStampUtc { get; set; }

    [DataMember]
    public long ExpiredAtTimeStampUtc { get; set; }

    public IList<UpdateSkillRequestDto> SeedFakeDtos()
    {
      UpdateSkillRequestDto firstSkill = new UpdateSkillRequestDto
      {
        Name = "Skill 1",
      };

      UpdateSkillRequestDto secondSkill = null;

      return new List<UpdateSkillRequestDto>
      {
        firstSkill,
        secondSkill
      };
    }
  }
}

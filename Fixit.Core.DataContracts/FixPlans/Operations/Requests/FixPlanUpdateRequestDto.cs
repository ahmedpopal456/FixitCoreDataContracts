using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.Phases;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  [DataContract]
  public class FixPlanUpdateRequestDto: IFakeSeederAdapter<FixPlanUpdateRequestDto>
  {
      [DataMember]
      public bool IsBookmarked { get; set; }
      
      [DataMember]
      public IEnumerable<FixPhaseDto> Phases { get; set; }

      [DataMember]
      public long UpdatedTimestampUtc { get; set; }

    public IList<FixPlanUpdateRequestDto> SeedFakeDtos()
    {
      FixPlanUpdateRequestDto firstFixPlan = new FixPlanUpdateRequestDto
      {
        Phases = new List<FixPhaseDto>()
        {
          new FixPhaseDto
          {
            Name = "Start",
            Id = Guid.Parse("3e888ecb-0454-448a-90cd-6d16cc4d44eb"),
            Tasks = new List<FixPhaseTaskDto>()
            {
              new FixPhaseTaskDto()
              {
                Description="Testing",
                Id = Guid.Parse("1e811863-dea8-44c1-a95d-4b0b34a9970e"),
                Name = "Test",
                Order =0
              }
            }
          }
        }
      };

      FixPlanUpdateRequestDto secondFixPlan = null;

      return new List<FixPlanUpdateRequestDto> { firstFixPlan, secondFixPlan };
    }
  }
}

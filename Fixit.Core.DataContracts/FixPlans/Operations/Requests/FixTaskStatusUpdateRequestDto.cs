using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.Phases.Tasks.Enums;
using Fixit.Core.DataContracts.Seeders;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests
{
  [DataContract]
  public class FixTaskStatusUpdateRequestDto : IFakeSeederAdapter<FixTaskStatusUpdateRequestDto>
  {
    [DataMember]
    public TaskStatuses Status { get; set; }

    public IList<FixTaskStatusUpdateRequestDto> SeedFakeDtos()
    {
      FixTaskStatusUpdateRequestDto firstFixPhaseTaskRequestDto = new FixTaskStatusUpdateRequestDto
      {
        Status = TaskStatuses.New
      };

      FixTaskStatusUpdateRequestDto secondFixPhaseTaskRequestDto = null;

      return new List<FixTaskStatusUpdateRequestDto> { firstFixPhaseTaskRequestDto, secondFixPhaseTaskRequestDto };
    }
  }
}

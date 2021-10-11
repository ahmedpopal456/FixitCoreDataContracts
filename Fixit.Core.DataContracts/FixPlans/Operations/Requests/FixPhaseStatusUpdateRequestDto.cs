using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.Phases.Enums;
using Fixit.Core.DataContracts.Seeders;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests
{
  [DataContract]
  public class FixPhaseStatusUpdateRequestDto : IFakeSeederAdapter<FixPhaseStatusUpdateRequestDto>
  {
    [DataMember]
    public PhaseStatuses Status { get; set; }

    public IList<FixPhaseStatusUpdateRequestDto> SeedFakeDtos()
    {
      FixPhaseStatusUpdateRequestDto firstFixPhaseRequestDto = new FixPhaseStatusUpdateRequestDto
      {
        Status = PhaseStatuses.InProgress,
      };

      FixPhaseStatusUpdateRequestDto secondFixPhaseRequestDto = null;

      return new List<FixPhaseStatusUpdateRequestDto> { firstFixPhaseRequestDto, secondFixPhaseRequestDto };
    }
  }
}

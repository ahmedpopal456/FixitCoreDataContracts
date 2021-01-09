using System;
using System.Collections.Generic;
using System.Text;
using Fixit.Core.DataContracts.FixPlans.Phases.Enums;
using Fixit.Core.DataContracts.FixPlans.Phases.Tasks;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  public class FixPhaseRequestDto
  {
    public PhaseStatuses Status { get; set; }
  }
}

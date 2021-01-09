using System;
using System.Collections.Generic;
using System.Text;
using Fixit.Core.DataContracts.FixPlans.Phases.Tasks.Enums;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  public class FixPhaseTaskRequestDto
  {
    public TaskStatuses Status { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.Text;
using Fixit.Core.DataContracts.FixPlans.Phases.Tasks.Enums;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  public class FixPhaseTaskRequestDto
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Order { get; set; }
    public TaskStatuses Status { get; set; }
  }
}

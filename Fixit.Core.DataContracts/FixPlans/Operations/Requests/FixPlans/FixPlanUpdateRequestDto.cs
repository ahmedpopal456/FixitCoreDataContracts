using System;
using System.Collections.Generic;
using System.Text;
using Fixit.Core.DataContracts.FixPlans.Phases;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  public class FixPlanUpdateRequestDto
  {
      public bool IsBookmarked { get; set; }

      public IEnumerable<FixPhaseDto> Phases { get; set; }
  }
}

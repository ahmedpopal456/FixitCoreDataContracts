using System;
using System.Collections.Generic;
using Fixit.Core.DataContracts.FixPlans.BillingDetails;
using Fixit.Core.DataContracts.FixPlans.Phases;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  //change to create requestDto
  public class FixPlanCreateRequestDto
  {
    public Guid FixId { get; set; }

    public bool IsBookmarked { get; set; }

    
    public float TotalCost { get; set; }

    public FixPlanBillingDetailsDto BillingDetails { get; set; }

    public IEnumerable<FixPhaseDto> Phases { get; set; }

    public UserSummaryDto CreatedByCraftsman { get; set; }
  }
}

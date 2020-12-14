using System;
using System.Collections.Generic;
using System.Text;
using Fixit.Core.DataContracts.FixPlans.BillingDetails;
using Fixit.Core.DataContracts.FixPlans.Enums;
using Fixit.Core.DataContracts.FixPlans.Phases;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  public class FixPlanRequestDto : IRequestDto
  {
    public Guid FixId { get; set; }

    public bool IsBookmarked { get; set; }

    public FixPlanProposalStates ProposalState { get; set; }

    public float TotalCost { get; set; }

    public Guid ActivePhaseId { get; set; }

    public FixPlanBillingDetailsDto BillingDetails { get; set; }

    public IEnumerable<FixPhaseDto> Phases { get; set; }

    public UserSummaryDto CreatedByCraftsman { get; set; }
  }
}

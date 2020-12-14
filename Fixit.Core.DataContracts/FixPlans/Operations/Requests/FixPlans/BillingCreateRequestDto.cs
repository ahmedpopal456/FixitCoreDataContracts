using System;
using System.Collections.Generic;
using System.Text;
using Fixit.Core.DataContracts.FixPlans.BillingDetails.Enums;
using Fixit.Core.DataContracts.FixPlans.Phases.Cost;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  public class BillingCreateRequestDto : ICreateRequestDto
  {
    public float InitialCost { get; set; }
  }
}

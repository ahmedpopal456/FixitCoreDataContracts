using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.BillingDetails.Enums;
using Fixit.Core.DataContracts.FixPlans.Phases.Cost;

namespace Fixit.Core.DataContracts.FixPlans.BillingDetails
{
  [DataContract]
  public class FixPlanBillingDetailsDto
  {
    [DataMember]
    public float InitialCost { get; set; }

    [DataMember]
    public IEnumerable<FixPhaseEstimateCostDto> PhaseCosts { get; set; }

    [DataMember]
    public FixPlanBillingTypes BillingType { get; set; }

    [DataMember]
    public float EndCost { get; set; }
  }
}

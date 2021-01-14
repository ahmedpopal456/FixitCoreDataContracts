using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.Phases;

namespace Fixit.Core.DataContracts.FixPlans
{
  [DataContract]
  public class FixPlanSummaryDto
  {
    [DataMember]
    public IEnumerable<FixPhaseSummaryDto> Phases { get; set; }
    
    [DataMember]
    public float CompletionPercentage { get; set; }

    [DataMember]
    public int TotalPhaseCount { get; set; }
  }
}

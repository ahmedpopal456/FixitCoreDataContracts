using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.FixPlans.Phases.Tasks
{
  [DataContract]
  public class FixPhaseTaskSummaryDto
  {
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string Description { get; set; }
  }
}

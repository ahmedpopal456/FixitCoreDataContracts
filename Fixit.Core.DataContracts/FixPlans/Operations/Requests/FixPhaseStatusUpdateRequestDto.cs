using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.Phases.Enums;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  [DataContract]
  public class FixPhaseStatusUpdateRequestDto
  {
    [DataMember]
    public PhaseStatuses Status { get; set; }
  }
}

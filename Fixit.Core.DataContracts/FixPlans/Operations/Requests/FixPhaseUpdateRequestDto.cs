using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.Phases.Enums;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  [DataContract]
  public class FixPhaseUpdateRequestDto
  {
    [DataMember]
    public PhaseStatuses Status { get; set; }
  }
}

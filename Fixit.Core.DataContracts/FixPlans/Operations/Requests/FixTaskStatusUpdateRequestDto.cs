using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.Phases.Tasks.Enums;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  [DataContract]
  public class FixTaskStatusUpdateRequestDto
  {
    [DataMember]
    public TaskStatuses Status { get; set; }
  }
}

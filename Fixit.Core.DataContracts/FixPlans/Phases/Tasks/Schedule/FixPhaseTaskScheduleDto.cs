using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.FixPlans.Phases.Tasks.Schedule
{
  [DataContract]
  public class FixPhaseTaskScheduleDto
  {
    [DataMember]
    public FixPhaseTaskSummaryDto ScheduledTask { get; set; }

    [DataMember]
    public IEnumerable<long> AppointedTimestampsUtc { get; set; }
  }
}

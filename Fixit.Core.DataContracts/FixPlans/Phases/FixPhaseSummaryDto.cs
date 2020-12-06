using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.Phases.Tasks.Schedule;

namespace Fixit.Core.DataContracts.FixPlans.Phases
{
  [DataContract]
  public class FixPhaseSummaryDto
  {
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public IEnumerable<FixPhaseTaskScheduleDto> TaskSchedule { get; set; }
  }
}

using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Fixit.Core.DataContracts.Fixes.Schedule
{
  [DataContract]
  public class FixScheduleDto
  {
    [DataMember]
    public IEnumerable<FixScheduleRangeDto> ScheduleRanges { get; set; }

    [DataMember]
    public IEnumerable<long> Workdays { get; set; }
  }
}

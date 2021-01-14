using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Fixes.Schedule
{
  [DataContract]
  public class FixScheduleRangeDto
  {
    [DataMember]
    public long StartTimestampUtc { get; set; }

    [DataMember]
    public long EndTimestampUtc { get; set; }
  }
}

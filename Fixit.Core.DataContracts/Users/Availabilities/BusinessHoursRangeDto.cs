using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Availabilities
{
  [DataContract]
  public class BusinessHoursRangeDto
  {
    [DataMember]
    public long StartTimestampUtc { get; set; }

    [DataMember]
    public long EndTimestampUtc { get; set; }
  }
}

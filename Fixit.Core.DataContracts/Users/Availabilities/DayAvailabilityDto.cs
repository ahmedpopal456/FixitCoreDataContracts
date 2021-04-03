using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Availabilities
{
  [DataContract]
  public class DayAvailabilityDto
  {
    [DataMember]
    public DayOfWeek DayName { get; set; }

    [DataMember]
    public IEnumerable<BusinessHoursRangeDto> BusinessHours { get; set; }
  }
}

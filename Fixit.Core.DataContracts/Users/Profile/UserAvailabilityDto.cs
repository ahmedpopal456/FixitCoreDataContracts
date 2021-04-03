using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Availabilities;
using Fixit.Core.DataContracts.Users.Enums;

namespace Fixit.Core.DataContracts.Users.Profile
{
  [DataContract]
  public class UserAvailabilityDto
  {
    [DataMember]
    public AvailabilityType Type { get; set; }

    [DataMember]
    public IList<DayAvailabilityDto> Schedule { get; set; }
  }
}

using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Enums;
using Fixit.Core.DataContracts.Users.Profile;

namespace Fixit.Core.DataContracts.Users
{
  [DataContract]
  public class UserDto : UserSummaryDto
  {

    [DataMember]
    public UserState State { get; set; }


    [DataMember]
    public Gender Gender { get; set; }

    [DataMember]
    public bool IsDeleted { get; set; }

    [DataMember]
    public string TelephoneNumber { get; set; }

    [DataMember]
    public UserAvailabilityDto Availability { get; set; }

    [DataMember]
    public long CreatedTimestampsUtc { get; set; }

    [DataMember]
    public long UpdatedTimestampsUtc { get; set; }

  }
}

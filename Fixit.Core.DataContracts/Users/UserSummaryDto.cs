using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Address;
using Fixit.Core.DataContracts.Users.Enums;
using Fixit.Core.DataContracts.Users.License;

namespace Fixit.Core.DataContracts.Users
{
  [DataContract]
  public class UserSummaryDto : UserBaseDto
  {
    [DataMember]
    public string ProfilePictureUrl { get; set; }

    [DataMember]
    public UserRole Role { get; set; }

    [DataMember]
    public UserStatusDto Status { get; set; }

    [DataMember]
    public List<UserLicenseDto> Licenses { get; set; }

    [DataMember]
    public List<UserAddressDto> SavedAddresses { get; set; }
  }
}

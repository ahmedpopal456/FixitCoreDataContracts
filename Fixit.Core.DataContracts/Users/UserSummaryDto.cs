using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Enums;
using Fixit.Core.DataContracts.Users.Skill;

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
    public IEnumerable<UserLicenseDto> Licenses { get; set; }
  }
}

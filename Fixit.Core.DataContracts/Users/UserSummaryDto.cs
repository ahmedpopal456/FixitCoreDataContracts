using System;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Enums;

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
  }
}

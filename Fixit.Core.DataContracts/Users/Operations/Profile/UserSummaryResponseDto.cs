using System;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Enums;

namespace Fixit.Core.DataContracts.Users.Operations.Profile
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class UserSummaryResponseDto : OperationStatus
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public string UserPrincipalName { get; set; }

    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public string ProfilePictureUrl { get; set; }

    [DataMember]
    public UserRole Role { get; set; }

    [DataMember]
    public UserStatusDto Status { get; set; }
  }
}

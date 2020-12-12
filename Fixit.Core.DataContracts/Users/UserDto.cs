using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Address;
using Fixit.Core.DataContracts.Users.Details;
using Fixit.Core.DataContracts.Users.Documents;
using Fixit.Core.DataContracts.Users.Enums;
using Fixit.Core.DataContracts.Users.Information;

namespace Fixit.Core.DataContracts.Users
{
  [DataContract]
  public class UserDto
  {
    [DataMember]
    public Guid id { get; set; }

    [DataMember]
    public string UserPrincipalName { get; set; }

    [DataMember]
    public string ProfilePictureUrl { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public UserState State { get; set; }

    [DataMember]
    public Guid RatingId { get; set; }

    [DataMember]
    public AddressDto Address { get; set; }

    [DataMember]
    public UserRole Role { get; set; }

    [DataMember]
    public IUserRoleDetailsDto SpecificDetails { get; set; }

    [DataMember]
    public Gender Gender { get; set; }

    [DataMember]
    public bool IsDeleted { get; set; }

    [DataMember]
    public UserStatusDto Status { get; set; }

    [DataMember]
    public string TelephoneNumber { get; set; }

    [DataMember]
    public IEnumerable<BankingInformationDto> BankingInformation { get; set; }

    [DataMember]
    public IEnumerable<PaymentInformationDto> Payments { get; set; }

    [DataMember]
    public long CreatedTimestampsUtc { get; set; }

    [DataMember]
    public long UpdatedTimestampsUtc { get; set; }

    [DataMember]
    public IEnumerable<DocumentDenormalizedDto> Documents { get; set; }
  }
}

﻿using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Address;

namespace Fixit.Core.DataContracts.Users.Profile
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class UserProfileInformationDto : OperationStatus
  {
    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public UserAddressDto Address { get; set; }

    [DataMember]
    public UserAvailabilityDto Availability { get; set; }
  }
}

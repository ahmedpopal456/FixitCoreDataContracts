﻿using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Address;

namespace Fixit.Core.DataContracts.Users.Profile
{
  [DataContract]
  public class UserProfileInformationDto
  {
    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public AddressDto Address { get; set; }
  }
}

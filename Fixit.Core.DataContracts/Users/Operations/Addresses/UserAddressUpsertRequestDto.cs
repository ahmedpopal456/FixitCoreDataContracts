using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Address
{
  [DataContract]
  public class UserAddressUpsertRequestDto
  {
    [DataMember]
    public AddressDto Address { get; set; }

    [DataMember]
    public string Label { get; set; }

    [DataMember]
    public string AptSuiteFloor {get; set;}
  }
}

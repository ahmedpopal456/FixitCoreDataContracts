using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Address
{
  [DataContract]
  public class UserAddressDto
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public AddressDto Address { get; set; }

    [DataMember]
    public string Label { get; set; }

    [DataMember]
    public string AptSuiteFloor {get; set;}

    [DataMember]
    public bool IsCurrentAddress { get; set; }

    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimestampUtc { get; set; }
  }
}

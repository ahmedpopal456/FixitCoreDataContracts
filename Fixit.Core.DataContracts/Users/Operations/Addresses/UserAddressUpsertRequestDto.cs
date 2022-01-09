using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Address;

namespace Fixit.Core.DataContracts.Users.Operations.Addresses
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

    [DataMember]
    public bool IsCurrentAddress { get; set; }
  }
}

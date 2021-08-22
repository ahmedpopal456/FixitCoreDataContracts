using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Address.Obsolete
{
  [DataContract]
  [Obsolete]
  public class AddressDto
  {
    [DataMember]
    public string Address { get; set; }

    [DataMember]
    public string City { get; set; }

    [DataMember]
    public string Province { get; set; }

    [DataMember]
    public string PostalCode { get; set; }

    [DataMember]
    public string Country { get; set; }

    [DataMember]
    public string PhoneNumber { get; set; }
  }
}

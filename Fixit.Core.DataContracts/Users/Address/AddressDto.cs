using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Address
{
  [DataContract]
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
    public string TelephoneNumber { get; set; }

    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimestampUtc { get; set; }
  }
}

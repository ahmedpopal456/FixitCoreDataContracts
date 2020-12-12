using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Information
{
  [DataContract]
  public class PaymentInformationDto
  {
    [DataMember]
    public int CardNumberHashed { get; set; }

    [DataMember]
    public string CvvHashed { get; set; }

    [DataMember]
    public string CardholderName { get; set; }

    [DataMember]
    public int ExpirationMonth { get; set; }

    [DataMember]
    public int ExpirationYear { get; set; }

    [DataMember]
    public string PostalCode { get; set; }

    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimestampUtc { get; set; }
  }
}

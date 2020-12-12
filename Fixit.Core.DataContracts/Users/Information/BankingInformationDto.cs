using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Information
{
  [DataContract]
  public class BankingInformationDto
  {
    [DataMember]
    public string BankName { get; set; }

    [DataMember]
    public string TransitNumberHashed { get; set; }

    [DataMember]
    public string BankAccountNumberHashed { get; set; }

    [DataMember]
    public string AccountHolderName { get; set; }

    [DataMember]
    public string Address { get; set; }

    [DataMember]
    public string City { get; set; }

    [DataMember]
    public string PostalCode { get; set; }

    [DataMember]
    public long DateOfBirth { get; set; }

    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimestampUtc { get; set; }
  }
}

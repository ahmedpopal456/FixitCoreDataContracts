using System;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Documents.Enums;

namespace Fixit.Core.DataContracts.Users.Documents
{
  [DataContract]
  public class DocumentDto
  {
    [DataMember]
    public Guid id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public DocumentType Type { get; set; }

    [DataMember]
    public ProcessingStatusWithErrorMessageDto ProcessingStatus { get; set; }

    [DataMember]
    public string LicenseDateObtained { get; set; }

    [DataMember]
    public string ImageUrl { get; set; }

    [DataMember]
    public string ExpirationDateOfTheLicense { get; set; }

    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimestampUtc { get; set; }
  }
}

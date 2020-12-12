using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Documents
{
  [DataContract]
  public class DocumentDenormalizedDto
  {
    [DataMember]
    public Guid DocumentId { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public ProcessingStatusWithErrorMessageDto ProcessingStatus { get; set; }
  }
}

using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Documents.Enums;

namespace Fixit.Core.DataContracts.Users.Documents
{
  [DataContract]
  public class ProcessingStatusWithErrorMessageDto
  {
    [DataMember]
    public ProcessingStatus ProcessingStatus { get; set; }

    [DataMember]
    public string ErrorMessage { get; set; }
  }
}

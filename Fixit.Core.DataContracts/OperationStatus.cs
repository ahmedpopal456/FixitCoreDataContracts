using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts
{
  // TODO: add Fixit error code definitions
  [DataContract]
  public class OperationStatus
  {
    [DataMember]
    public bool IsOperationSuccessful { get; set; }

    [DataMember]
    public string OperationMessage { get; set; }

#nullable enable
    [DataMember]
    public Exception? OperationException { get; set; }
#nullable disable
  }
}

using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts
{
  [DataContract]
  public class OperationStatusWithObject<T> : OperationStatus
  {
    [DataMember]
    public T Result { get; set; }
  }
}

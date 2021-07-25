namespace Fixit.Core.DataContracts
{
  public class OperationStatusWithObject<T> : OperationStatus
  {
    public T Result { get; set; }
  }
}

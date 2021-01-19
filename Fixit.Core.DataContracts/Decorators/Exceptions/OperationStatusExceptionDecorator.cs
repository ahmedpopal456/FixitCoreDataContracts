using System;
using System.Threading.Tasks;

namespace Fixit.Core.DataContracts.Decorators.Exceptions
{
  public class OperationStatusExceptionDecorator : IExceptionDecorator<OperationStatus>
  {
    public async Task<OperationStatus> ExecuteOperationAsync(OperationStatus result, Func<Task> executingFunction)
    {
      try
      {
        await executingFunction.Invoke();
      }
      catch (Exception exception)
      {
        result.OperationException = exception;
        result.IsOperationSuccessful = false;
      }
      return result;
    }
  }
}

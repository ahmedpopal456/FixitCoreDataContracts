using Fixit.Core.DataContracts;
using System;
using System.Threading.Tasks;

namespace Fixit.Core.DataContracts.Decorators.Exceptions.Internals
{
  public class ExceptionDecorator : IExceptionDecorator
  {
    public async Task<OperationStatusWithObject<TResult>> ExecuteOperationWithReturnAsync<TResult>(bool handleException, Func<Task<TResult>> executingFunction) where TResult : class
    {
      var result = new OperationStatusWithObject<TResult> { IsOperationSuccessful = true };

      try
      {
        result.Result = await executingFunction.Invoke();
      }
      catch (Exception exception)
      {
        if (!handleException)
        {
          throw;
        }

        result.IsOperationSuccessful = false;
        result.OperationException = exception;
      }
      return result;
    }

    public async Task<OperationStatus> ExecuteOperationAsync(bool handleException, Func<Task> executingFunction)
    {
      var result = new OperationStatus { IsOperationSuccessful = true };

      try
      {
        await executingFunction.Invoke();
      }
      catch (Exception exception)
      {
        if (!handleException)
        {
          throw;
        }

        result.IsOperationSuccessful = false;
        result.OperationException = exception;
      }
      return result;
    }


    public async Task<T> ExecuteOperationAsync<T>(bool handleException, Func<Task> executingFunction, T returnObject = null) where T: OperationStatus, new()
    {
      returnObject ??= new T() { IsOperationSuccessful = true };

      try
      {
        await executingFunction.Invoke();
      }
      catch (Exception exception)
      {
        if (!handleException)
        {
          throw;
        }

        returnObject.IsOperationSuccessful = false;
        returnObject.OperationException = exception;
      }
      return returnObject;
    }
  }
}

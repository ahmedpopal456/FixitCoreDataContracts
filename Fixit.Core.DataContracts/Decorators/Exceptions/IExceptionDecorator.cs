using Fixit.Core.DataContracts;
using System;
using System.Threading.Tasks;

namespace Fixit.Core.DataContracts.Decorators.Exceptions
{
  public interface IExceptionDecorator
  {
    /// <summary>
    /// Wraps a try/catch clause around the given executing function
    /// </summary>
    /// <param name="handleException"></param>
    /// <param name="executingFunction">The function to invoke</param>
    /// <returns></returns>
    Task<OperationStatusWithObject<TResult>> ExecuteOperationWithReturnAsync<TResult>(bool handleException, Func<Task<TResult>> executingFunction) where TResult : class;

    /// <summary>
    /// Wraps a try/catch clause around the given executing function
    /// </summary>
    /// <param name="handleException"></param>
    /// <param name="executingFunction">The function to invoke</param>
    /// <returns></returns>
    Task<OperationStatus> ExecuteOperationAsync(bool handleException, Func<Task> executingFunction);

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="handleException"></param>
    /// <param name="executingFunction"></param>
    /// <returns></returns>
    Task<T> ExecuteOperationAsync<T>(bool handleException, Func<Task> executingFunction, T returnObject = null) where T : OperationStatus, new();
  }
}

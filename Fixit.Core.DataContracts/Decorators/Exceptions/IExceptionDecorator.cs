using System;
using System.Threading.Tasks;

namespace Fixit.Core.DataContracts.Decorators.Exceptions
{
  public interface IExceptionDecorator<T>
  {
    /// <summary>
    /// Wraps a try/catch clause around the given executing function.
    /// </summary>
    /// <param name="result"></param>
    /// <param name="executingFunction"></param>
    /// <returns>The update result.</returns>
    public Task<T> ExecuteOperationAsync(T result, Func<Task> executingFunction);
  }
}

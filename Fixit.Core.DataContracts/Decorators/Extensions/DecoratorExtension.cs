using Fixit.Core.DataContracts.Decorators.Exceptions;
using Fixit.Core.DataContracts.Decorators.Exceptions.Internals;
using Microsoft.Extensions.DependencyInjection;

namespace Fixit.Core.DataContracts.Decorators.Extensions
{
  public static class DecoratorExtension
  {
    public static void AddFixitCoreDecoratorServices(this IServiceCollection services)
    {
      services.AddTransient<IExceptionDecorator, ExceptionDecorator>();
    }
  }
}

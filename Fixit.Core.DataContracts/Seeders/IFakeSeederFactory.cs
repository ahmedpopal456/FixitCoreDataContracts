using System.Collections.Generic;

namespace Fixit.Core.DataContracts.Seeders
{
  public interface IFakeSeederFactory
  {
    public IList<T> CreateSeederFactory<T>(IFakeSeederAdapter<T> fakeSeederAdapter) where T : class;

  }
}

using System.Collections.Generic;

namespace Empower.Core.DataContracts.Adapters
{
  public interface IFakeSeederAdapter<T> where T : class
  {
    IList<T> SeedFakeDtos();
  }
}
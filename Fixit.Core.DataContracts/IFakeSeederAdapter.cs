using System.Collections.Generic;

namespace Fixit.Core.DataContracts
{
  public interface IFakeSeederAdapter<T> where T : class
  {
    IList<T> SeedFakeDtos();
  }
}

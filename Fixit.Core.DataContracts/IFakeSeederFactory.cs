namespace Fixit.Core.DataContracts
{
  public interface IFakeSeederFactory
  {
    IFakeSeederAdapter<T> CreateFakeSeeder<T>() where T : class;
  }
}

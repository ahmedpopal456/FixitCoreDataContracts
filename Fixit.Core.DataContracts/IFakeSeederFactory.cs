namespace Empower.Core.DataContracts.Adapters
{
  public interface IFakeSeederFactory
  {
    IFakeSeederAdapter<T> CreateFakeSeeder<T>() where T : class;
  }
}

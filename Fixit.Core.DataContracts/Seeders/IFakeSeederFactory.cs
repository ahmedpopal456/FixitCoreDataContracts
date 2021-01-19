namespace Fixit.Core.DataContracts.Seeders
{
  public interface IFakeSeederFactory
  {
    IFakeSeederAdapter<T> CreateFakeSeeder<T>() where T : class;
  }
}

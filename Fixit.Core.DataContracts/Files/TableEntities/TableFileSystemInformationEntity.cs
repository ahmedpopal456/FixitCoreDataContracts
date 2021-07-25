using Microsoft.Azure.Cosmos.Table;

namespace Fixit.Core.DataContracts.Files.TableEntities
{
  public class TableFileSystemInformationEntity : TableEntity
  {
    public long FileCount { get; set; }
  }
}

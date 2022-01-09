using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.QueryBuilders.Auditables
{
  public interface IQueryUserTraceable
  {
    [DataMember]
    public UserQueryDto CreatedByUser { get; set; }

    [DataMember]
    public UserQueryDto UpdatedByUser { get; set; }
  }
}

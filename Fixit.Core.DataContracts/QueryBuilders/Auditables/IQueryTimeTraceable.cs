using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.QueryBuilders.Auditables
{
  public interface IQueryTimeTraceable
  {
    [DataMember]
    public TimestampsQueryDto CreatedTimestampUtcQuery { get; set; }

    [DataMember]
    public TimestampsQueryDto UpdatedTimestampUtcQuery { get; set; }
  }
}

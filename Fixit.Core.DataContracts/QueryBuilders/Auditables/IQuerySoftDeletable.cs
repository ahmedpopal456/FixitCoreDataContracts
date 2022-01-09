using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.QueryBuilders.Auditables
{
  public interface IQuerySoftDeletable
  {
    [DataMember]
    public bool? IsDeleted { get; set; }

    [DataMember]
    public TimestampsQueryDto DeletedTimestampUtcQuery { get; set; }
  }
}

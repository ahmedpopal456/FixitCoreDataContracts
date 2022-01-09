using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Auditables
{
  public interface ISoftDeletableEntity
  {
    [DataMember]
    public bool IsDeleted { get; set; }

    [DataMember]
    public long DeletedTimestampUtc { get; set; }
  }
}

using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Auditables
{
  public interface ITimeTraceableEntity
  {
    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimestampUtc { get; set; }
  }
}

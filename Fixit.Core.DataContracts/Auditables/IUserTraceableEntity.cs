using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Auditables
{
  public interface IUserTraceableEntity
  {
    [DataMember]
    public UserBaseDto CreatedByUser { get; set; }

    [DataMember]
    public UserBaseDto UpdatedByUser { get; set; }
  }
}

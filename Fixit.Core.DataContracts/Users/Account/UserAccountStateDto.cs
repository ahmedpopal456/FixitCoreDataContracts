using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Enums;

namespace Fixit.Core.DataContracts.Users.Account
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class UserAccountStateDto : OperationStatus
  {
    [DataMember]
    public UserState State { get; set; }
  }
}

using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Enums;

namespace Fixit.Core.DataContracts.Users.Operations.Account
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class UserAccountResetPasswordRequestDto : OperationStatus
  {
    [DataMember]
    public string UserId { get; set; }

    [DataMember]
    public string NewPassword { get; set; }
  }
}

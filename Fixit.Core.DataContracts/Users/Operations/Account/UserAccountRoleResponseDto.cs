using System.Runtime.Serialization;
using Fixit.Core.DataContracts;
using Fixit.Core.DataContracts.Users.Enums;

namespace Fixit.Core.DataContracts.Users.Operations.Account
{
  [DataContract]
  public class UserAccountRoleResponseDto : OperationStatus
  {
    [DataMember]
    public string UserId { get; set; }

    [DataMember]
    public UserRole Role { get; set; }
  }
}

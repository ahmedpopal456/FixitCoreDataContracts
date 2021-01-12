using System.Runtime.Serialization;
using Fixit.Core.DataContracts;
using Fixit.Core.DataContracts.Users.Enums;

namespace Fixit.Core.DataContracts.Users.Operations.Account
{
  [DataContract]
  public class UserAccountCreateRequestDto : OperationStatus
  {
    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public UserRole Role { get; set; }

    [DataMember]
    public string UserPrincipalName { get; set; }
  }
}

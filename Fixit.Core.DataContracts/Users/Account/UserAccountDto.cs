using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Enums;
using Fixit.Core.DataContracts.Users.Profile;
using Fixit.Core.DataContracts.Users.Skills;

namespace Fixit.Core.DataContracts.Users.Account
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class UserAccountDto : OperationStatus
  {
    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public UserRole Role { get; set; }

    [DataMember]
    public IEnumerable<SkillDto> Skills { get; set; }

    [DataMember]
    public string UserPrincipalName { get; set; }

    [DataMember]
    public UserAvailabilityDto Availability { get; set; }
  }
}

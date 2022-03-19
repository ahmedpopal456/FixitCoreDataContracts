using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;
using Fixit.Core.DataContracts.Users.Enums;
using Fixit.Core.DataContracts.Users.Profile;
using Fixit.Core.DataContracts.Users.Skill;

namespace Fixit.Core.DataContracts.Users.Operations.Account
{
  [DataContract]
  public class UserAccountCreateRequestDto : IFakeSeederAdapter<UserAccountCreateRequestDto>
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
    public IEnumerable<UserLicenseDto> Skills { get; set; }

    [DataMember]
    public string UserPrincipalName { get; set; }

    [DataMember]
    public UserAvailabilityDto Availability { get; set; }

    #region IFakeSeederAdapter
    public IList<UserAccountCreateRequestDto> SeedFakeDtos()
    {
      UserAccountCreateRequestDto firstUserAccountToCreate = new UserAccountCreateRequestDto
      {
        Id = "some_id",
        FirstName = "John",
        LastName = "Doe",
        Role = UserRole.Craftsman,
        UserPrincipalName = "johnDoe@test.com",
        Skills = new List<UserLicenseDto>
        {
          new UserLicenseDto { Id = Guid.NewGuid(), Name = "Hello" }
        }
      };

      UserAccountCreateRequestDto secondUserAccountToCreate = null;

      return new List<UserAccountCreateRequestDto>
      {
        firstUserAccountToCreate,
        secondUserAccountToCreate
      };
    }
    #endregion
  }
}

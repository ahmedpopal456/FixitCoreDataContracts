﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;
using Fixit.Core.DataContracts.Users.Enums;
using Fixit.Core.DataContracts.Users.Skills;

namespace Fixit.Core.DataContracts.Users.Operations.Account
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class UserAccountCreateRequestDto : OperationStatus, IFakeSeederAdapter<UserAccountCreateRequestDto>
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
    public SkillDto Skills { get; set; }

    [DataMember]
    public string UserPrincipalName { get; set; }

    #region IFakeSeederAdapter
    public IList<UserAccountCreateRequestDto> SeedFakeDtos()
    {
      UserAccountCreateRequestDto firstUserAccountToCreate = new UserAccountCreateRequestDto
      {
        Id = "some_id",
        FirstName = "John",
        LastName = "Doe",
        Role = UserRole.Client,
        UserPrincipalName = "johnDoe@test.com"

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

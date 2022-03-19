using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;

namespace Fixit.Core.DataContracts.Users.Skill
{
  public class UserLicenseDto : IFakeSeederAdapter<UserLicenseDto>
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public long ExpirationTimestampUtc { get; set; }

    [DataMember]
    public float YearsOfExperience { get; set; }

    #region Fake Seeder
    public IList<UserLicenseDto> SeedFakeDtos()
    {
      return new List<UserLicenseDto>
      {
        new UserLicenseDto
        {
          Id = new Guid("727012a4-773c-4994-99c9-0ff83d9e8734"),
          Name = "Masonry"
        },
        new UserLicenseDto
        {
          Id = new Guid("c086393d-d4b7-4ab1-9436-2aefa2b507c5"),
          Name = "Painting"
        },
        new UserLicenseDto
        {
          Id = new Guid("26a10b88-35a6-4cdb-8e8d-940c0ad094c4"),
          Name = "Ironwork"
        },
        new UserLicenseDto
        {
          Id = new Guid("8a2ff2a2-5404-4124-acb1-97895c2e32cd"),
          Name = "Concrete"
        }
      };
    }
    #endregion
  }
}

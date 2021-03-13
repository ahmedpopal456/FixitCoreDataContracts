using System;
using System.Collections.Generic;
using Fixit.Core.DataContracts.Seeders;

namespace Fixit.Core.DataContracts.Classifications
{
  public class FixUnitDto : IFakeSeederAdapter<FixUnitDto>
  {
    public Guid Id { get; set; }

    public string Name { get; set; }

    #region Fake Seeder
    public IList<FixUnitDto> SeedFakeDtos()
    {
      return new List<FixUnitDto>
      {
        new FixUnitDto
        {
          Id = new Guid("727012a4-773c-4994-99c9-0ff83d9e8734"),
          Name = "Living Room"
        },
        new FixUnitDto
        {
          Id = new Guid("c086393d-d4b7-4ab1-9436-2aefa2b507c5"),
          Name = "Dining Room"
        },
        new FixUnitDto
        {
          Id = new Guid("26a10b88-35a6-4cdb-8e8d-940c0ad094c4"),
          Name = "Kitchen"
        },
        new FixUnitDto
        {
          Id = new Guid("8a2ff2a2-5404-4124-acb1-97895c2e32cd"),
          Name = "Bedroom"
        }
      };
    }
    #endregion
  }
}

using System;
using System.Collections.Generic;
using Fixit.Core.DataContracts.Seeders;

namespace Fixit.Core.DataContracts.Classifications
{
  public class WorkTypeDto : IFakeSeederAdapter<WorkTypeDto>
  {
    public Guid Id { get; set; }

    public string Name { get; set; }

    #region Fake Seeder
    public IList<WorkTypeDto> SeedFakeDtos()
    {
      return new List<WorkTypeDto>
      {
        new WorkTypeDto()
        {
          Id = new Guid("96371910-43e3-4621-98c2-2396cd663e0c"),
          Name = "Quick Fix"
        },
        new WorkTypeDto()
        {
          Id = new Guid("51a1e09e-bf7e-48d1-ac51-538d6f1bb957"),
          Name = "Fix"
        }
      };
    }
    #endregion
  }
}

using System;
using System.Collections.Generic;
using Fixit.Core.DataContracts.Seeders;

namespace Fixit.Core.DataContracts.FixTemplates.Sections
{
  public class SectionDto : IFakeSeederAdapter<SectionDto>
  {
    public Guid Id { get; set; }

    public string Name { get; set; }

    #region Fake Seeder
    public IList<SectionDto> SeedFakeDtos()
    {
      return new List<SectionDto>
      {
        new SectionDto()
        {
          Id = new Guid("0b7d5429-cad0-487f-40f8-08d8af5a64f5"),
          Name = "Section 1"
        }
      };
    }
    #endregion
  }
}

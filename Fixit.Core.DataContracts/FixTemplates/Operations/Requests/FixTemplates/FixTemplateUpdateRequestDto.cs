using System;
using System.Collections.Generic;
using Fixit.Core.DataContracts.Seeders;

namespace Fixit.Core.DataContracts.FixTemplates.Operations.Requests.FixTemplates
{
  public class FixTemplateUpdateRequestDto : IFakeSeederAdapter<FixTemplateUpdateRequestDto>
  {
    public string Name { get; set; }

    public Guid WorkTypeId { get; set; }

    public Guid WorkCategoryId { get; set; }

    public Guid FixUnitId { get; set; }

    public string Description { get; set; }

    public Guid UpdatedByUserId { get; set; }

    public IEnumerable<string> Tags { get; set; }

    public IEnumerable<FixTemplateSectionCreateRequestDto> Sections { get; set; }

    #region Fake Seeder
    public IList<FixTemplateUpdateRequestDto> SeedFakeDtos()
    {
      return new List<FixTemplateUpdateRequestDto>
      {
        new FixTemplateUpdateRequestDto()
        {
          Name = "Updated Fix Template Name 1",
          WorkCategoryId = new Guid("96371910-43e3-4621-98c2-2396cd663e0c"),
          WorkTypeId = new Guid("445e50d1-b2e7-4c25-a628-c610aed7a357"),
          FixUnitId = new Guid("445e50d1-b2e7-4c25-a628-c610aed7a357"),
          Description = "Updated Description",
          UpdatedByUserId = new Guid("445e50d1-b2e7-4c25-a628-c610aed7a357"),
          Tags = new List<string>
          {
            "Tag 1",
            "Tag 2",
            "Tag 3"
          },
          Sections = new List<FixTemplateSectionCreateRequestDto>
          {
            new FixTemplateSectionCreateRequestDto()
            {
              Name = "Section 1",
              Fields = new List<FixTemplateFieldCreateRequestDto>
              {
                new FixTemplateFieldCreateRequestDto()
                {
                  Name = "Field 1.1",
                  Values = new List<string>
                  {
                    "Value 1.1.1",
                    "Value 1.1.2"
                  }
                },
                new FixTemplateFieldCreateRequestDto()
                {
                  Name = "Field 1.2",
                  Values = new List<string>
                  {
                    "Value 1.2.1",
                    "Value 1.2.2"
                  }
                }
              }
            }
          }
        }
      };
    }
    #endregion
  }
}

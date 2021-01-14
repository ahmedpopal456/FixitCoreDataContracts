using System;
using System.Collections.Generic;

namespace Fixit.Core.DataContracts.FixTemplates
{
  public class FixTemplateSectionDto
  {
    public Guid SectionId { get; set; }

    public string Name { get; set; }

    public IEnumerable<FixTemplateFieldDto> Fields { get; set; }
  }
}

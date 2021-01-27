using System;
using System.Collections.Generic;
using System.Text;

namespace Fixit.Core.DataContracts.FixTemplates.Operations.Requests.FixTemplates
{
  public class FixTemplateSectionCreateRequestDto
  {
    public string Name { get; set; }

    public IEnumerable<FixTemplateFieldCreateRequestDto> Fields { get; set; }

  }
}

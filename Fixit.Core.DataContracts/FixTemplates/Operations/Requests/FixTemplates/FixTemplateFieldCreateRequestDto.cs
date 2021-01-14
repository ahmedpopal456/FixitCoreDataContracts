using System.Collections.Generic;

namespace Fixit.Core.DataContracts.FixTemplates.Operations.Requests.FixTemplates
{
  public class FixTemplateFieldCreateRequestDto
  {
    public string Name { get; set; }

    public IEnumerable<string> Values { get; set; }
  }
}

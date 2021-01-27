using System;
using System.Collections.Generic;

namespace Fixit.Core.DataContracts.FixTemplates
{
  public class FixTemplateFieldDto
  {
    public Guid Id { get; set; }

    public string Name { get; set; }

    public IEnumerable<string> Values { get; set; }
  }
}

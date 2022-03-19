using System;
using System.Collections.Generic;

namespace Fixit.Core.DataContracts.FixTemplates
{
  public class LicenseDto
  {
    public Guid Id { get; set; }

    public float ReferenceId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public Guid CreatedByUserId { get; set; }

    public Guid UpdatedByUserId { get; set; }

    public IEnumerable<string> Tags { get; set; }
  }
}

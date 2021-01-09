using System;
using System.Collections.Generic;
using Fixit.Core.DataContracts.Fixes.Categories;
using Fixit.Core.DataContracts.Fixes.Types;

namespace Fixit.Core.DataContracts.FixTemplates
{
  public class FixTemplateDto
  {
    public Guid Id { get; set; }

    public FixTemplateStatus Status { get; set; }

    public string Name { get; set; }

    public FixCategoryDto Category { get; set; }

    public FixTypeDto Type { get; set; }

    public string Description { get; set; }

    public double SystemCostEstimate { get; set; }

    public Guid CreatedByUserId { get; set; }

    public Guid UpdatedByUserId { get; set; }

    public IEnumerable<string> Tags { get; set; }

    public IEnumerable<FixTemplateSectionDto> Sections { get; set; }
  }
}

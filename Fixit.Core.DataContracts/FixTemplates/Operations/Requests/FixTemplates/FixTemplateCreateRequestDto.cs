﻿using System;
using System.Collections.Generic;

namespace Fixit.Core.DataContracts.FixTemplates.Operations.Requests.FixTemplates
{
  public class FixTemplateCreateRequestDto
  {
    public FixTemplateStatus Status { get; set; }

    public string Name { get; set; }

    public Guid CategoryId { get; set; }

    public Guid TypeId { get; set; }

    public string Description { get; set; }

    public double SystemCostEstimate { get; set; }

    public Guid CreatedByUserId { get; set; }

    public Guid UpdatedByUserId { get; set; }

    public IEnumerable<string> Tags { get; set; }

    public IEnumerable<FixTemplateSectionCreateRequestDto> Sections { get; set; }
  }
}
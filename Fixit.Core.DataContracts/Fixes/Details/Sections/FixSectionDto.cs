﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Fixes.Details.Sections
{
  [DataContract]
  public class FixSectionDto
  {
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public IEnumerable<FixSectionDetailsDto> Details { get; set; }
  }
}

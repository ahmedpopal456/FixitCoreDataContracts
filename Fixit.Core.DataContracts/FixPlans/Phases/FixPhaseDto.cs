﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.Phases.Enums;
using Fixit.Core.DataContracts.FixPlans.Phases.Tasks;

namespace Fixit.Core.DataContracts.FixPlans.Phases
{
  [DataContract]
  public class FixPhaseDto : OperationStatus
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public PhaseStatuses Status { get; set; }

    [DataMember]
    public IEnumerable<FixPhaseTaskDto> Tasks { get; set; }
  }
}

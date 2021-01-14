﻿using System;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.Phases.Tasks.Enums;

namespace Fixit.Core.DataContracts.FixPlans.Phases.Tasks
{
  [DataContract]
  public class FixPhaseTaskDto
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string Description { get; set; }

    [DataMember]
    public int Order { get; set; }

    [DataMember]
    public TaskStatuses Status { get; set; }
  }
}

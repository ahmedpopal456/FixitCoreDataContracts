﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.BillingDetails;
using Fixit.Core.DataContracts.FixPlans.Enums;
using Fixit.Core.DataContracts.FixPlans.Phases;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.FixPlans
{
  [DataContract]
  public class FixPlanDto : OperationStatus
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public Guid FixId { get; set; }

    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimestampUtc { get; set; }

    [DataMember]
    public bool IsBookmarked { get; set; }

    [DataMember]
    public FixPlanProposalStates ProposalState { get; set; }

    [DataMember]
    public float TotalCost { get; set; }

    [DataMember]
    public Guid ActivePhaseId { get; set; }

    [DataMember]
    public FixPlanBillingDetailsDto BillingDetails { get; set; }

    [DataMember]
    public IEnumerable<FixPhaseDto> Phases { get; set; }

    [DataMember]
    public UserSummaryDto CreatedByCraftsman { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.BillingDetails;
using Fixit.Core.DataContracts.FixPlans.Phases;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  [DataContract]
  public class FixPlanCreateRequestDto
  {
    [DataMember]
    public Guid FixId { get; set; }

    [DataMember]
    public bool IsBookmarked { get; set; }

    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public float TotalCost { get; set; }

    [DataMember]
    public FixPlanBillingDetailsDto BillingDetails { get; set; }

    [DataMember]
    public IEnumerable<FixPhaseDto> Phases { get; set; }

    [DataMember]
    public UserSummaryDto CreatedByCraftsman { get; set; }
  }
}

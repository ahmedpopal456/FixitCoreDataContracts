using System;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Fixes.Cost;
using Fixit.Core.DataContracts.Fixes.Enums;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Fixes.Operations.Requests
{
  [DataContract]
  public class FixUpdateAssignRequestDto : OperationStatus
  {

    [DataMember]
    public UserSummaryDto AssignedToCraftsman { get; set; }

    [DataMember]
    public FixCostRangeDto ClientEstimatedCost { get; set; }

    [DataMember]
    public float SystemCalculatedCost { get; set; }

    [DataMember]
    public FixCostEstimationDto CraftsmanEstimatedCost { get; set; }

    [DataMember]
    public UserSummaryDto UpdatedByUser { get; set; }

    [DataMember]
    public FixStatuses Status { get; set; }
  }
}

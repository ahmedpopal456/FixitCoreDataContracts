using System;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Fixes.Cost;

namespace Fixit.Core.DataContracts.Fixes.Operations.Responses
{
  [DataContract]
  public class FixCostResponseDto : OperationStatus
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public FixCostRangeDto ClientEstimatedCost { get; set; }

    [DataMember]
    public float SystemCalculatedCost { get; set; }

    [DataMember]
    public FixCostEstimationDto CraftsmanEstimatedCost { get; set; }
  }
}

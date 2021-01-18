using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Fixes.Cost;

namespace Fixit.Core.DataContracts.Fixes.Operations.Responses
{
  [DataContract]
  public class FixGetCostResponseDto : OperationStatus
  {
    [DataMember]
    public FixCostRangeDto ClientEstimatedCost { get; set; }

    [DataMember]
    public float SystemCalculatedCost { get; set; }

    [DataMember]
    public FixCostEstimationDto CraftsmanEstimatedCost { get; set; }
  }
}

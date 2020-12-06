using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Fixes.Cost
{
  [DataContract]
  public class FixCostEstimationDto
  {
    [DataMember]
    public float Cost { get; set; }

    [DataMember]
    public string Comment { get; set; }
  }
}

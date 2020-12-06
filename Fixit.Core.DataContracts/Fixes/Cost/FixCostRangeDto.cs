using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Fixes.Cost
{
  [DataContract]
  public class FixCostRangeDto
  {
    [DataMember]
    public int MaximumCost { get; set; }

    [DataMember]
    public int MinimumCost { get; set; }
  }
}

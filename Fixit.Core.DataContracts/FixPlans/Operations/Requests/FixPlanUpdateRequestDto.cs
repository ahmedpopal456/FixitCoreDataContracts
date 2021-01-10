using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.FixPlans.Phases;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  [DataContract]
  public class FixPlanUpdateRequestDto
  {
      [DataMember]
      public bool IsBookmarked { get; set; }
      
      [DataMember]
      public IEnumerable<FixPhaseDto> Phases { get; set; }

      [DataMember]
      public long UpdatedTimestampUtc { get; set; }
  }
}

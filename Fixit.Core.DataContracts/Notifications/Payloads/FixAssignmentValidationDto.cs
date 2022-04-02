using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Fixes.Cost;
using Fixit.Core.DataContracts.Fixes.Schedule;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Notifications.Payloads
{
  [DataContract]
  public class FixAssignmentValidationDto : PayloadBaseDto
  {
    [DataMember]
    public UserSummaryDto AssignedToCraftsman { get; set; }

    [DataMember]
    public FixCostEstimationDto CraftsmanEstimatedCost { get; set; }

    [DataMember]
    public IList<FixScheduleRangeDto> Schedule { get; set; }

    [DataMember]
    public UserSummaryDto CreatedByClient { get; set; }
  }
}

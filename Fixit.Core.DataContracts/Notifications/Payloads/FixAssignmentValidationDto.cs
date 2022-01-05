using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Classifications;
using Fixit.Core.DataContracts.Fixes.Cost;
using Fixit.Core.DataContracts.Fixes.Details;
using Fixit.Core.DataContracts.Fixes.Files;
using Fixit.Core.DataContracts.Fixes.Schedule;
using Fixit.Core.DataContracts.Users;
using Fixit.Core.DataContracts.Users.Address;

namespace Fixit.Core.DataContracts.Notifications.Payloads
{
  [DataContract]
  public class FixAssignmentValidationDto : PayloadBaseDto
  {
    [DataMember]
    public UserSummaryDto AssignedToCraftsman { get; set; }

    [DataMember]
    public FixCostRangeDto ClientBudget { get; set; }

    [DataMember]
    public float SystemCalculatedCost { get; set; }

    [DataMember]
    public FixCostEstimationDto CraftsmanEstimatedCost { get; set; }

    [DataMember]
    public IList<FixScheduleRangeDto> Schedule { get; set; }

    [DataMember]
    public WorkCategoryDto WorkCategory { get; set; }

    [DataMember]
    public WorkTypeDto WorkType { get; set; }

    [DataMember]
    public AddressDto Location { get; set; }

    [DataMember]
    public IEnumerable<FileDto> Images { get; set; }

    [DataMember]
    public FixDetailsDto FixDetails { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Fixes.Cost;
using Fixit.Core.DataContracts.Fixes.Enums;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Fixes.Operations.Requests
{
  [DataContract]
  public class FixUpdateAssignRequestDto : OperationStatus, IFakeSeederAdapter<FixUpdateAssignRequestDto>
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

    public IList<FixUpdateAssignRequestDto> SeedFakeDtos()
    {
      FixUpdateAssignRequestDto firstFixDocument = new FixUpdateAssignRequestDto
      {
        AssignedToCraftsman = new UserSummaryDto()
        {
          Id = new Guid("8b418766-4a99-42a8-b6d7-9fe52b88ea69"),
          FirstName = "Old",
          LastName = "McDonald"
        },
        ClientEstimatedCost = new FixCostRangeDto()
        {
          MaximumCost = 9000,
          MinimumCost = 300
        },
        SystemCalculatedCost = (float)123.45,
        CraftsmanEstimatedCost = new FixCostEstimationDto()
        {
          Cost = (float)5000,
          Comment = "Take it or leave it"
        },
        UpdatedByUser = new UserSummaryDto()
        {
          Id = new Guid("8b418766-4a99-42a8-b6d7-9fe52b88ea93"),
          FirstName = "Mary",
          LastName = "Lamb"
        }
      };

      FixUpdateAssignRequestDto secondFixDocument = null;

      return new List<FixUpdateAssignRequestDto>
      {
        firstFixDocument,
        secondFixDocument
      };
    }
  }
}

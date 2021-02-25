using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;
using Fixit.Core.DataContracts.Users.Enums;

namespace Fixit.Core.DataContracts.Users.Operations.Ratings
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class UserRatingsCreateOrUpdateRequestDto : OperationStatus, IFakeSeederAdapter<UserRatingsCreateOrUpdateRequestDto>
  {
    [DataMember]
    public float Score { get; set; }

    [DataMember]
    public string Comment { get; set; }

    [DataMember]
    public UserSummaryDto ReviewedByUser { get; set; }

    [DataMember]
    public UserSummaryDto ReviewedUser { get; set; }

    [DataMember]
    public RatingType Type { get; set; }

    #region IFakeSeederAdapter
    public IList<UserRatingsCreateOrUpdateRequestDto> SeedFakeDtos()
    {
      UserRatingsCreateOrUpdateRequestDto firstRatingsRequest = new UserRatingsCreateOrUpdateRequestDto
      {
        Score = 3,
        Comment = "This is a comment",
        ReviewedByUser = new UserSummaryDto()
        {
          Id = new Guid("385de974-be63-4eb3-931b-a853d5f63729"),
          FirstName = "Janet",
          LastName = "Doe"
        },
        ReviewedUser = new UserSummaryDto()
        {
          Id = new Guid("20f5fc6d-7de9-4dbd-9289-23d32ea6548d"),
          FirstName = "John",
          LastName = "Doe"
        },
        Type = RatingType.User
      };

      UserRatingsCreateOrUpdateRequestDto secondRatingsRequest = null;

      return new List<UserRatingsCreateOrUpdateRequestDto>
      {
        firstRatingsRequest,
        secondRatingsRequest
      };
    }
    #endregion
  }
}

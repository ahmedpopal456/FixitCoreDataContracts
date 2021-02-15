using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Enums;

namespace Fixit.Core.DataContracts.Users.Operations.Ratings
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class UserRatingsCreateOrUpdateRequestDto : OperationStatus
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
  }
}

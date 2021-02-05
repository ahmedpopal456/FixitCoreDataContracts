using System;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Enums;

namespace Fixit.Core.DataContracts.Users.Ratings
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class RatingDto : OperationStatus
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public float Score { get; set; }

    [DataMember]
    public UserSummaryDto ReviewedByUser { get; set; }

    [DataMember]
    public UserSummaryDto ReviewedUser { get; set; }

    [DataMember]
    public string Comment { get; set; }

    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimestampUtc { get; set; }

    [DataMember]
    public RatingType Type { get; set; }
  }
}

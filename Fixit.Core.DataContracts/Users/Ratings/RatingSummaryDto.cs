using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Ratings
{
  [DataContract]
  public class RatingSummaryDto
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public float Score { get; set; }

    [DataMember]
    public UserSummaryDto CreatedByUser { get; set; }

    [DataMember]
    public string Comment { get; set; }
  }
}

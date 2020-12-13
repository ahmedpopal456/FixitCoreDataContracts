using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Ratings
{
  [DataContract]
  public class RatingsSummaryDto
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public float AverageRating { get; set; }

    [DataMember]
    public IEnumerable<RatingSummaryDto> Ratings { get; set; }
  }
}

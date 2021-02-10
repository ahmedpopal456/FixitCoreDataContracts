using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Ratings
{
  public class RatingsDto
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public float AverageRating { get; set; }

    [DataMember]
    public IEnumerable<RatingDto> Ratings { get; set; }

    [DataMember]
    public UserSummaryDto RatingsOfUser { get; set; }
  }
}

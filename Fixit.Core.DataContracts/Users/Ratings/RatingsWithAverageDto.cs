using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Ratings
{
  [DataContract]
  public class RatingsWithAverageDto
  {
    [DataMember]
    public Guid id { get; set; }

    [DataMember]
    public float AverageRating { get; set; }

    [DataMember]
    public IEnumerable<RatingDenormalizedDto> Ratings { get; set; }
  }
}

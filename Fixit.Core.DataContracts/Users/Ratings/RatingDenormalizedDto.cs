using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Ratings
{
  [DataContract]
  public class RatingDenormalizedDto
  {
    [DataMember]
    public Guid id { get; set; }

    [DataMember]
    public float Score { get; set; }

    [DataMember]
    public UserDenormalizedDto CreatedBy { get; set; }

    [DataMember]
    public string Comment { get; set; }
  }
}

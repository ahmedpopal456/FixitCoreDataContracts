using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Ratings
{
  [DataContract]
  public class RatingDto
  {
    [DataMember]
    public float Score { get; set; }

    [DataMember]
    public UserDenormalizedDto ReviewedBy { get; set; }

    [DataMember]
    public UserDenormalizedDto Reviewed { get; set; }

    [DataMember]
    public string Comment { get; set; }

    [DataMember]
    public long CreateTimestampUtc { get; set; }
  }
}

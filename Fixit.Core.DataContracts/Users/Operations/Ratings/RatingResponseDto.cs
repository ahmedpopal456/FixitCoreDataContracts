using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Ratings;

namespace Fixit.Core.DataContracts.Users.Operations.Ratings
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class RatingResponseDto : OperationStatus
  {
    [DataMember]
    public RatingDto Rating { get; set; }
  }
}

using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Operations.Ratings
{
    [DataContract]
    public class RatingListResponseDto 
    {
        [DataMember]
        public float AverageRating { get; set; }

        [DataMember]
        public int ReviewCount { get; set; }

    }
}

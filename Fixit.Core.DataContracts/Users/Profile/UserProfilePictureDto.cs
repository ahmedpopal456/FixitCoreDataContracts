using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Profile
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class UserProfilePictureDto : OperationStatus
  {
    [DataMember]
    public string ProfilePictureUrl { get; set; }
  }
}

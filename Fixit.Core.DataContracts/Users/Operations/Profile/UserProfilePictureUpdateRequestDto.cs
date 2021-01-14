using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Operations.Profile
{
  [DataContract]
  public class UserProfilePictureUpdateRequestDto
  {
    [DataMember]
    public string ProfilePictureUrl { get; set; }
  }
}

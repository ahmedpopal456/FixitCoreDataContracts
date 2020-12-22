using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Profile
{
  [DataContract]
  public class UserProfilePictureDto
  {
    [DataMember]
    public string ProfilePictureUrl { get; set; }
  }
}

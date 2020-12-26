using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Profile
{
  [DataContract]
  public class UserProfileDto : UserProfileInformationDto
  {
    [DataMember]
    public string ProfilePictureUrl { get; set; }
  }
}

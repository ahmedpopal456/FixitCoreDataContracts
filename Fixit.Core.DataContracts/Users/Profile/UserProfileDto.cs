using System.Runtime.Serialization;
using Fixit.Core.Database.DataContracts;
using Fixit.Core.DataContracts.Users.Address;

namespace Fixit.Core.DataContracts.Users.Profile
{
  [DataContract]
  public class UserProfileDto : UserProfileInformationDto
  {
    [DataMember]
    public string ProfilePictureUrl { get; set; }
  }
}

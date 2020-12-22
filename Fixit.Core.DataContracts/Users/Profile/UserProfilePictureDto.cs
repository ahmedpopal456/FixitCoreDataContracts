using System.Runtime.Serialization;
using Fixit.Core.Database.DataContracts;

namespace Fixit.Core.DataContracts.Users.Profile
{
  [DataContract]
  public class UserProfilePictureDto : OperationStatus
  {
    [DataMember]
    public string ProfilePictureUrl { get; set; }
  }
}

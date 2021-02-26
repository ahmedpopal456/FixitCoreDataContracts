using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;

namespace Fixit.Core.DataContracts.Users.Operations.Profile
{
  [DataContract]
  public class UserProfilePictureUpdateRequestDto : IFakeSeederAdapter<UserProfilePictureUpdateRequestDto>
  {
    [DataMember]
    public string ProfilePictureUrl { get; set; }

    #region IFakeSeederAdapter
    public IList<UserProfilePictureUpdateRequestDto> SeedFakeDtos()
    {
      UserProfilePictureUpdateRequestDto firstUserProfilePictureUpdateRequest = new UserProfilePictureUpdateRequestDto
      {
        ProfilePictureUrl = "something.something/somethingnew.png"
      };

      UserProfilePictureUpdateRequestDto secondUserProfilePictureUpdateRequest = null;

      return new List<UserProfilePictureUpdateRequestDto>
      {
        firstUserProfilePictureUpdateRequest,
        secondUserProfilePictureUpdateRequest
      };
    }
    #endregion
  }
}

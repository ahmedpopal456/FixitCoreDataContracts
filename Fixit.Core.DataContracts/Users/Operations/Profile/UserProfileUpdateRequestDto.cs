using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;
using Fixit.Core.DataContracts.Users.Profile;

namespace Fixit.Core.DataContracts.Users.Operations.Profile
{
  [DataContract]
  public class UserProfileUpdateRequestDto : IFakeSeederAdapter<UserProfileUpdateRequestDto>
  {
    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public UserAvailabilityDto Availability { get; set; }

    #region IFakeSeederAdapter
    public IList<UserProfileUpdateRequestDto> SeedFakeDtos()
    {
      UserProfileUpdateRequestDto firstUserProfileUpdateRequest = new UserProfileUpdateRequestDto
      {
        FirstName = "Jane",
        LastName = "Doe",
        Availability = new UserAvailabilityDto
        {
          Type = Enums.AvailabilityType.Always
        }
      };

      UserProfileUpdateRequestDto secondUserProfileUpdateRequest = null;

      return new List<UserProfileUpdateRequestDto>
      {
        firstUserProfileUpdateRequest,
        secondUserProfileUpdateRequest
      };
    }
    #endregion
  }
}

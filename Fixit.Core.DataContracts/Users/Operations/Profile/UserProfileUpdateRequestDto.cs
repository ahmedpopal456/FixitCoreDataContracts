using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;
using Fixit.Core.DataContracts.Users.Address;
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
    public AddressDto Address { get; set; }

    [DataMember]
    public UserAvailabilityDto Availability { get; set; }

    #region IFakeSeederAdapter
    public IList<UserProfileUpdateRequestDto> SeedFakeDtos()
    {
      UserProfileUpdateRequestDto firstUserProfileUpdateRequest = new UserProfileUpdateRequestDto
      {
        FirstName = "Jane",
        LastName = "Doe",
        Address = new AddressDto()
        {
          Address = "123 Something",
          City = "Montreal",
          Province = "Quebec",
          Country = "Canada",
          PostalCode = "A1A 1A1",
          PhoneNumber = "514-123-4567"
        },
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

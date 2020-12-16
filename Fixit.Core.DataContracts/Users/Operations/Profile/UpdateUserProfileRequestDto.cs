using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Address;

namespace Fixit.Core.DataContracts.Users.Operations.Profile
{
  [DataContract]
  public class UpdateUserProfileRequestDto
  {

    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }

    [DataMember]
    public AddressDto Address { get; set; }
  }
}

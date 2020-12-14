using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Details.Craftsman;

namespace Fixit.Core.DataContracts.Users
{
  [DataContract]
  public class CraftsmanDto : UserDto
  {
    [DataMember]
    public CraftsmanDetailsDto SpecificDetails { get; set; }
  }
}

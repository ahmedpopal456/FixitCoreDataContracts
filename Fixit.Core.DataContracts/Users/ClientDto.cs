using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Details.Client;

namespace Fixit.Core.DataContracts.Users
{
  [DataContract]
  public class ClientDto : UserDto
  {
    [DataMember]
    public ClientDetailsDto SpecificDetails { get; set; }
  }
}

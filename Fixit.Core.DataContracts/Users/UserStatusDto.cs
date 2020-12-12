using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Enums;

namespace Fixit.Core.DataContracts.Users
{
  [DataContract]
  public class UserStatusDto
  {
    [DataMember]
    public UserStatus Status { get; set; }

    [DataMember]
    public long LastSeenTimestampUtc { get; set; }
  }
}

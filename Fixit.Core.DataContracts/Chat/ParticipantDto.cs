using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Chat
{
  [DataContract]
  public class ParticipantDto
  {
    [DataMember]
    public UserBaseDto User { get; set; }

    [DataMember]
    public bool HasUnreadMessages { get; set; }
  }
}

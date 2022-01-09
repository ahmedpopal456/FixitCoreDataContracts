using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Chat.Operations.Activities
{
  [DataContract]
  public class UserTypingActivity
  {
    [DataMember]
    public UserBaseDto SentByUser { get; set; }

    [DataMember]
    public bool IsTyping { get; set; }

    [DataMember]
    public long SentTimestampUtc { get; set; }
  }
}

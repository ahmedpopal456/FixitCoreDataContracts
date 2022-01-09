using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Chat.Enums;

namespace Fixit.Core.DataContracts.Chat.Details
{
  [DataContract]
  public class ContextDetails
  {
    [DataMember]
    public ChatEntityTypes Type { get; set; }

    [DataMember]
    public string Id { get; set; }

    [DataMember]
    public string Name { get; set; }
  }
}

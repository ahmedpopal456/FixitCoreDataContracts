using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Chat.Enums;

namespace Fixit.Core.DataContracts.Chat.Operations.Queries
{
  [DataContract]
  public class ContextDetailsQueryDto
  {
    private IEnumerable<ChatEntityTypes> _types;

    [DataMember]
    public IEnumerable<ChatEntityTypes> Types { get => _types?.Distinct(); set => _types = value; }

    [DataMember]
    public IEnumerable<string> Ids { get; set; }
  }
}

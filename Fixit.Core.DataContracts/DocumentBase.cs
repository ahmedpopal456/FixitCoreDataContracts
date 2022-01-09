using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts
{
  [DataContract]
  public class DocumentBase
  {
    [DataMember]
    public string id { get; set; }

    [DataMember]
    public string EntityId { get; set; }
  }
}

using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Fixes.Tags
{
  [DataContract]
  public class TagDto : OperationStatus
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public string GroupId { get; set; }

    [DataMember]
    public TagStatisticsDto Statistics { get; set; }
  }
}

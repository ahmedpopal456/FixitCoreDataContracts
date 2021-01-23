using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Fixes.Tags
{
  /// <summary>
  /// TODO: Fill out once use is clearly defined
  /// </summary>
  public class TagStatisticsDto : OperationStatus
  {
    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimeStampUtc { get; set; }
  }
}

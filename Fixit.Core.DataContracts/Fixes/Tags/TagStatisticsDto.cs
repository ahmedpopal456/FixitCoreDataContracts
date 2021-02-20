using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Fixes.Tags
{
  /// <summary>
  /// TODO: Fill out once use is clearly defined
  /// </summary>
  public class TagStatisticsDto
  {
    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimeStampUtc { get; set; }

    [DataMember]
    public long TotalFixesCount { get; set; }

    [DataMember]
    public long CompletedFixesCount { get; set; }

    [DataMember]
    public long PercentageUsage { get; set; }
  }
}

using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Fixes.Files
{
  /// <summary>
  /// TODO: Fill out once use is clearly defined
  /// </summary>
  public class FileMetadataDto
  {
    [DataMember]
    public long CreatedTimestampUtc { get; set; }

    [DataMember]
    public long UpdatedTimeStampUtc { get; set; }
  }
}

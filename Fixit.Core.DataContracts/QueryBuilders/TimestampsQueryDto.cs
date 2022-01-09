using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.QueryBuilders
{
  // TODO: TODO : Merge with NumericalQueryDto & find better name
  [DataContract]
  public class TimestampsQueryDto
  {
    [DataMember]
    public QueryBuilderOperators? QueryBuilderOperator { get; set; }

    [DataMember]
    public long MinTimestampUtc { get; set; }

    [DataMember]
    public long? MaxTimestampUtc { get; set; }
  }
}

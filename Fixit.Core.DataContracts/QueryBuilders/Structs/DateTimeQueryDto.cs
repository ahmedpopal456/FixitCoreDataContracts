using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.QueryBuilders.Structs
{
  // TODO : Merge with NumericalQueryDto & find better name
  [DataContract]
  public class DateTimeQueryDto
  {
    [DataMember]
    public QueryBuilderOperators QueryBuilderOperator { get; set; }

    [DataMember]
    public DateTime MinValue { get; set; }

#nullable enable
    /// <summary>
    /// If value is given, MaxValue takes precedence over QueryBuilderOperator
    /// </summary>
    [DataMember]
    public DateTime? MaxValue { get; set; }
  }
}

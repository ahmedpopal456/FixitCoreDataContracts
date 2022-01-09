using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.QueryBuilders.Structs
{
  // TODO : Merge with DateTimeQueryDto & find better name
  [DataContract]
  public class NumericalQueryDto<T> where T : struct
  {
    [DataMember]
    public QueryBuilderOperators? QueryBuilderOperator { get; set; }

    [DataMember]
    public T MinValue { get; set; }

    [DataMember]
    public T? MaxValue { get; set; }
  }
}

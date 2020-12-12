using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users
{
  [DataContract]
  public class UserDenormalizedDto
  {
    [DataMember]
    public Guid id { get; set; }

    [DataMember]
    public string Name { get; set; }
  }
}

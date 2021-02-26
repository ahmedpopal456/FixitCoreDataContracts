﻿using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Fixes.Locations
{
  public class FixLocationResponseDto: OperationStatus
  {
    [DataMember]
    public string Address { get; set; }

    [DataMember]
    public string City { get; set; }

    [DataMember]
    public string Province { get; set; }

    [DataMember]
    public string PostalCode { get; set; }

    [DataMember]
    public string LastUsedTimeStampUtc { get; set; }
  }
}
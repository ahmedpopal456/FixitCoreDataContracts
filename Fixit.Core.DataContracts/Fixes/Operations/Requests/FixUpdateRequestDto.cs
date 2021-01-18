using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Fixes.Details;
using Fixit.Core.DataContracts.Fixes.Enums;
using Fixit.Core.DataContracts.Fixes.Files;
using Fixit.Core.DataContracts.Fixes.Locations;
using Fixit.Core.DataContracts.Fixes.Schedule;
using Fixit.Core.DataContracts.Users;

namespace Fixit.Core.DataContracts.Fixes.Operations.Requests
{
  [DataContract]
  public class FixUpdateRequestDto : OperationStatus
  {
    [DataMember]
    public Guid Id { get; set; }

    [DataMember]
    public IEnumerable<FixDetailsDto> Details { get; set; }

    [DataMember]
    public IEnumerable<FileDto> Images { get; set; }

    [DataMember]
    public FixLocationDto Location { get; set; }

    [DataMember]
    public IEnumerable<FixScheduleRangeDto> Schedule { get; set; }

    [DataMember]
    public long UpdatedTimestampUtc { get; set; }

    [DataMember]
    public UserSummaryDto UpdatedByUser { get; set; }

    [DataMember]
    public FixStatuses Status { get; set; }

  }
}

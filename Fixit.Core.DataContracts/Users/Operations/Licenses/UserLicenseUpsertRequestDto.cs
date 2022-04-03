using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;
using Fixit.Core.DataContracts.Users.Licenses.Enums;

namespace Fixit.Core.DataContracts.Users.Operations.Licenses
{
  public class UserLicenseUpsertRequestDto
  {

    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public long ExpirationTimestampUtc { get; set; }

    [DataMember]
    public float YearsOfExperience { get; set; }

    [DataMember]
    public string AttachmentUrl { get; set; }

    [DataMember]
    public ProcessingStatus ProcessingStatus { get; set; }
  }
}

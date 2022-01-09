﻿using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.QueryBuilders
{
  public class UserQueryDto
  {
    [DataMember]
    public Guid? Id { get; set; }

    [DataMember]
    public string FirstName { get; set; }

    [DataMember]
    public string LastName { get; set; }
  }
}

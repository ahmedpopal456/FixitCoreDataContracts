﻿using System;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Notifications.Payloads
{
  [DataContract]
  public class PayloadBaseDto
  {
    [DataMember]
    public Guid Id { get; set; }
  }
}
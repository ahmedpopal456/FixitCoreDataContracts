using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Fixit.Core.DataContracts.Chat.Enums
{
  [DataContract]
  public enum ChatEntityTypes
  {
    [EnumMember]
    Fixes,
  }
}

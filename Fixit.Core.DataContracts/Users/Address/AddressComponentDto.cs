using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Users.Address.Enums;
using Newtonsoft.Json;

namespace Fixit.Core.DataContracts.Users.Address
{
  [DataContract]
  public class AddressComponentDto
  {
    //
    // Summary:
    //     short_name is an abbreviated textual name for the address component, if available.
    //     For example, an address component for the state of Alaska may have a long_name
    //     of "Alaska" and a short_name of "AK" using the 2-letter postal abbreviation.
    [DataMember]
    public string ShortName { get; set; }
    //
    // Summary:
    //     long_name is the full text description or name of the address component as returned
    //     by the Geocoder.
    [DataMember]
    public string LongName { get; set; }
    //
    // Summary:
    //     types[] is an array indicating the type of the address component.
    [DataMember]
    public IEnumerable<AddressItemTypes> Types { get; set; }
  }
}

using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Address
{
  [DataContract]
  public class AddressDto
  {
    //
    // Summary:
    //     Formatted_address is a string containing the human-readable address of this place.
    //     Often this address is equivalent to the "postal address," which sometimes differs
    //     from country to country. This address is generally composed of one or more address_component
    //     fields.
    [DataMember]
    public string FormattedAddress { get; set; }
    //
    // Summary:
    //     address_components[] is an array of separate address components used to compose
    //     a given address. For example, the address "111 8th Avenue, New York, NY" contains
    //     separate address components for "111" (the street number, "8th Avenue" (the route),
    //     "New York" (the city) and "NY" (the US state). Each address_component typically
    //     contains: ◦types[] is an array indicating the type of the address component.
    [DataMember]
    public IEnumerable<AddressComponentDto> AddressComponents { get; set; }
  }
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Fixit.Core.DataContracts.Users.Address.Query
{
  [DataContract]
  public class AddressQueryItem
  {
    //
    // Summary:
    //     PlaceId is a textual identifier that uniquely identifies a place. To retrieve
    //     information about the place, pass this identifier in the placeId field of a Google
    //     Places API Web Service request
    [DataMember]
    public string PlaceId { get; set; }
    //
    // Summary:
    //     Description contains the human-readable name for the returned result. For establishment
    //     results, this is usually the business name.
    [DataMember]
    public string Description { get; set; }
  }
}

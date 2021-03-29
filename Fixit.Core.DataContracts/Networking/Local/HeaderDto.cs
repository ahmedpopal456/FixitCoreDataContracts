using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Networking.Local
{
	[DataContract]
	public class HeaderDto
	{
		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public string Value { get; set; }
	}
}

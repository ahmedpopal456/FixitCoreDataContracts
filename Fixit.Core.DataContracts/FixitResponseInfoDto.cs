using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Fixit.Core.DataContracts
{
	[DataContract]
	public class FixitResponseInfoDto
	{
		[DataMember]
		public string Code { get; set; }

		[DataMember]
		public string CodeDefinition { get; set; }

		[DataMember]
		public string Description { get; set; }
	}
}

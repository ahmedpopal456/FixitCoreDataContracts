using System.Runtime.Serialization;

namespace Fixit.Core.DataContracts.Users.Details.Craftsman
{
  [DataContract]
  public class SkillDto
  {
    [DataMember]
    public string Name { get; set; }

    [DataMember]
    public float YearsOfExperience { get; set; }
  }
}

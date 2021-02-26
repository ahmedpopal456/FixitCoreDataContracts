using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;
using Fixit.Core.DataContracts.Users.Enums;

namespace Fixit.Core.DataContracts.Users.Account
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class UserAccountStateDto : OperationStatus, IFakeSeederAdapter<UserAccountStateDto>
  {
    [DataMember]
    public UserState State { get; set; }

    #region IFakeSeederAdapter
    public IList<UserAccountStateDto> SeedFakeDtos()
    {
      UserAccountStateDto firstUserAccountToUpdate = new UserAccountStateDto
      {
        State = UserState.Enabled,
        IsOperationSuccessful = true
      };

      UserAccountStateDto secondUserAccountToUpdate = null;


      return new List<UserAccountStateDto>
      {
        firstUserAccountToUpdate,
        secondUserAccountToUpdate
      };
    }
    #endregion
  }
}

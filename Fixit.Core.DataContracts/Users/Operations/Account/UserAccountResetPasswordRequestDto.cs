using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Seeders;
using Fixit.Core.DataContracts.Users.Enums;

namespace Fixit.Core.DataContracts.Users.Operations.Account
{
  [DataContract, KnownType(typeof(OperationStatus))]
  public class UserAccountResetPasswordRequestDto : OperationStatus, IFakeSeederAdapter<UserAccountResetPasswordRequestDto>
  {
    [DataMember]
    public string UserId { get; set; }

    [DataMember]
    public string NewPassword { get; set; }

    #region IFakeSeederAdapter
    public IList<UserAccountResetPasswordRequestDto> SeedFakeDtos()
    {
      UserAccountResetPasswordRequestDto firstUserAccountToUpdate = new UserAccountResetPasswordRequestDto
      {
        NewPassword = "Fara0921",
      };

      UserAccountResetPasswordRequestDto secondUserAccountToUpdate = null;


      return new List<UserAccountResetPasswordRequestDto>
      {
        firstUserAccountToUpdate,
        secondUserAccountToUpdate
      };
    }
    #endregion
  }
}

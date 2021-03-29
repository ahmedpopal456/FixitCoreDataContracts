using System.Threading;
using System.Threading.Tasks;
using Fixit.Core.DataContracts.Notifications.Operations;

namespace Fixit.Core.DataContracts.Networking.Local.NMS
{
  public interface IFixNmsHttpClient
  {
    Task<OperationStatus> PostNotification(EnqueueNotificationRequestDto enqueueNotificationRequestDto, CancellationToken cancellationToken);
  }
}

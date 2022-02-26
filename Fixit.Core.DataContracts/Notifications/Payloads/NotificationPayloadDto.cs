using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Notifications.Enums;

namespace Fixit.Core.DataContracts.Notifications.Payloads
{
  /// <summary>
  /// A Notification Payload
  /// </summary>
  [DataContract]
  public class NotificationPayloadDto
  {
    [DataMember]
    public object SystemPayload { get; set; }

    [DataMember]
    public NotificationTypes Action { get; set; }
  }
}

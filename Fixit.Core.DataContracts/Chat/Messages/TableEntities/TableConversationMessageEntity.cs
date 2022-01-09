using System.Collections.Generic;
using Fixit.Core.DataContracts.Auditables;
using Fixit.Core.DataContracts.Chat.Operations.Requests;
using Microsoft.Azure.Cosmos.Table;

namespace Fixit.Core.DataContracts.Chat.Messages.TableEntities
{
  public class TableConversationMessageEntity : TableEntity, ITimeTraceableEntity
  {
    public string Message { get; set; }

    public string Attachments { get; set; }

    public string CreatedByUser { get; set; }

    public string UpdatedByUser { get; set; }

    public long CreatedTimestampUtc { get; set; }

    public long UpdatedTimestampUtc { get; set; }
  }
}

using System;
using System.Collections.Generic;

namespace Fixit.Core.DataContracts.Files.Jobs.Responses
{
  public class FileDownloadJobResponseDto
  {
    public Guid JobId { get; set; }

    public string CreatedTimestampUTC { get; set; }

    public IEnumerable<string> FilePathsRequested { get; set; }
  }
}
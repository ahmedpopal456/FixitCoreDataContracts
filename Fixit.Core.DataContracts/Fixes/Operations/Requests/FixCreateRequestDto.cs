using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Fixit.Core.DataContracts.Fixes.Cost;
using Fixit.Core.DataContracts.Fixes.Details;
using Fixit.Core.DataContracts.Fixes.Enums;
using Fixit.Core.DataContracts.Fixes.Files;
using Fixit.Core.DataContracts.Fixes.Schedule;
using Fixit.Core.DataContracts.Fixes.Tags;
using Fixit.Core.DataContracts.Seeders;
using Fixit.Core.DataContracts.Users;
using Fixit.Core.DataContracts.Users.Address;

namespace Fixit.Core.DataContracts.Fixes.Operations.Requests
{
  [DataContract]
  public class FixCreateRequestDto : OperationStatus, IFakeSeederAdapter<FixCreateRequestDto>
  {

    [DataMember]
    public IEnumerable<TagDto> Tags { get; set; }

    [DataMember]
    public FixDetailsDto Details { get; set; }

    [DataMember]
    public IEnumerable<FileDto> Images { get; set; }

    [DataMember]
    public AddressDto Location { get; set; }

    [DataMember]
    public IEnumerable<FixScheduleRangeDto> Schedule { get; set; }

    [DataMember]
    public UserSummaryDto CreatedByClient { get; set; }

    [DataMember]
    public UserSummaryDto UpdatedByUser { get; set; }

    [DataMember]
    public FixStatuses Status { get; set; }

    [DataMember]
    public FixCostRangeDto ClientEstimatedCost { get; set; }

    public IList<FixCreateRequestDto> SeedFakeDtos()
    {
      FixCreateRequestDto firstFixDocument = new FixCreateRequestDto
      {
        Details = new FixDetailsDto
          {
            Name = "Shower",
            Description = "Need to change shower",
            Category = "Bathroom",
            Type = "New"
          },
        Tags = new List<TagDto>
        {
          new TagDto
          {
            Id = new Guid("8b418766-4a99-42a8-b6d7-9fe52b88ea98"),
            Name = "Bathroom"
          },
          new TagDto
          {
            Id = new Guid("8b418766-4a99-42a8-b6d7-9fe52b88ea99"),
            Name = "Toilet"
          }
        },
        Images = new List<FileDto>
        {
          new FileDto
          {
            Name = "image-bathroom",
            Url = "/image.png"
          }

        },
        Location = new AddressDto
        {
        },
        Schedule = new List<FixScheduleRangeDto>
        {
          new FixScheduleRangeDto
          {
            EndTimestampUtc = 1609102412,
            StartTimestampUtc = 1609102532
          }

        },
        ClientEstimatedCost = new FixCostRangeDto
        {
          MaximumCost = 400,
          MinimumCost = 200
        },
        CreatedByClient = new UserSummaryDto
        {
          Id = new Guid("8b418766-4a99-42a8-b6d7-9fe52b88ea93"),
          FirstName = "Mary",
          LastName = "Lamb"
        },
        UpdatedByUser = new UserSummaryDto
        {
          Id = new Guid("8b418766-4a99-42a8-b6d7-9fe52b88ea93"),
          FirstName = "Mary",
          LastName = "Lamb"
        }
      };

      FixCreateRequestDto secondFixDocument = null;

      return new List<FixCreateRequestDto>
      {
        firstFixDocument,
        secondFixDocument
  };
    }
  }
}

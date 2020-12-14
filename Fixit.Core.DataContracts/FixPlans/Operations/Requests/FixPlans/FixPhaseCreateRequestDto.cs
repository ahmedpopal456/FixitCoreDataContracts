using System;
using System.Collections.Generic;
using System.Text;

namespace Fixit.Core.DataContracts.FixPlans.Operations.Requests.FixPlans
{
  class FixPhaseCreateRequestDto : ICreateRequestDto
  {
    public string Name { get; set; }
  }
}

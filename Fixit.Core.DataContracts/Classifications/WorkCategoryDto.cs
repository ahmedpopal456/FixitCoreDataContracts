using System;
using System.Collections.Generic;
using Fixit.Core.DataContracts.Seeders;
using Fixit.Core.DataContracts.Users.Skill;

namespace Fixit.Core.DataContracts.Classifications
{
	public class WorkCategoryDto : IFakeSeederAdapter<WorkCategoryDto>
	{
		public Guid Id { get; set; }

		public string Name { get; set; }

		public IEnumerable<UserLicenseDto> Skills { get; set; }

		#region Fake Seeder
		public IList<WorkCategoryDto> SeedFakeDtos()
		{
			return new List<WorkCategoryDto>
			{
				new WorkCategoryDto()
				{
					Id = new Guid("96371910-43e3-4621-98c2-2396cd663e0c"),
					Name = "Electricity"
				},
				new WorkCategoryDto()
				{
					Id = new Guid("51a1e09e-bf7e-48d1-ac51-538d6f1bb957"),
					Name = "Masonry"
				},
				new WorkCategoryDto()
				{
					Id = new Guid("211609c1-3584-4454-aa3d-60cb40d618be"),
					Name = "Plumbing",
				},
				new WorkCategoryDto()
				{
					Id = new Guid("b9860dba-01c8-4d2f-8256-703845c246ee"),
					Name = "Woodwork"
				}
			};
		}
		#endregion
	}
}

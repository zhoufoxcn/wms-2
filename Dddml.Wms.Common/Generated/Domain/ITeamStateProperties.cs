﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public interface ITeamStateProperties
	{
		string TeamName { get; set; }

		string Description { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

		ISet<PersonalName> Players { get; set; }

		ISet<string> Mascots { get; set; }

	}

}

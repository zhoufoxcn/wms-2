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

	public interface IMonthPlanMvoStateProperties
	{
		MonthPlanId MonthPlanId { get; set; }

		string Description { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

		string YearPlanDescription { get; set; }

		long YearPlanVersion { get; set; }

		string YearPlanCreatedBy { get; set; }

		DateTime YearPlanCreatedAt { get; set; }

		string YearPlanUpdatedBy { get; set; }

		DateTime YearPlanUpdatedAt { get; set; }

		bool YearPlanActive { get; set; }

		bool YearPlanDeleted { get; set; }

		DateTime PersonBirthDate { get; set; }

		PersonalName PersonLoves { get; set; }

		Contact PersonEmergencyContact { get; set; }

		long PersonVersion { get; set; }

		string PersonCreatedBy { get; set; }

		DateTime PersonCreatedAt { get; set; }

		string PersonUpdatedBy { get; set; }

		DateTime PersonUpdatedAt { get; set; }

		bool PersonActive { get; set; }

		bool PersonDeleted { get; set; }

	}

}
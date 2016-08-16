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
	public interface IYearPlanMvoStateEvent : IEvent, IStateEventDto, IGlobalIdentity<YearPlanMvoStateEventId>, ICreated<string>
	{
		YearPlanMvoStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string Description { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		DateTime? PersonBirthDate { get; set; }

		PersonalName PersonLoves { get; set; }

		string PersonCreatedBy { get; set; }

		DateTime? PersonCreatedAt { get; set; }

		string PersonUpdatedBy { get; set; }

		DateTime? PersonUpdatedAt { get; set; }

		bool? PersonActive { get; set; }

		bool? PersonDeleted { get; set; }

	}

	public interface IYearPlanMvoStateCreated : IYearPlanMvoStateEvent//, IYearPlanMvoStateProperties
	{
	
	}


	public interface IYearPlanMvoStateMergePatched : IYearPlanMvoStateEvent//, IYearPlanMvoStateProperties
	{
		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyPersonBirthDateRemoved { get; set; }

		bool IsPropertyPersonLovesRemoved { get; set; }

		bool IsPropertyPersonCreatedByRemoved { get; set; }

		bool IsPropertyPersonCreatedAtRemoved { get; set; }

		bool IsPropertyPersonUpdatedByRemoved { get; set; }

		bool IsPropertyPersonUpdatedAtRemoved { get; set; }

		bool IsPropertyPersonActiveRemoved { get; set; }

		bool IsPropertyPersonDeletedRemoved { get; set; }


	}

	public interface IYearPlanMvoStateDeleted : IYearPlanMvoStateEvent
	{
	}


}


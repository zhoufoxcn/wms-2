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
	public interface IDayPlanStateEvent : IEvent, IStateEventDto, IGlobalIdentity<DayPlanStateEventId>, ICreated<string>
	{
		DayPlanStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }

		// Outer Id:
		//PersonalName PersonalName { get; set; }

		// Outer Id:
		//int Year { get; set; }

		// Outer Id:
		//int Month { get; set; }

	}

	public interface IDayPlanStateCreated : IDayPlanStateEvent//, IDayPlanStateProperties
	{
	
	}


	public interface IDayPlanStateMergePatched : IDayPlanStateEvent//, IDayPlanStateProperties
	{
		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IDayPlanStateRemoved : IDayPlanStateEvent
	{
	}


}

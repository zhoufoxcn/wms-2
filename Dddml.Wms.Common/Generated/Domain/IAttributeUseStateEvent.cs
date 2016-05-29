﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{
	public interface IAttributeUseStateEvent : IEvent, IGlobalIdentity<AttributeUseStateEventId>, ICreated<string>
	{
		AttributeUseStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		int? SequenceNumber { get; set; }

		bool? Active { get; set; }

		// Outer Id:
		//string AttributeSetId { get; set; }


	}

	public interface IAttributeUseStateCreated : IAttributeUseStateEvent//, IAttributeUseStateProperties
	{
	
	}


	public interface IAttributeUseStateMergePatched : IAttributeUseStateEvent//, IAttributeUseStateProperties
	{
		bool IsPropertySequenceNumberRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}


	public interface IAttributeUseStateRemoved : IAttributeUseStateEvent
	{
	}


}


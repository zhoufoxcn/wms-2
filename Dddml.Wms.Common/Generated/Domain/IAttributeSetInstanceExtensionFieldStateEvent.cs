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
	public interface IAttributeSetInstanceExtensionFieldStateEvent : IEvent, IStateEventDto, IGlobalIdentity<AttributeSetInstanceExtensionFieldStateEventId>, ICreated<string>
	{
		AttributeSetInstanceExtensionFieldStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		string Name { get; set; }

		string Type { get; set; }

		int? Length { get; set; }

		string Alias { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }

		// Outer Id:
		//string GroupId { get; set; }

	}

	public interface IAttributeSetInstanceExtensionFieldStateCreated : IAttributeSetInstanceExtensionFieldStateEvent//, IAttributeSetInstanceExtensionFieldStateProperties
	{
	
	}


	public interface IAttributeSetInstanceExtensionFieldStateMergePatched : IAttributeSetInstanceExtensionFieldStateEvent//, IAttributeSetInstanceExtensionFieldStateProperties
	{
		bool IsPropertyNameRemoved { get; set; }

		bool IsPropertyTypeRemoved { get; set; }

		bool IsPropertyLengthRemoved { get; set; }

		bool IsPropertyAliasRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IAttributeSetInstanceExtensionFieldStateRemoved : IAttributeSetInstanceExtensionFieldStateEvent
	{
	}


}


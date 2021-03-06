﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{
	public interface IUserClaimStateEvent : IEvent, IStateEventDto, IGlobalIdentity<UserClaimStateEventId>, ICreated<string>
	{
		UserClaimStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		string ClaimType { get; set; }

		string ClaimValue { get; set; }

		bool? Active { get; set; }

		// Outer Id:
		//string UserId { get; set; }

	}

	public interface IUserClaimStateCreated : IUserClaimStateEvent//, IUserClaimStateProperties
	{
	
	}


	public interface IUserClaimStateMergePatched : IUserClaimStateEvent//, IUserClaimStateProperties
	{
		bool IsPropertyClaimTypeRemoved { get; set; }

		bool IsPropertyClaimValueRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IUserClaimStateRemoved : IUserClaimStateEvent
	{
	}


}


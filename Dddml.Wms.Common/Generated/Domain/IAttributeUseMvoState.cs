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
	public interface IAttributeUseMvoState : IAttributeUseMvoStateProperties, 
		IGlobalIdentity<AttributeSetAttributeUseId>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IVersioned<long>
	{

		void When(IAttributeUseMvoStateCreated e);

		void When(IAttributeUseMvoStateMergePatched e);

		void When(IAttributeUseMvoStateDeleted e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}
}


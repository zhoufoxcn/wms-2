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

	public partial interface IAttributeSetApplicationService : IApplicationService
	{
		void When(ICreateAttributeSet c);

		void When(IMergePatchAttributeSet c);

		void When(IDeleteAttributeSet c);

 		IAttributeSetState Get(string attributeSetId);

        IEnumerable<IAttributeSetState> GetAll(int firstResult, int maxResults);


	}

}

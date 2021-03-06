﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Organization;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Organization
{
	public partial interface IOrganizationStateQueryRepository
	{
        IOrganizationState Get(string id);

        IEnumerable<IOrganizationState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<IOrganizationState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IOrganizationState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IOrganizationState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IOrganizationState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IOrganizationState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}


﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain
{
	public partial interface IWarehouseStateQueryRepository
	{
        IWarehouseState Get(string id);

        IEnumerable<IWarehouseState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<IWarehouseState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IWarehouseState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IWarehouseState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IWarehouseState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IWarehouseState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}


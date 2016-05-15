﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.NHibernate
{

	public class NHibernateAttributeSetInstanceStateRepository : IAttributeSetInstanceStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

		public NHibernateAttributeSetInstanceStateRepository ()
		{
		}

		[Transaction (ReadOnly = true)]
		public IAttributeSetInstanceState Get (string id)
		{
			IAttributeSetInstanceState state = CurrentSession.Get<AttributeSetInstanceState> (id);
			if (state == null) {
				state = new AttributeSetInstanceState ();
				(state as AttributeSetInstanceState).AttributeSetInstanceId = id;
			}
			return state;
		}

        [Transaction(ReadOnly = true)]
        public IEnumerable<IAttributeSetInstanceState> GetAll(int firstResult, int maxResults)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceState>();
            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            return criteria.List<AttributeSetInstanceState>();
        }

		[Transaction]
		public void Save (IAttributeSetInstanceState state)
		{
			CurrentSession.SaveOrUpdate (state);

			var saveable = state as ISaveable;
			if (saveable != null) {
				saveable.Save ();
			}
		}
	}
}

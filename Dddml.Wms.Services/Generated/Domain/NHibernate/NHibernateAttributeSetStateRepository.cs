﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.NHibernate
{

	public partial class NHibernateAttributeSetStateRepository : IAttributeSetStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "AttributeSetId", "Name", "OrganizationId", "Description", "SerialNumberAttributeId", "LotAttributeId", "ReferenceId", "AttributeUses", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateAttributeSetStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public IAttributeSetState Get(string id, bool nullAllowed)
		{
			IAttributeSetState state = CurrentSession.Get<AttributeSetState> (id);
			if (!nullAllowed && state == null) {
				state = new AttributeSetState ();
				(state as AttributeSetState).AttributeSetId = id;
			}
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IAttributeSetState>(state, new Type[] { typeof(ISaveable) }, _readOnlyPropertyNames);
            }
			return state;
		}

		[Transaction]
		public void Save(IAttributeSetState state)
		{
            IAttributeSetState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IAttributeSetState>(state);
            }
			CurrentSession.SaveOrUpdate (s);

			var saveable = s as ISaveable;
			if (saveable != null) {
				saveable.Save ();
			}
		}

        //protected static void AddNotDeletedRestriction(ICriteria criteria)
        //{
        //    criteria.Add(NHibernateRestrictions.Eq("Deleted", false));
        //}

	}
}


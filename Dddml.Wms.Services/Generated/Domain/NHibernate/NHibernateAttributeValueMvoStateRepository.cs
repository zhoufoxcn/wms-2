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

	public partial class NHibernateAttributeValueMvoStateRepository : IAttributeValueMvoStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "AttributeValueId", "Name", "Description", "ReferenceId", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "AttributeName", "AttributeOrganizationId", "AttributeDescription", "AttributeIsMandatory", "AttributeIsInstanceAttribute", "AttributeAttributeValueType", "AttributeAttributeValueLength", "AttributeIsList", "AttributeFieldName", "AttributeReferenceId", "AttributeAttributeValues", "AttributeVersion", "AttributeCreatedBy", "AttributeCreatedAt", "AttributeUpdatedBy", "AttributeUpdatedAt", "AttributeActive", "AttributeDeleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateAttributeValueMvoStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public IAttributeValueMvoState Get(AttributeValueId id, bool nullAllowed)
		{
			IAttributeValueMvoState state = CurrentSession.Get<AttributeValueMvoState> (id);
			if (!nullAllowed && state == null) {
				state = new AttributeValueMvoState ();
				(state as AttributeValueMvoState).AttributeValueId = id;
			}
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IAttributeValueMvoState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
			return state;
		}

		[Transaction]
		public void Save(IAttributeValueMvoState state)
		{
            IAttributeValueMvoState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IAttributeValueMvoState>(state);
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


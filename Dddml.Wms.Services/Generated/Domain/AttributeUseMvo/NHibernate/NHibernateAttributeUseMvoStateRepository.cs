﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeUseMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeUseMvo;
using Dddml.Wms.Domain.AttributeSet;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.AttributeUseMvo.NHibernate
{

	public partial class NHibernateAttributeUseMvoStateRepository : IAttributeUseMvoStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "AttributeSetAttributeUseId", "SequenceNumber", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "AttributeSetName", "AttributeSetOrganizationId", "AttributeSetDescription", "AttributeSetSerialNumberAttributeId", "AttributeSetLotAttributeId", "AttributeSetReferenceId", "AttributeSetAttributeUses", "AttributeSetVersion", "AttributeSetCreatedBy", "AttributeSetCreatedAt", "AttributeSetUpdatedBy", "AttributeSetUpdatedAt", "AttributeSetActive", "AttributeSetDeleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateAttributeUseMvoStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public IAttributeUseMvoState Get(AttributeSetAttributeUseId id, bool nullAllowed)
		{
			IAttributeUseMvoState state = CurrentSession.Get<AttributeUseMvoState> (id);
			if (!nullAllowed && state == null) {
				state = new AttributeUseMvoState ();
				(state as AttributeUseMvoState).AttributeSetAttributeUseId = id;
			}
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IAttributeUseMvoState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
			return state;
		}

		[Transaction]
		public void Save(IAttributeUseMvoState state)
		{
            IAttributeUseMvoState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IAttributeUseMvoState>(state);
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


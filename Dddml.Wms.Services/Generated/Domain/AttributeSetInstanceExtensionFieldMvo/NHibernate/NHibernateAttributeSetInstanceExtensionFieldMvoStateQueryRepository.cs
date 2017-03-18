﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldMvo;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldMvo.NHibernate
{

	public partial class NHibernateAttributeSetInstanceExtensionFieldMvoStateQueryRepository : IAttributeSetInstanceExtensionFieldMvoStateQueryRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "AttributeSetInstanceExtensionFieldId", "Name", "Type", "Length", "Alias", "Description", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "AttrSetInstEFGroupFieldType", "AttrSetInstEFGroupFieldLength", "AttrSetInstEFGroupFieldCount", "AttrSetInstEFGroupNameFormat", "AttrSetInstEFGroupDescription", "AttrSetInstEFGroupFields", "AttrSetInstEFGroupVersion", "AttrSetInstEFGroupCreatedBy", "AttrSetInstEFGroupCreatedAt", "AttrSetInstEFGroupUpdatedBy", "AttrSetInstEFGroupUpdatedAt", "AttrSetInstEFGroupActive", "AttrSetInstEFGroupDeleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateAttributeSetInstanceExtensionFieldMvoStateQueryRepository ()
		{
		}

		[Transaction (ReadOnly = true)]
		public IAttributeSetInstanceExtensionFieldMvoState Get(AttributeSetInstanceExtensionFieldId id)
		{
			IAttributeSetInstanceExtensionFieldMvoState state = CurrentSession.Get<AttributeSetInstanceExtensionFieldMvoState>(id);
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IAttributeSetInstanceExtensionFieldMvoState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
			return state;
		}

        [Transaction(ReadOnly = true)]
        public IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> GetAll(int firstResult, int maxResults)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldMvoState>();
            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<AttributeSetInstanceExtensionFieldMvoState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldMvoState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<AttributeSetInstanceExtensionFieldMvoState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> Get(Dddml.Support.Criterion.ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldMvoState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<AttributeSetInstanceExtensionFieldMvoState>();
        }


        [Transaction(ReadOnly = true)]
        public virtual IAttributeSetInstanceExtensionFieldMvoState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null)
        {
            var list = (IList<AttributeSetInstanceExtensionFieldMvoState>)Get(filter, orders, 0, 1);
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            return list[0];
        }

        [Transaction(ReadOnly = true)]
        public virtual IAttributeSetInstanceExtensionFieldMvoState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null)
        {
            return GetFirst(new KeyValuePair<string, object>[] { keyValue }, orders);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var filter = new KeyValuePair<string, object>[] { new KeyValuePair<string, object>(propertyName, propertyValue) };
            return Get(filter, orders, firstResult, maxResults);
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldMvoState>();
            criteria.SetProjection(Projections.RowCountInt64());
            NHibernateUtils.CriteriaAddFilter(criteria, filter);
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(Dddml.Support.Criterion.ICriterion filter)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldMvoState>();
            criteria.SetProjection(Projections.RowCountInt64());
            if (filter != null)
            {
                NHibernateICriterion hc = CriterionUtils.ToNHibernateCriterion(filter);
                criteria.Add(hc);
            }
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }


        protected static void AddNotDeletedRestriction(ICriteria criteria)
        {
            criteria.Add(NHibernateRestrictions.Eq("Deleted", false));
        }

	}
}

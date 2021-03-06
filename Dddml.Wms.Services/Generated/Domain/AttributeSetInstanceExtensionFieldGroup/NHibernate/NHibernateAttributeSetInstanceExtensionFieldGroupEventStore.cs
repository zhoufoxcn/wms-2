﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldGroupDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup.NHibernate
{

	public class NHibernateAttributeSetInstanceExtensionFieldGroupEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new AttributeSetInstanceExtensionFieldGroupStateEventId((string)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(AttributeSetInstanceExtensionFieldGroupStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(AttributeSetInstanceExtensionFieldGroupStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            string idObj = (string)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldGroupStateEventBase>();
            criteria.Add(Restrictions.Eq("StateEventId.Id", idObj));
            criteria.Add(Restrictions.Le("StateEventId.Version", version));
            criteria.AddOrder(Order.Asc("StateEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (AttributeSetInstanceExtensionFieldGroupStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((AttributeSetInstanceExtensionFieldGroupStateEventBase)es.Last()).StateEventId.Version : default(long),
                Events = es
            };
        }

	}

}


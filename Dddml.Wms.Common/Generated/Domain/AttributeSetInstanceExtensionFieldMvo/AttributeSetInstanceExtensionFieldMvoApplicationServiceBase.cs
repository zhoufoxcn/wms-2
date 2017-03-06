﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldMvo;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldMvo
{
	public abstract partial class AttributeSetInstanceExtensionFieldMvoApplicationServiceBase : IAttributeSetInstanceExtensionFieldMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IAttributeSetInstanceExtensionFieldMvoStateRepository StateRepository { get; }

		protected abstract IAttributeSetInstanceExtensionFieldMvoStateQueryRepository StateQueryRepository { get; }

		protected AttributeSetInstanceExtensionFieldMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IAttributeSetInstanceExtensionFieldMvoCommand c, Action<IAttributeSetInstanceExtensionFieldMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetAttributeSetInstanceExtensionFieldMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			EventStore.AppendEvents(eventStoreAggregateId, ((IAttributeSetInstanceExtensionFieldMvoStateProperties)state).AttrSetInstEFGroupVersion, aggregate.Changes, () => { StateRepository.Save(state); });
		}


		protected bool IsRepeatedCommand(IAttributeSetInstanceExtensionFieldMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IAttributeSetInstanceExtensionFieldMvoState state)
		{
			bool repeated = false;
			if (((IAttributeSetInstanceExtensionFieldMvoStateProperties)state).AttrSetInstEFGroupVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IAttributeSetInstanceExtensionFieldMvoStateEvent), eventStoreAggregateId, command.AggregateVersion);
				if (lastEvent != null && lastEvent.CommandId == command.CommandId)
				{
					repeated = true;
				}
			}
			return repeated;
		}


		public virtual void Execute(object command)
		{
			((dynamic)this).When((dynamic)command);
		}


		public virtual void When(ICreateAttributeSetInstanceExtensionFieldMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchAttributeSetInstanceExtensionFieldMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteAttributeSetInstanceExtensionFieldMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IAttributeSetInstanceExtensionFieldMvoState Get(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId)
        {
            var state = StateRepository.Get(attributeSetInstanceExtensionFieldId, true);
            return state;
        }

        public virtual IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var states = StateQueryRepository.GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
			return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
            return StateQueryRepository.GetCount(filter);
		}

        public virtual long GetCount(ICriterion filter)
		{
            return StateQueryRepository.GetCount(filter);
		}

	    public virtual IAttributeSetInstanceExtensionFieldMvoStateEvent GetStateEvent(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId, long version)
        {
            var e = (IAttributeSetInstanceExtensionFieldMvoStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(attributeSetInstanceExtensionFieldId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(attributeSetInstanceExtensionFieldId, 0);
            }
            return e;
        }

        public virtual IAttributeSetInstanceExtensionFieldMvoState GetHistoryState(AttributeSetInstanceExtensionFieldId attributeSetInstanceExtensionFieldId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IAttributeSetInstanceExtensionFieldMvoStateEvent), ToEventStoreAggregateId(attributeSetInstanceExtensionFieldId), version - 1);
            return new AttributeSetInstanceExtensionFieldMvoState(eventStream.Events);
        }


		public abstract IAttributeSetInstanceExtensionFieldMvoAggregate GetAttributeSetInstanceExtensionFieldMvoAggregate(IAttributeSetInstanceExtensionFieldMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(AttributeSetInstanceExtensionFieldId aggregateId);


	}

}

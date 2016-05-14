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

    public partial class AttributeSetInstanceAggregate : IAttributeSetInstanceAggregate
    {

        readonly IAttributeSetInstanceState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IAttributeSetInstanceState State
        {
            get
            {
                return _state;
            }
        }

        public IList<IEvent> Changes
        {
            get
            {
                return _changes;
            }
        }

        #region IIdentity implementation

        string IGlobalIdentity<string>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public AttributeSetInstanceAggregate(IAttributeSetInstanceState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (_state.Version == AttributeSetInstanceState.VersionZero)
            {
                if (c is ICreateAttributeSetInstance)
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (c is ICreateAttributeSetInstance)
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        protected virtual void Apply(IEvent e)
        {
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateAttributeSetInstance c)
        {
            IAttributeSetInstanceStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchAttributeSetInstance c)
        {
            IAttributeSetInstanceStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteAttributeSetInstance c)
        {
            IAttributeSetInstanceStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IAttributeSetInstanceStateCreated Map(ICreateAttributeSetInstance c)
        {
			var stateEventId = new AttributeSetInstanceStateEventId(c.AttributeSetInstanceId, c.Version);
            IAttributeSetInstanceStateCreated e = NewAttributeSetInstanceStateCreated(stateEventId);
		
            ReflectUtils.CopyPropertyValue("AttributeSetId", c, e);

            ReflectUtils.CopyPropertyValue("SerialNumber", c, e);

            ReflectUtils.CopyPropertyValue("Lot", c, e);

            ReflectUtils.CopyPropertyValue("Description", c, e);

            ReflectUtils.CopyPropertyValue("Active", c, e);

            ReflectUtils.CopyPropertyValue("CommandId", c, e);//TODO CommandId 太特殊了！！！


            (e as AttributeSetInstanceStateEventBase).CreatedBy = (string)c.RequesterId;//TODO RequestId 是不是太特殊了？？？
            (e as AttributeSetInstanceStateEventBase).CreatedAt = DateTime.Now;
			var attributeSetInstanceVersion = c.Version;


            return e;
        }

        protected virtual IAttributeSetInstanceStateMergePatched Map(IMergePatchAttributeSetInstance c)
        {
			var stateEventId = new AttributeSetInstanceStateEventId(c.AttributeSetInstanceId, c.Version);
            IAttributeSetInstanceStateMergePatched e = NewAttributeSetInstanceStateMergePatched(stateEventId);

            ReflectUtils.CopyPropertyValue("AttributeSetId", c, e);

            ReflectUtils.CopyPropertyValue("SerialNumber", c, e);

            ReflectUtils.CopyPropertyValue("Lot", c, e);

            ReflectUtils.CopyPropertyValue("Description", c, e);

            ReflectUtils.CopyPropertyValue("Active", c, e);

            ReflectUtils.CopyPropertyValue("IsPropertyAttributeSetIdRemoved", c, e);

            ReflectUtils.CopyPropertyValue("IsPropertySerialNumberRemoved", c, e);

            ReflectUtils.CopyPropertyValue("IsPropertyLotRemoved", c, e);

            ReflectUtils.CopyPropertyValue("IsPropertyDescriptionRemoved", c, e);

            ReflectUtils.CopyPropertyValue("IsPropertyActiveRemoved", c, e);


            ReflectUtils.CopyPropertyValue("CommandId", c, e);//TODO CommandId 太特殊了！！！


            (e as AttributeSetInstanceStateEventBase).CreatedBy = (string)c.RequesterId;//TODO RequestId 是不是太特殊了？？？
            (e as AttributeSetInstanceStateEventBase).CreatedAt = DateTime.Now;

			var attributeSetInstanceVersion = c.Version;


            return e;
        }

        protected virtual IAttributeSetInstanceStateDeleted Map(IDeleteAttributeSetInstance c)
        {
			var stateEventId = new AttributeSetInstanceStateEventId(c.AttributeSetInstanceId, c.Version);
            IAttributeSetInstanceStateDeleted e = NewAttributeSetInstanceStateDeleted(stateEventId);
			
            ReflectUtils.CopyPropertyValue("CommandId", c, e);//TODO CommandId 太特殊了！！！


            (e as AttributeSetInstanceStateEventBase).CreatedBy = (string)c.RequesterId;//TODO RequestId 是不是太特殊了？？？
            (e as AttributeSetInstanceStateEventBase).CreatedAt = DateTime.Now;


            return e;
        }


        private void SetNullInnerIdOrThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (innerIdValue == null)
            {
                ReflectUtils.SetPropertyValue(innerIdName, innerObject, outerIdValue);
            }
            else if (innerIdValue != outerIdValue)
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected AttributeSetInstanceStateCreated NewAttributeSetInstanceStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new AttributeSetInstanceStateEventId(this._state.AttributeSetInstanceId, this._state.Version);
            var e = NewAttributeSetInstanceStateCreated(stateEventId);

            e.CommandId = commandId;

            (e as AttributeSetInstanceStateEventBase).CreatedBy = (string)requesterId;//TODO RequestId 是不是太特殊了？？？
            (e as AttributeSetInstanceStateEventBase).CreatedAt = DateTime.Now;

            return e;
        }

        protected AttributeSetInstanceStateMergePatched NewAttributeSetInstanceStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new AttributeSetInstanceStateEventId(this._state.AttributeSetInstanceId, this._state.Version);
            var e = NewAttributeSetInstanceStateMergePatched(stateEventId);

            e.CommandId = commandId;

            (e as AttributeSetInstanceStateEventBase).CreatedBy = (string)requesterId;//TODO RequestId 是不是太特殊了？？？
            (e as AttributeSetInstanceStateEventBase).CreatedAt = DateTime.Now;

            return e;
        }


        protected AttributeSetInstanceStateDeleted NewAttributeSetInstanceStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new AttributeSetInstanceStateEventId(this._state.AttributeSetInstanceId, this._state.Version);
            var e = NewAttributeSetInstanceStateDeleted(stateEventId);

            e.CommandId = commandId;

            (e as AttributeSetInstanceStateEventBase).CreatedBy = (string)requesterId;//TODO RequestId 是不是太特殊了？？？
            (e as AttributeSetInstanceStateEventBase).CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private AttributeSetInstanceStateCreated NewAttributeSetInstanceStateCreated(AttributeSetInstanceStateEventId stateEventId)
		{
			return new AttributeSetInstanceStateCreated(stateEventId);			
		}

        private AttributeSetInstanceStateMergePatched NewAttributeSetInstanceStateMergePatched(AttributeSetInstanceStateEventId stateEventId)
		{
			return new AttributeSetInstanceStateMergePatched(stateEventId);
		}

        private AttributeSetInstanceStateDeleted NewAttributeSetInstanceStateDeleted(AttributeSetInstanceStateEventId stateEventId)
		{
			return new AttributeSetInstanceStateDeleted(stateEventId);
		}


    }

}


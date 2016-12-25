﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{
    public partial class OrganizationStructureTypeAggregate : AggregateBase, IOrganizationStructureTypeAggregate
    {

        readonly IOrganizationStructureTypeState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IOrganizationStructureTypeState State
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


        public OrganizationStructureTypeAggregate(IOrganizationStructureTypeState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IOrganizationStructureTypeStateProperties)_state).Version == OrganizationStructureTypeState.VersionZero)
            {
                if (IsCommandCreate((IOrganizationStructureTypeCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IOrganizationStructureTypeCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IOrganizationStructureTypeCommand c)
        {
            return c.Version == OrganizationStructureTypeState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateOrganizationStructureType c)
        {
            IOrganizationStructureTypeStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchOrganizationStructureType c)
        {
            IOrganizationStructureTypeStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteOrganizationStructureType c)
        {
            IOrganizationStructureTypeStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IOrganizationStructureTypeStateCreated Map(ICreateOrganizationStructureType c)
        {
			var stateEventId = new OrganizationStructureTypeStateEventId(c.Id, c.Version);
            IOrganizationStructureTypeStateCreated e = NewOrganizationStructureTypeStateCreated(stateEventId);
		
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var version = c.Version;


            return e;
        }

        protected virtual IOrganizationStructureTypeStateMergePatched Map(IMergePatchOrganizationStructureType c)
        {
			var stateEventId = new OrganizationStructureTypeStateEventId(c.Id, c.Version);
            IOrganizationStructureTypeStateMergePatched e = NewOrganizationStructureTypeStateMergePatched(stateEventId);

            e.Active = c.Active;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var version = c.Version;


            return e;
        }

        protected virtual IOrganizationStructureTypeStateDeleted Map(IDeleteOrganizationStructureType c)
        {
			var stateEventId = new OrganizationStructureTypeStateEventId(c.Id, c.Version);
            IOrganizationStructureTypeStateDeleted e = NewOrganizationStructureTypeStateDeleted(stateEventId);
			
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;


            return e;
        }

        private void ThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected OrganizationStructureTypeStateCreated NewOrganizationStructureTypeStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new OrganizationStructureTypeStateEventId(_state.Id, ((IOrganizationStructureTypeStateProperties)_state).Version);
            var e = NewOrganizationStructureTypeStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected OrganizationStructureTypeStateMergePatched NewOrganizationStructureTypeStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new OrganizationStructureTypeStateEventId(_state.Id, ((IOrganizationStructureTypeStateProperties)_state).Version);
            var e = NewOrganizationStructureTypeStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected OrganizationStructureTypeStateDeleted NewOrganizationStructureTypeStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new OrganizationStructureTypeStateEventId(_state.Id, ((IOrganizationStructureTypeStateProperties)_state).Version);
            var e = NewOrganizationStructureTypeStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private OrganizationStructureTypeStateCreated NewOrganizationStructureTypeStateCreated(OrganizationStructureTypeStateEventId stateEventId)
		{
			return new OrganizationStructureTypeStateCreated(stateEventId);			
		}

        private OrganizationStructureTypeStateMergePatched NewOrganizationStructureTypeStateMergePatched(OrganizationStructureTypeStateEventId stateEventId)
		{
			return new OrganizationStructureTypeStateMergePatched(stateEventId);
		}

        private OrganizationStructureTypeStateDeleted NewOrganizationStructureTypeStateDeleted(OrganizationStructureTypeStateEventId stateEventId)
		{
			return new OrganizationStructureTypeStateDeleted(stateEventId);
		}

    }

}


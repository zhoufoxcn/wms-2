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
    public partial class RoleAggregate : AggregateBase, IRoleAggregate
    {

        readonly IRoleState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IRoleState State
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


        public RoleAggregate(IRoleState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IRoleStateProperties)_state).Version == RoleState.VersionZero)
            {
                if (IsCommandCreate((IRoleCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IRoleCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IRoleCommand c)
        {
            return c.Version == RoleState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            BeforeApply(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateRole c)
        {
            IRoleStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchRole c)
        {
            IRoleStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteRole c)
        {
            IRoleStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IRoleStateCreated Map(ICreateRole c)
        {
			var stateEventId = new RoleStateEventId(c.RoleId, c.Version);
            IRoleStateCreated e = NewRoleStateCreated(stateEventId);
		
            e.Name = c.Name;
            e.Description = c.Description;
            e.Active = c.Active;
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var version = c.Version;


            return e;
        }

        protected virtual IRoleStateMergePatched Map(IMergePatchRole c)
        {
			var stateEventId = new RoleStateEventId(c.RoleId, c.Version);
            IRoleStateMergePatched e = NewRoleStateMergePatched(stateEventId);

            e.Name = c.Name;
            e.Description = c.Description;
            e.Active = c.Active;
            e.IsPropertyNameRemoved = c.IsPropertyNameRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var version = c.Version;


            return e;
        }

        protected virtual IRoleStateDeleted Map(IDeleteRole c)
        {
			var stateEventId = new RoleStateEventId(c.RoleId, c.Version);
            IRoleStateDeleted e = NewRoleStateDeleted(stateEventId);
			
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;


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

        protected RoleStateCreated NewRoleStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new RoleStateEventId(_state.RoleId, ((IRoleStateProperties)_state).Version);
            var e = NewRoleStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected RoleStateMergePatched NewRoleStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new RoleStateEventId(_state.RoleId, ((IRoleStateProperties)_state).Version);
            var e = NewRoleStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected RoleStateDeleted NewRoleStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new RoleStateEventId(_state.RoleId, ((IRoleStateProperties)_state).Version);
            var e = NewRoleStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private RoleStateCreated NewRoleStateCreated(RoleStateEventId stateEventId)
		{
			return new RoleStateCreated(stateEventId);			
		}

        private RoleStateMergePatched NewRoleStateMergePatched(RoleStateEventId stateEventId)
		{
			return new RoleStateMergePatched(stateEventId);
		}

        private RoleStateDeleted NewRoleStateDeleted(RoleStateEventId stateEventId)
		{
			return new RoleStateDeleted(stateEventId);
		}


    }

}


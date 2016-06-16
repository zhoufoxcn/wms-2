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
    public partial class UserRoleAggregate : AggregateBase, IUserRoleAggregate
    {

        readonly IUserRoleState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IUserRoleState State
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

        UserRoleId IGlobalIdentity<UserRoleId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public UserRoleAggregate(IUserRoleState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IUserRoleStateProperties)_state).Version == UserRoleState.VersionZero)
            {
                if (IsCommandCreate((IUserRoleCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IUserRoleCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IUserRoleCommand c)
        {
            return c.Version == UserRoleState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            BeforeApply(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateUserRole c)
        {
            IUserRoleStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchUserRole c)
        {
            IUserRoleStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteUserRole c)
        {
            IUserRoleStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IUserRoleStateCreated Map(ICreateUserRole c)
        {
			var stateEventId = new UserRoleStateEventId(c.Id, c.Version);
            IUserRoleStateCreated e = NewUserRoleStateCreated(stateEventId);
		
            e.Active = c.Active;
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var version = c.Version;


            return e;
        }

        protected virtual IUserRoleStateMergePatched Map(IMergePatchUserRole c)
        {
			var stateEventId = new UserRoleStateEventId(c.Id, c.Version);
            IUserRoleStateMergePatched e = NewUserRoleStateMergePatched(stateEventId);

            e.Active = c.Active;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var version = c.Version;


            return e;
        }

        protected virtual IUserRoleStateDeleted Map(IDeleteUserRole c)
        {
			var stateEventId = new UserRoleStateEventId(c.Id, c.Version);
            IUserRoleStateDeleted e = NewUserRoleStateDeleted(stateEventId);
			
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

        protected UserRoleStateCreated NewUserRoleStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new UserRoleStateEventId(_state.Id, ((IUserRoleStateProperties)_state).Version);
            var e = NewUserRoleStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected UserRoleStateMergePatched NewUserRoleStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new UserRoleStateEventId(_state.Id, ((IUserRoleStateProperties)_state).Version);
            var e = NewUserRoleStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected UserRoleStateDeleted NewUserRoleStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new UserRoleStateEventId(_state.Id, ((IUserRoleStateProperties)_state).Version);
            var e = NewUserRoleStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private UserRoleStateCreated NewUserRoleStateCreated(UserRoleStateEventId stateEventId)
		{
			return new UserRoleStateCreated(stateEventId);			
		}

        private UserRoleStateMergePatched NewUserRoleStateMergePatched(UserRoleStateEventId stateEventId)
		{
			return new UserRoleStateMergePatched(stateEventId);
		}

        private UserRoleStateDeleted NewUserRoleStateDeleted(UserRoleStateEventId stateEventId)
		{
			return new UserRoleStateDeleted(stateEventId);
		}


    }

}


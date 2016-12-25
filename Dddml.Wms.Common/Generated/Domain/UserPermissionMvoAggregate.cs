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
    public partial class UserPermissionMvoAggregate : AggregateBase, IUserPermissionMvoAggregate
    {

        readonly IUserPermissionMvoState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IUserPermissionMvoState State
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

        UserPermissionId IGlobalIdentity<UserPermissionId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public UserPermissionMvoAggregate(IUserPermissionMvoState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IUserPermissionMvoStateProperties)_state).UserVersion == UserPermissionMvoState.VersionZero)
            {
                if (IsCommandCreate((IUserPermissionMvoCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IUserPermissionMvoCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IUserPermissionMvoCommand c)
        {
            return c.UserVersion == UserPermissionMvoState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateUserPermissionMvo c)
        {
            IUserPermissionMvoStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchUserPermissionMvo c)
        {
            IUserPermissionMvoStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteUserPermissionMvo c)
        {
            IUserPermissionMvoStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IUserPermissionMvoStateCreated Map(ICreateUserPermissionMvo c)
        {
			var stateEventId = new UserPermissionMvoStateEventId(c.UserPermissionId, c.UserVersion);
            IUserPermissionMvoStateCreated e = NewUserPermissionMvoStateCreated(stateEventId);
		
            e.Version = c.Version;
            e.Active = c.Active;
            e.UserUserName = c.UserUserName;
            e.UserAccessFailedCount = c.UserAccessFailedCount;
            e.UserEmail = c.UserEmail;
            e.UserEmailConfirmed = c.UserEmailConfirmed;
            e.UserLockoutEnabled = c.UserLockoutEnabled;
            e.UserLockoutEndDateUtc = c.UserLockoutEndDateUtc;
            e.UserPasswordHash = c.UserPasswordHash;
            e.UserPhoneNumber = c.UserPhoneNumber;
            e.UserPhoneNumberConfirmed = c.UserPhoneNumberConfirmed;
            e.UserTwoFactorEnabled = c.UserTwoFactorEnabled;
            e.UserSecurityStamp = c.UserSecurityStamp;
            e.UserCreatedBy = c.UserCreatedBy;
            e.UserCreatedAt = c.UserCreatedAt;
            e.UserUpdatedBy = c.UserUpdatedBy;
            e.UserUpdatedAt = c.UserUpdatedAt;
            e.UserActive = c.UserActive;
            e.UserDeleted = c.UserDeleted;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var userVersion = c.UserVersion;


            return e;
        }

        protected virtual IUserPermissionMvoStateMergePatched Map(IMergePatchUserPermissionMvo c)
        {
			var stateEventId = new UserPermissionMvoStateEventId(c.UserPermissionId, c.UserVersion);
            IUserPermissionMvoStateMergePatched e = NewUserPermissionMvoStateMergePatched(stateEventId);

            e.Version = c.Version;
            e.Active = c.Active;
            e.UserUserName = c.UserUserName;
            e.UserAccessFailedCount = c.UserAccessFailedCount;
            e.UserEmail = c.UserEmail;
            e.UserEmailConfirmed = c.UserEmailConfirmed;
            e.UserLockoutEnabled = c.UserLockoutEnabled;
            e.UserLockoutEndDateUtc = c.UserLockoutEndDateUtc;
            e.UserPasswordHash = c.UserPasswordHash;
            e.UserPhoneNumber = c.UserPhoneNumber;
            e.UserPhoneNumberConfirmed = c.UserPhoneNumberConfirmed;
            e.UserTwoFactorEnabled = c.UserTwoFactorEnabled;
            e.UserSecurityStamp = c.UserSecurityStamp;
            e.UserCreatedBy = c.UserCreatedBy;
            e.UserCreatedAt = c.UserCreatedAt;
            e.UserUpdatedBy = c.UserUpdatedBy;
            e.UserUpdatedAt = c.UserUpdatedAt;
            e.UserActive = c.UserActive;
            e.UserDeleted = c.UserDeleted;
            e.IsPropertyVersionRemoved = c.IsPropertyVersionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;
            e.IsPropertyUserUserNameRemoved = c.IsPropertyUserUserNameRemoved;
            e.IsPropertyUserAccessFailedCountRemoved = c.IsPropertyUserAccessFailedCountRemoved;
            e.IsPropertyUserEmailRemoved = c.IsPropertyUserEmailRemoved;
            e.IsPropertyUserEmailConfirmedRemoved = c.IsPropertyUserEmailConfirmedRemoved;
            e.IsPropertyUserLockoutEnabledRemoved = c.IsPropertyUserLockoutEnabledRemoved;
            e.IsPropertyUserLockoutEndDateUtcRemoved = c.IsPropertyUserLockoutEndDateUtcRemoved;
            e.IsPropertyUserPasswordHashRemoved = c.IsPropertyUserPasswordHashRemoved;
            e.IsPropertyUserPhoneNumberRemoved = c.IsPropertyUserPhoneNumberRemoved;
            e.IsPropertyUserPhoneNumberConfirmedRemoved = c.IsPropertyUserPhoneNumberConfirmedRemoved;
            e.IsPropertyUserTwoFactorEnabledRemoved = c.IsPropertyUserTwoFactorEnabledRemoved;
            e.IsPropertyUserSecurityStampRemoved = c.IsPropertyUserSecurityStampRemoved;
            e.IsPropertyUserCreatedByRemoved = c.IsPropertyUserCreatedByRemoved;
            e.IsPropertyUserCreatedAtRemoved = c.IsPropertyUserCreatedAtRemoved;
            e.IsPropertyUserUpdatedByRemoved = c.IsPropertyUserUpdatedByRemoved;
            e.IsPropertyUserUpdatedAtRemoved = c.IsPropertyUserUpdatedAtRemoved;
            e.IsPropertyUserActiveRemoved = c.IsPropertyUserActiveRemoved;
            e.IsPropertyUserDeletedRemoved = c.IsPropertyUserDeletedRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var userVersion = c.UserVersion;


            return e;
        }

        protected virtual IUserPermissionMvoStateDeleted Map(IDeleteUserPermissionMvo c)
        {
			var stateEventId = new UserPermissionMvoStateEventId(c.UserPermissionId, c.UserVersion);
            IUserPermissionMvoStateDeleted e = NewUserPermissionMvoStateDeleted(stateEventId);
			
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

        protected UserPermissionMvoStateCreated NewUserPermissionMvoStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new UserPermissionMvoStateEventId(_state.UserPermissionId, ((IUserPermissionMvoStateProperties)_state).UserVersion);
            var e = NewUserPermissionMvoStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected UserPermissionMvoStateMergePatched NewUserPermissionMvoStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new UserPermissionMvoStateEventId(_state.UserPermissionId, ((IUserPermissionMvoStateProperties)_state).UserVersion);
            var e = NewUserPermissionMvoStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected UserPermissionMvoStateDeleted NewUserPermissionMvoStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new UserPermissionMvoStateEventId(_state.UserPermissionId, ((IUserPermissionMvoStateProperties)_state).UserVersion);
            var e = NewUserPermissionMvoStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private UserPermissionMvoStateCreated NewUserPermissionMvoStateCreated(UserPermissionMvoStateEventId stateEventId)
		{
			return new UserPermissionMvoStateCreated(stateEventId);			
		}

        private UserPermissionMvoStateMergePatched NewUserPermissionMvoStateMergePatched(UserPermissionMvoStateEventId stateEventId)
		{
			return new UserPermissionMvoStateMergePatched(stateEventId);
		}

        private UserPermissionMvoStateDeleted NewUserPermissionMvoStateDeleted(UserPermissionMvoStateEventId stateEventId)
		{
			return new UserPermissionMvoStateDeleted(stateEventId);
		}

    }

}


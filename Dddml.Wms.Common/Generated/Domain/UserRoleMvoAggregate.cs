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
    public partial class UserRoleMvoAggregate : AggregateBase, IUserRoleMvoAggregate
    {

        readonly IUserRoleMvoState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IUserRoleMvoState State
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


        public UserRoleMvoAggregate(IUserRoleMvoState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IUserRoleMvoStateProperties)_state).UserVersion == UserRoleMvoState.VersionZero)
            {
                if (IsCommandCreate((IUserRoleMvoCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IUserRoleMvoCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IUserRoleMvoCommand c)
        {
            return c.UserVersion == UserRoleMvoState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateUserRoleMvo c)
        {
            IUserRoleMvoStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchUserRoleMvo c)
        {
            IUserRoleMvoStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteUserRoleMvo c)
        {
            IUserRoleMvoStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IUserRoleMvoStateCreated Map(ICreateUserRoleMvo c)
        {
			var stateEventId = new UserRoleMvoStateEventId(c.UserRoleId, c.UserVersion);
            IUserRoleMvoStateCreated e = NewUserRoleMvoStateCreated(stateEventId);
		
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
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var userVersion = c.UserVersion;


            return e;
        }

        protected virtual IUserRoleMvoStateMergePatched Map(IMergePatchUserRoleMvo c)
        {
			var stateEventId = new UserRoleMvoStateEventId(c.UserRoleId, c.UserVersion);
            IUserRoleMvoStateMergePatched e = NewUserRoleMvoStateMergePatched(stateEventId);

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

            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var userVersion = c.UserVersion;


            return e;
        }

        protected virtual IUserRoleMvoStateDeleted Map(IDeleteUserRoleMvo c)
        {
			var stateEventId = new UserRoleMvoStateEventId(c.UserRoleId, c.UserVersion);
            IUserRoleMvoStateDeleted e = NewUserRoleMvoStateDeleted(stateEventId);
			
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

        protected UserRoleMvoStateCreated NewUserRoleMvoStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new UserRoleMvoStateEventId(_state.UserRoleId, ((IUserRoleMvoStateProperties)_state).UserVersion);
            var e = NewUserRoleMvoStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected UserRoleMvoStateMergePatched NewUserRoleMvoStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new UserRoleMvoStateEventId(_state.UserRoleId, ((IUserRoleMvoStateProperties)_state).UserVersion);
            var e = NewUserRoleMvoStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected UserRoleMvoStateDeleted NewUserRoleMvoStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new UserRoleMvoStateEventId(_state.UserRoleId, ((IUserRoleMvoStateProperties)_state).UserVersion);
            var e = NewUserRoleMvoStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private UserRoleMvoStateCreated NewUserRoleMvoStateCreated(UserRoleMvoStateEventId stateEventId)
		{
			return new UserRoleMvoStateCreated(stateEventId);			
		}

        private UserRoleMvoStateMergePatched NewUserRoleMvoStateMergePatched(UserRoleMvoStateEventId stateEventId)
		{
			return new UserRoleMvoStateMergePatched(stateEventId);
		}

        private UserRoleMvoStateDeleted NewUserRoleMvoStateDeleted(UserRoleMvoStateEventId stateEventId)
		{
			return new UserRoleMvoStateDeleted(stateEventId);
		}


    }

}

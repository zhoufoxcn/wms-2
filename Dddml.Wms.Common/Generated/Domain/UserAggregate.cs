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
    public partial class UserAggregate : AggregateBase, IUserAggregate
    {

        readonly IUserState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IUserState State
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


        public UserAggregate(IUserState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IUserStateProperties)_state).Version == UserState.VersionZero)
            {
                if (IsCommandCreate((IUserCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IUserCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IUserCommand c)
        {
            return c.Version == UserState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            BeforeApply(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateUser c)
        {
            IUserStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchUser c)
        {
            IUserStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteUser c)
        {
            IUserStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IUserStateCreated Map(ICreateUser c)
        {
			var stateEventId = new UserStateEventId(c.UserId, c.Version);
            IUserStateCreated e = NewUserStateCreated(stateEventId);
		
            e.UserName = c.UserName;
            e.AccessFailedCount = c.AccessFailedCount;
            e.Email = c.Email;
            e.EmailConfirmed = c.EmailConfirmed;
            e.LockoutEnabled = c.LockoutEnabled;
            e.LockoutEndDateUtc = c.LockoutEndDateUtc;
            e.PasswordHash = c.PasswordHash;
            e.PhoneNumber = c.PhoneNumber;
            e.PhoneNumberConfirmed = c.PhoneNumberConfirmed;
            e.TwoFactorEnabled = c.TwoFactorEnabled;
            e.SecurityStamp = c.SecurityStamp;
            e.Active = c.Active;
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var version = c.Version;

            foreach (ICreateUserRole innerCommand in c.UserRoles)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IUserRoleStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddUserRoleEvent(innerEvent);
            }

            foreach (ICreateUserClaim innerCommand in c.UserClaims)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IUserClaimStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddUserClaimEvent(innerEvent);
            }

            foreach (ICreateUserPermission innerCommand in c.UserPermissions)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IUserPermissionStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddUserPermissionEvent(innerEvent);
            }


            return e;
        }

        protected virtual IUserStateMergePatched Map(IMergePatchUser c)
        {
			var stateEventId = new UserStateEventId(c.UserId, c.Version);
            IUserStateMergePatched e = NewUserStateMergePatched(stateEventId);

            e.UserName = c.UserName;
            e.AccessFailedCount = c.AccessFailedCount;
            e.Email = c.Email;
            e.EmailConfirmed = c.EmailConfirmed;
            e.LockoutEnabled = c.LockoutEnabled;
            e.LockoutEndDateUtc = c.LockoutEndDateUtc;
            e.PasswordHash = c.PasswordHash;
            e.PhoneNumber = c.PhoneNumber;
            e.PhoneNumberConfirmed = c.PhoneNumberConfirmed;
            e.TwoFactorEnabled = c.TwoFactorEnabled;
            e.SecurityStamp = c.SecurityStamp;
            e.Active = c.Active;
            e.IsPropertyUserNameRemoved = c.IsPropertyUserNameRemoved;
            e.IsPropertyAccessFailedCountRemoved = c.IsPropertyAccessFailedCountRemoved;
            e.IsPropertyEmailRemoved = c.IsPropertyEmailRemoved;
            e.IsPropertyEmailConfirmedRemoved = c.IsPropertyEmailConfirmedRemoved;
            e.IsPropertyLockoutEnabledRemoved = c.IsPropertyLockoutEnabledRemoved;
            e.IsPropertyLockoutEndDateUtcRemoved = c.IsPropertyLockoutEndDateUtcRemoved;
            e.IsPropertyPasswordHashRemoved = c.IsPropertyPasswordHashRemoved;
            e.IsPropertyPhoneNumberRemoved = c.IsPropertyPhoneNumberRemoved;
            e.IsPropertyPhoneNumberConfirmedRemoved = c.IsPropertyPhoneNumberConfirmedRemoved;
            e.IsPropertyTwoFactorEnabledRemoved = c.IsPropertyTwoFactorEnabledRemoved;
            e.IsPropertySecurityStampRemoved = c.IsPropertySecurityStampRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var version = c.Version;

            foreach (IUserRoleCommand innerCommand in c.UserRoleCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IUserRoleStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddUserRoleEvent(innerEvent);
            }

            foreach (IUserClaimCommand innerCommand in c.UserClaimCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IUserClaimStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddUserClaimEvent(innerEvent);
            }

            foreach (IUserPermissionCommand innerCommand in c.UserPermissionCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IUserPermissionStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddUserPermissionEvent(innerEvent);
            }


            return e;
        }

        protected virtual IUserStateDeleted Map(IDeleteUser c)
        {
			var stateEventId = new UserStateEventId(c.UserId, c.Version);
            IUserStateDeleted e = NewUserStateDeleted(stateEventId);
			
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;


            return e;
        }


        protected void ThrowOnInconsistentCommands(IUserCommand command, IUserRoleCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeleteUser;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveUserRole;
            if (properties == null || innerProperties == null) { return; }
            var outerUserIdName = "UserId";
            var outerUserIdValue = properties.UserId;
            var innerUserIdName = "UserId";
            var innerUserIdValue = innerProperties.UserId;
            SetNullInnerIdOrThrowOnInconsistentIds(innerProperties, innerUserIdName, innerUserIdValue, outerUserIdName, outerUserIdValue);

        }// END ThrowOnInconsistentCommands /////////////////////


        protected void ThrowOnInconsistentCommands(IUserCommand command, IUserClaimCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeleteUser;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveUserClaim;
            if (properties == null || innerProperties == null) { return; }
            var outerUserIdName = "UserId";
            var outerUserIdValue = properties.UserId;
            var innerUserIdName = "UserId";
            var innerUserIdValue = innerProperties.UserId;
            SetNullInnerIdOrThrowOnInconsistentIds(innerProperties, innerUserIdName, innerUserIdValue, outerUserIdName, outerUserIdValue);

        }// END ThrowOnInconsistentCommands /////////////////////


        protected void ThrowOnInconsistentCommands(IUserCommand command, IUserPermissionCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeleteUser;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveUserPermission;
            if (properties == null || innerProperties == null) { return; }
            var outerUserIdName = "UserId";
            var outerUserIdValue = properties.UserId;
            var innerUserIdName = "UserId";
            var innerUserIdValue = innerProperties.UserId;
            SetNullInnerIdOrThrowOnInconsistentIds(innerProperties, innerUserIdName, innerUserIdValue, outerUserIdName, outerUserIdValue);

        }// END ThrowOnInconsistentCommands /////////////////////


        protected virtual IUserRoleStateEvent Map(IUserRoleCommand c, IUserCommand outerCommand, long version, IUserState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateUserRole) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchUserRole) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            var remove = (c.CommandType == CommandType.Remove) ? (c as IRemoveUserRole) : null;
            if (remove != null)
            {
                return MapRemove(remove, outerCommand, version);
            }
            throw new NotSupportedException();
        }


        protected virtual IUserRoleStateCreated MapCreate(ICreateUserRole c, IUserCommand outerCommand, long version, IUserState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new UserRoleStateEventId(c.UserId, c.RoleId, version);
            IUserRoleStateCreated e = NewUserRoleStateCreated(stateEventId);
            var s = outerState.UserRoles.Get(c.RoleId);

            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IUserRoleStateMergePatched MapMergePatch(IMergePatchUserRole c, IUserCommand outerCommand, long version, IUserState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new UserRoleStateEventId(c.UserId, c.RoleId, version);
            IUserRoleStateMergePatched e = NewUserRoleStateMergePatched(stateEventId);
            var s = outerState.UserRoles.Get(c.RoleId);

            e.Active = c.Active;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(IMergePatch... ////////////////////////////


        protected virtual IUserRoleStateRemoved MapRemove(IRemoveUserRole c, IUserCommand outerCommand, long version)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new UserRoleStateEventId(c.UserId, c.RoleId, version);
            IUserRoleStateRemoved e = NewUserRoleStateRemoved(stateEventId);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            return e;

        }// END Map(IRemove... ////////////////////////////


        protected virtual IUserClaimStateEvent Map(IUserClaimCommand c, IUserCommand outerCommand, long version, IUserState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateUserClaim) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchUserClaim) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            var remove = (c.CommandType == CommandType.Remove) ? (c as IRemoveUserClaim) : null;
            if (remove != null)
            {
                return MapRemove(remove, outerCommand, version);
            }
            throw new NotSupportedException();
        }


        protected virtual IUserClaimStateCreated MapCreate(ICreateUserClaim c, IUserCommand outerCommand, long version, IUserState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new UserClaimStateEventId(c.UserId, c.ClaimId, version);
            IUserClaimStateCreated e = NewUserClaimStateCreated(stateEventId);
            var s = outerState.UserClaims.Get(c.ClaimId);

            e.ClaimType = c.ClaimType;
            e.ClaimValue = c.ClaimValue;
            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IUserClaimStateMergePatched MapMergePatch(IMergePatchUserClaim c, IUserCommand outerCommand, long version, IUserState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new UserClaimStateEventId(c.UserId, c.ClaimId, version);
            IUserClaimStateMergePatched e = NewUserClaimStateMergePatched(stateEventId);
            var s = outerState.UserClaims.Get(c.ClaimId);

            e.ClaimType = c.ClaimType;
            e.ClaimValue = c.ClaimValue;
            e.Active = c.Active;
            e.IsPropertyClaimTypeRemoved = c.IsPropertyClaimTypeRemoved;
            e.IsPropertyClaimValueRemoved = c.IsPropertyClaimValueRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(IMergePatch... ////////////////////////////


        protected virtual IUserClaimStateRemoved MapRemove(IRemoveUserClaim c, IUserCommand outerCommand, long version)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new UserClaimStateEventId(c.UserId, c.ClaimId, version);
            IUserClaimStateRemoved e = NewUserClaimStateRemoved(stateEventId);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            return e;

        }// END Map(IRemove... ////////////////////////////


        protected virtual IUserPermissionStateEvent Map(IUserPermissionCommand c, IUserCommand outerCommand, long version, IUserState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateUserPermission) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchUserPermission) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            var remove = (c.CommandType == CommandType.Remove) ? (c as IRemoveUserPermission) : null;
            if (remove != null)
            {
                return MapRemove(remove, outerCommand, version);
            }
            throw new NotSupportedException();
        }


        protected virtual IUserPermissionStateCreated MapCreate(ICreateUserPermission c, IUserCommand outerCommand, long version, IUserState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new UserPermissionStateEventId(c.UserId, c.PermissionId, version);
            IUserPermissionStateCreated e = NewUserPermissionStateCreated(stateEventId);
            var s = outerState.UserPermissions.Get(c.PermissionId);

            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IUserPermissionStateMergePatched MapMergePatch(IMergePatchUserPermission c, IUserCommand outerCommand, long version, IUserState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new UserPermissionStateEventId(c.UserId, c.PermissionId, version);
            IUserPermissionStateMergePatched e = NewUserPermissionStateMergePatched(stateEventId);
            var s = outerState.UserPermissions.Get(c.PermissionId);

            e.Active = c.Active;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(IMergePatch... ////////////////////////////


        protected virtual IUserPermissionStateRemoved MapRemove(IRemoveUserPermission c, IUserCommand outerCommand, long version)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new UserPermissionStateEventId(c.UserId, c.PermissionId, version);
            IUserPermissionStateRemoved e = NewUserPermissionStateRemoved(stateEventId);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            return e;

        }// END Map(IRemove... ////////////////////////////

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

        protected UserStateCreated NewUserStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new UserStateEventId(_state.UserId, ((IUserStateProperties)_state).Version);
            var e = NewUserStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected UserStateMergePatched NewUserStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new UserStateEventId(_state.UserId, ((IUserStateProperties)_state).Version);
            var e = NewUserStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected UserStateDeleted NewUserStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new UserStateEventId(_state.UserId, ((IUserStateProperties)_state).Version);
            var e = NewUserStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private UserStateCreated NewUserStateCreated(UserStateEventId stateEventId)
		{
			return new UserStateCreated(stateEventId);			
		}

        private UserStateMergePatched NewUserStateMergePatched(UserStateEventId stateEventId)
		{
			return new UserStateMergePatched(stateEventId);
		}

        private UserStateDeleted NewUserStateDeleted(UserStateEventId stateEventId)
		{
			return new UserStateDeleted(stateEventId);
		}


		private UserRoleStateCreated NewUserRoleStateCreated(UserRoleStateEventId stateEventId)
		{
			return new UserRoleStateCreated(stateEventId);
		}

        private UserRoleStateMergePatched NewUserRoleStateMergePatched(UserRoleStateEventId stateEventId)
		{
			return new UserRoleStateMergePatched(stateEventId);
		}

        private UserRoleStateRemoved NewUserRoleStateRemoved(UserRoleStateEventId stateEventId)
		{
			return new UserRoleStateRemoved(stateEventId);
		}


		private UserClaimStateCreated NewUserClaimStateCreated(UserClaimStateEventId stateEventId)
		{
			return new UserClaimStateCreated(stateEventId);
		}

        private UserClaimStateMergePatched NewUserClaimStateMergePatched(UserClaimStateEventId stateEventId)
		{
			return new UserClaimStateMergePatched(stateEventId);
		}

        private UserClaimStateRemoved NewUserClaimStateRemoved(UserClaimStateEventId stateEventId)
		{
			return new UserClaimStateRemoved(stateEventId);
		}


		private UserPermissionStateCreated NewUserPermissionStateCreated(UserPermissionStateEventId stateEventId)
		{
			return new UserPermissionStateCreated(stateEventId);
		}

        private UserPermissionStateMergePatched NewUserPermissionStateMergePatched(UserPermissionStateEventId stateEventId)
		{
			return new UserPermissionStateMergePatched(stateEventId);
		}

        private UserPermissionStateRemoved NewUserPermissionStateRemoved(UserPermissionStateEventId stateEventId)
		{
			return new UserPermissionStateRemoved(stateEventId);
		}


    }

}


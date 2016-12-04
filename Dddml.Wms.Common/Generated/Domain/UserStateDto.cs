﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

    public partial class UserStateDto : IUserStateDto
    {
        public virtual string UserId
        {
            get;
            set;
        }

        public virtual string UserName
        {
            get;
            set;
        }

        public virtual int? AccessFailedCount
        {
            get;
            set;
        }

        public virtual string Email
        {
            get;
            set;
        }

        public virtual bool? EmailConfirmed
        {
            get;
            set;
        }

        public virtual bool? LockoutEnabled
        {
            get;
            set;
        }

        public virtual DateTime? LockoutEndDateUtc
        {
            get;
            set;
        }

        public virtual string PasswordHash
        {
            get;
            set;
        }

        public virtual string PhoneNumber
        {
            get;
            set;
        }

        public virtual bool? PhoneNumberConfirmed
        {
            get;
            set;
        }

        public virtual bool? TwoFactorEnabled
        {
            get;
            set;
        }

        public virtual string SecurityStamp
        {
            get;
            set;
        }

        public virtual bool? Active
        {
            get;
            set;
        }

        public virtual long? Version
        {
            get;
            set;
        }

        public virtual string CreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? CreatedAt
        {
            get;
            set;
        }

        public virtual string UpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? UpdatedAt
        {
            get;
            set;
        }

        public virtual UserRoleStateDto[] UserRoles
        {
            get;
            set;
        }

        IUserRoleStateDto[] IUserStateDto.UserRoles
        {
            get { return this.UserRoles; }
            set { this.UserRoles = value.Select(e => ((UserRoleStateDto)e)).ToArray(); }
        }

        public virtual UserClaimStateDto[] UserClaims
        {
            get;
            set;
        }

        IUserClaimStateDto[] IUserStateDto.UserClaims
        {
            get { return this.UserClaims; }
            set { this.UserClaims = value.Select(e => ((UserClaimStateDto)e)).ToArray(); }
        }

        public virtual UserPermissionStateDto[] UserPermissions
        {
            get;
            set;
        }

        IUserPermissionStateDto[] IUserStateDto.UserPermissions
        {
            get { return this.UserPermissions; }
            set { this.UserPermissions = value.Select(e => ((UserPermissionStateDto)e)).ToArray(); }
        }

        public virtual UserLoginStateDto[] UserLogins
        {
            get;
            set;
        }

        IUserLoginStateDto[] IUserStateDto.UserLogins
        {
            get { return this.UserLogins; }
            set { this.UserLogins = value.Select(e => ((UserLoginStateDto)e)).ToArray(); }
        }

        public virtual IUserState ToUserState()
        {
            var state = new UserState(true);
            state.UserId = this.UserId;
            state.UserName = this.UserName;
            if (this.AccessFailedCount != null && this.AccessFailedCount.HasValue) { state.AccessFailedCount = this.AccessFailedCount.Value; }
            state.Email = this.Email;
            if (this.EmailConfirmed != null && this.EmailConfirmed.HasValue) { state.EmailConfirmed = this.EmailConfirmed.Value; }
            if (this.LockoutEnabled != null && this.LockoutEnabled.HasValue) { state.LockoutEnabled = this.LockoutEnabled.Value; }
            state.LockoutEndDateUtc = this.LockoutEndDateUtc;
            state.PasswordHash = this.PasswordHash;
            state.PhoneNumber = this.PhoneNumber;
            if (this.PhoneNumberConfirmed != null && this.PhoneNumberConfirmed.HasValue) { state.PhoneNumberConfirmed = this.PhoneNumberConfirmed.Value; }
            if (this.TwoFactorEnabled != null && this.TwoFactorEnabled.HasValue) { state.TwoFactorEnabled = this.TwoFactorEnabled.Value; }
            state.SecurityStamp = this.SecurityStamp;
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }
            if (this.UserRoles != null) { foreach (var s in this.UserRoles) { state.UserRoles.AddToSave(s.ToUserRoleState()); } };
            if (this.UserClaims != null) { foreach (var s in this.UserClaims) { state.UserClaims.AddToSave(s.ToUserClaimState()); } };
            if (this.UserPermissions != null) { foreach (var s in this.UserPermissions) { state.UserPermissions.AddToSave(s.ToUserPermissionState()); } };
            if (this.UserLogins != null) { foreach (var s in this.UserLogins) { state.UserLogins.AddToSave(s.ToUserLoginState()); } };

            return state;
        }

    }

}


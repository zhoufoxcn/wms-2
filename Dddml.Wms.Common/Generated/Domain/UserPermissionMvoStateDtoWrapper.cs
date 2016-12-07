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

	public partial class UserPermissionMvoStateDtoWrapper : StateDtoWrapperBase, IUserPermissionMvoStateDto, IUserPermissionMvoState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private UserPermissionMvoState _state;

        public UserPermissionMvoStateDtoWrapper()
        {
            this._state = new UserPermissionMvoState();
        }

		public UserPermissionMvoStateDtoWrapper(UserPermissionMvoState state)
		{
            this._state = state;
		}

		public IUserPermissionMvoState ToUserPermissionMvoState()
		{
			return this._state;
		}


        public UserPermissionIdDto UserPermissionId
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserPermissionId"))
                {
					return (_state.UserPermissionId == null) ? null : new UserPermissionIdDtoWrapper(_state.UserPermissionId);
                }
                return null;
            }
            set
            {
                _state.UserPermissionId = (value == null) ? null : value.ToUserPermissionId();
            }
        }


        UserPermissionId IUserPermissionMvoStateProperties.UserPermissionId
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserPermissionId;
            }
            set 
            {
                this._state.UserPermissionId = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return _state.Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Version = value.Value;
                }
            }
        }

        long IUserPermissionMvoStateProperties.Version
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).Version;
            }
            set 
            {
                this._state.Version = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return _state.Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Active = value.Value;
                }
            }
        }

        bool IUserPermissionMvoStateProperties.Active
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).Active;
            }
            set 
            {
                this._state.Active = value;
            }
        }

		public virtual string UserUserName
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserUserName"))
                {
                    return _state.UserUserName;
                }
                return null;
            }
            set
            {
                _state.UserUserName = value;
            }
        }

        string IUserPermissionMvoStateProperties.UserUserName
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserUserName;
            }
            set 
            {
                this._state.UserUserName = value;
            }
        }

		public virtual int? UserAccessFailedCount
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserAccessFailedCount"))
                {
                    return _state.UserAccessFailedCount;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserAccessFailedCount = value.Value;
                }
            }
        }

        int IUserPermissionMvoStateProperties.UserAccessFailedCount
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserAccessFailedCount;
            }
            set 
            {
                this._state.UserAccessFailedCount = value;
            }
        }

		public virtual string UserEmail
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserEmail"))
                {
                    return _state.UserEmail;
                }
                return null;
            }
            set
            {
                _state.UserEmail = value;
            }
        }

        string IUserPermissionMvoStateProperties.UserEmail
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserEmail;
            }
            set 
            {
                this._state.UserEmail = value;
            }
        }

		public virtual bool? UserEmailConfirmed
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserEmailConfirmed"))
                {
                    return _state.UserEmailConfirmed;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserEmailConfirmed = value.Value;
                }
            }
        }

        bool IUserPermissionMvoStateProperties.UserEmailConfirmed
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserEmailConfirmed;
            }
            set 
            {
                this._state.UserEmailConfirmed = value;
            }
        }

		public virtual bool? UserLockoutEnabled
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserLockoutEnabled"))
                {
                    return _state.UserLockoutEnabled;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserLockoutEnabled = value.Value;
                }
            }
        }

        bool IUserPermissionMvoStateProperties.UserLockoutEnabled
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserLockoutEnabled;
            }
            set 
            {
                this._state.UserLockoutEnabled = value;
            }
        }

		public virtual DateTime? UserLockoutEndDateUtc
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserLockoutEndDateUtc"))
                {
                    return _state.UserLockoutEndDateUtc;
                }
                return null;
            }
            set
            {
                _state.UserLockoutEndDateUtc = value;
            }
        }

        DateTime? IUserPermissionMvoStateProperties.UserLockoutEndDateUtc
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserLockoutEndDateUtc;
            }
            set 
            {
                this._state.UserLockoutEndDateUtc = value;
            }
        }

		public virtual string UserPasswordHash
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserPasswordHash"))
                {
                    return _state.UserPasswordHash;
                }
                return null;
            }
            set
            {
                _state.UserPasswordHash = value;
            }
        }

        string IUserPermissionMvoStateProperties.UserPasswordHash
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserPasswordHash;
            }
            set 
            {
                this._state.UserPasswordHash = value;
            }
        }

		public virtual string UserPhoneNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserPhoneNumber"))
                {
                    return _state.UserPhoneNumber;
                }
                return null;
            }
            set
            {
                _state.UserPhoneNumber = value;
            }
        }

        string IUserPermissionMvoStateProperties.UserPhoneNumber
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserPhoneNumber;
            }
            set 
            {
                this._state.UserPhoneNumber = value;
            }
        }

		public virtual bool? UserPhoneNumberConfirmed
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserPhoneNumberConfirmed"))
                {
                    return _state.UserPhoneNumberConfirmed;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserPhoneNumberConfirmed = value.Value;
                }
            }
        }

        bool IUserPermissionMvoStateProperties.UserPhoneNumberConfirmed
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserPhoneNumberConfirmed;
            }
            set 
            {
                this._state.UserPhoneNumberConfirmed = value;
            }
        }

		public virtual bool? UserTwoFactorEnabled
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserTwoFactorEnabled"))
                {
                    return _state.UserTwoFactorEnabled;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserTwoFactorEnabled = value.Value;
                }
            }
        }

        bool IUserPermissionMvoStateProperties.UserTwoFactorEnabled
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserTwoFactorEnabled;
            }
            set 
            {
                this._state.UserTwoFactorEnabled = value;
            }
        }

		public virtual string UserSecurityStamp
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserSecurityStamp"))
                {
                    return _state.UserSecurityStamp;
                }
                return null;
            }
            set
            {
                _state.UserSecurityStamp = value;
            }
        }

        string IUserPermissionMvoStateProperties.UserSecurityStamp
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserSecurityStamp;
            }
            set 
            {
                this._state.UserSecurityStamp = value;
            }
        }

		public virtual string UserCreatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserCreatedBy"))
                {
                    return _state.UserCreatedBy;
                }
                return null;
            }
            set
            {
                _state.UserCreatedBy = value;
            }
        }

        string IUserPermissionMvoStateProperties.UserCreatedBy
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserCreatedBy;
            }
            set 
            {
                this._state.UserCreatedBy = value;
            }
        }

		public virtual DateTime? UserCreatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserCreatedAt"))
                {
                    return _state.UserCreatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.UserCreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserCreatedAt = value.Value;
                }
            }
        }

        DateTime IUserPermissionMvoStateProperties.UserCreatedAt
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserCreatedAt;
            }
            set 
            {
                this._state.UserCreatedAt = value;
            }
        }

		public virtual string UserUpdatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserUpdatedBy"))
                {
                    return _state.UserUpdatedBy;
                }
                return null;
            }
            set
            {
                _state.UserUpdatedBy = value;
            }
        }

        string IUserPermissionMvoStateProperties.UserUpdatedBy
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserUpdatedBy;
            }
            set 
            {
                this._state.UserUpdatedBy = value;
            }
        }

		public virtual DateTime? UserUpdatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserUpdatedAt"))
                {
                    return _state.UserUpdatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.UserUpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserUpdatedAt = value.Value;
                }
            }
        }

        DateTime IUserPermissionMvoStateProperties.UserUpdatedAt
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserUpdatedAt;
            }
            set 
            {
                this._state.UserUpdatedAt = value;
            }
        }

		public virtual bool? UserActive
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserActive"))
                {
                    return _state.UserActive;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserActive = value.Value;
                }
            }
        }

        bool IUserPermissionMvoStateProperties.UserActive
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserActive;
            }
            set 
            {
                this._state.UserActive = value;
            }
        }

		public virtual bool? UserDeleted
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserDeleted"))
                {
                    return _state.UserDeleted;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserDeleted = value.Value;
                }
            }
        }

        bool IUserPermissionMvoStateProperties.UserDeleted
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserDeleted;
            }
            set 
            {
                this._state.UserDeleted = value;
            }
        }

		public virtual long? UserVersion
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UserVersion"))
                {
                    return _state.UserVersion;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UserVersion = value.Value;
                }
            }
        }

        long IUserPermissionMvoStateProperties.UserVersion
        {
            get 
            {
                return (this._state as IUserPermissionMvoStateProperties).UserVersion;
            }
            set 
            {
                this._state.UserVersion = value;
            }
        }

		public virtual string CreatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CreatedBy"))
                {
                    return _state.CreatedBy;
                }
                return null;
            }
            set
            {
                _state.CreatedBy = value;
            }
        }
		public virtual DateTime? CreatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CreatedAt"))
                {
                    return _state.CreatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.CreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.CreatedAt = value.Value;
                }
            }
        }
		public virtual string UpdatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UpdatedBy"))
                {
                    return _state.UpdatedBy;
                }
                return null;
            }
            set
            {
                _state.UpdatedBy = value;
            }
        }
		public virtual DateTime? UpdatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UpdatedAt"))
                {
                    return _state.UpdatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.UpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UpdatedAt = value.Value;
                }
            }
        }

		#region IIdentity implementation

		UserPermissionId IGlobalIdentity<UserPermissionId>.GlobalId
		{
			get { return (_state as IUserPermissionMvoState).GlobalId; }
		}

		#endregion


		#region IActive implementation

		bool IActive.Active
		{
            get { return (_state as IActive).Active; }
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
            get { return (_state as IDeleted).Deleted; }
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
            get { return (_state as IUserPermissionMvoState).CreatedBy; }
            set { (_state as IUserPermissionMvoState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IUserPermissionMvoState).CreatedAt; }
            set { (_state as IUserPermissionMvoState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IUserPermissionMvoState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IUserPermissionMvoState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.UserVersion; }
		}

		#endregion

        bool IUserPermissionMvoState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == UserPermissionMvoState.VersionZero; }
        }


		void IUserPermissionMvoState.When(IUserPermissionMvoStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IUserPermissionMvoState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

		void IUserPermissionMvoState.When(IUserPermissionMvoStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IUserPermissionMvoState.When(IUserPermissionMvoStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IUserPermissionMvoState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class UserPermissionMvoStateDtoWrapperCollection : StateDtoWrapperCollectionBase<UserPermissionMvoStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(UserPermissionMvoStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}


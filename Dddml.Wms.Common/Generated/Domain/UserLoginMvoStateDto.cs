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

	public partial class UserLoginMvoStateDto : StateDtoBase, IUserLoginMvoState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private UserLoginMvoState _state;

        public UserLoginMvoStateDto()
        {
            this._state = new UserLoginMvoState();
        }

		public UserLoginMvoStateDto(UserLoginMvoState state)
		{
            this._state = state;
		}

		internal UserLoginMvoState ToUserLoginMvoState()
		{
			return this._state;
		}


        public UserLoginIdDto UserLoginId
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserLoginId"))
                {
					return (_state.UserLoginId == null) ? null : new UserLoginIdDto(_state.UserLoginId);
                }
                return null;
            }
            set
            {
                _state.UserLoginId = (value == null) ? null : value.ToUserLoginId();
            }
        }


        UserLoginId IUserLoginMvoStateProperties.UserLoginId
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserLoginId;
            }
            set 
            {
                this._state.UserLoginId = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Version"))
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

        long IUserLoginMvoStateProperties.Version
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).Version;
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
                if ((this as IStateDto).ReturnedFieldsContains("Active"))
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

        bool IUserLoginMvoStateProperties.Active
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).Active;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserUserName"))
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

        string IUserLoginMvoStateProperties.UserUserName
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserUserName;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserAccessFailedCount"))
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

        int IUserLoginMvoStateProperties.UserAccessFailedCount
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserAccessFailedCount;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserEmail"))
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

        string IUserLoginMvoStateProperties.UserEmail
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserEmail;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserEmailConfirmed"))
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

        bool IUserLoginMvoStateProperties.UserEmailConfirmed
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserEmailConfirmed;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserLockoutEnabled"))
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

        bool IUserLoginMvoStateProperties.UserLockoutEnabled
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserLockoutEnabled;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserLockoutEndDateUtc"))
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

        DateTime? IUserLoginMvoStateProperties.UserLockoutEndDateUtc
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserLockoutEndDateUtc;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserPasswordHash"))
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

        string IUserLoginMvoStateProperties.UserPasswordHash
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserPasswordHash;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserPhoneNumber"))
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

        string IUserLoginMvoStateProperties.UserPhoneNumber
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserPhoneNumber;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserPhoneNumberConfirmed"))
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

        bool IUserLoginMvoStateProperties.UserPhoneNumberConfirmed
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserPhoneNumberConfirmed;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserTwoFactorEnabled"))
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

        bool IUserLoginMvoStateProperties.UserTwoFactorEnabled
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserTwoFactorEnabled;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserSecurityStamp"))
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

        string IUserLoginMvoStateProperties.UserSecurityStamp
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserSecurityStamp;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserCreatedBy"))
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

        string IUserLoginMvoStateProperties.UserCreatedBy
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserCreatedBy;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserCreatedAt"))
                {
                    return _state.UserCreatedAt;
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

        DateTime IUserLoginMvoStateProperties.UserCreatedAt
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserCreatedAt;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserUpdatedBy"))
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

        string IUserLoginMvoStateProperties.UserUpdatedBy
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserUpdatedBy;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserUpdatedAt"))
                {
                    return _state.UserUpdatedAt;
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

        DateTime IUserLoginMvoStateProperties.UserUpdatedAt
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserUpdatedAt;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserActive"))
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

        bool IUserLoginMvoStateProperties.UserActive
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserActive;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserDeleted"))
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

        bool IUserLoginMvoStateProperties.UserDeleted
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserDeleted;
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
                if ((this as IStateDto).ReturnedFieldsContains("UserVersion"))
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

        long IUserLoginMvoStateProperties.UserVersion
        {
            get 
            {
                return (this._state as IUserLoginMvoStateProperties).UserVersion;
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
                if ((this as IStateDto).ReturnedFieldsContains("CreatedBy"))
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
                if ((this as IStateDto).ReturnedFieldsContains("CreatedAt"))
                {
                    return _state.CreatedAt;
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
                if ((this as IStateDto).ReturnedFieldsContains("UpdatedBy"))
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
                if ((this as IStateDto).ReturnedFieldsContains("UpdatedAt"))
                {
                    return _state.UpdatedAt;
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

		UserLoginId IGlobalIdentity<UserLoginId>.GlobalId
		{
			get { return (_state as IUserLoginMvoState).GlobalId; }
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
            get { return (_state as IUserLoginMvoState).CreatedBy; }
            set { (_state as IUserLoginMvoState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IUserLoginMvoState).CreatedAt; }
            set { (_state as IUserLoginMvoState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IUserLoginMvoState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IUserLoginMvoState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.UserVersion; }
		}

		#endregion

        bool IUserLoginMvoState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == UserLoginMvoState.VersionZero; }
        }


		void IUserLoginMvoState.When(IUserLoginMvoStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IUserLoginMvoState.When(IUserLoginMvoStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IUserLoginMvoState.When(IUserLoginMvoStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IUserLoginMvoState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class UserLoginMvoStateDtoCollection : StateDtoCollectionBase<UserLoginMvoStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(UserLoginMvoStateDto._collectionFieldNames, fieldName);
        }

    }

}


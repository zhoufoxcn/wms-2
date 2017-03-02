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

	public partial class RolePermissionStateDtoWrapper : StateDtoWrapperBase, IRolePermissionStateDto, IRolePermissionState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IRolePermissionState _state;

        public RolePermissionStateDtoWrapper()
        {
            this._state = new RolePermissionState();
        }

		public RolePermissionStateDtoWrapper(IRolePermissionState state)
		{
            this._state = state;
		}

		public IRolePermissionState ToRolePermissionState()
		{
			return this._state;
		}


        public RolePermissionIdDto Id
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Id"))
                {
					return (_state.Id == null) ? null : new RolePermissionIdDtoWrapper(_state.Id);
                }
                return null;
            }
            set
            {
                _state.Id = (value == null) ? null : value.ToRolePermissionId();
            }
        }


        RolePermissionId IRolePermissionStateProperties.Id
        {
            get 
            {
                return (this._state as IRolePermissionStateProperties).Id;
            }
            set 
            {
                (this._state as IRolePermissionStateProperties).Id = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IRolePermissionStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IRolePermissionStateProperties).Active = value.Value;
                }
            }
        }

        bool IRolePermissionStateProperties.Active
        {
            get 
            {
                return (this._state as IRolePermissionStateProperties).Active;
            }
            set 
            {
                (this._state as IRolePermissionStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IRolePermissionStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IRolePermissionStateProperties).Version = value.Value;
                }
            }
        }

        long IRolePermissionStateProperties.Version
        {
            get 
            {
                return (this._state as IRolePermissionStateProperties).Version;
            }
            set 
            {
                (this._state as IRolePermissionStateProperties).Version = value;
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

		RolePermissionId IGlobalIdentity<RolePermissionId>.GlobalId
		{
			get { return (_state as IRolePermissionState).GlobalId; }
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
            return (_state as IActive).IsActive();
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
            get { return (_state as IRolePermissionState).CreatedBy; }
            set { (_state as IRolePermissionState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IRolePermissionState).CreatedAt; }
            set { (_state as IRolePermissionState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IRolePermissionState).UpdatedBy; }
            set { (_state as IRolePermissionState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IRolePermissionState).UpdatedAt; }
            set { (_state as IRolePermissionState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IRolePermissionStateProperties).Version; }
		}

		#endregion

        bool IRolePermissionState.IsUnsaved
        {
            get { return this.Version == RolePermissionState.VersionZero; }
        }


		void IRolePermissionState.When(IRolePermissionStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IRolePermissionState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IRolePermissionState.When(IRolePermissionStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IRolePermissionState.When(IRolePermissionStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IRolePermissionState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class RolePermissionStateDtoWrapperCollection : StateDtoWrapperCollectionBase<RolePermissionStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(RolePermissionStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

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

	public partial class WarehouseStateDto : StateDtoBase, IWarehouseState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private WarehouseState _state;

        public WarehouseStateDto()
        {
            this._state = new WarehouseState();
        }

		public WarehouseStateDto(WarehouseState state)
		{
            this._state = state;
		}

		internal WarehouseState ToWarehouseState()
		{
			return this._state;
		}

		public virtual string WarehouseId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("WarehouseId"))
                {
                    return _state.WarehouseId;
                }
                return null;
            }
            set
            {
                _state.WarehouseId = value;
            }
        }

        string IWarehouseStateProperties.WarehouseId
        {
            get 
            {
                return (this._state as IWarehouseStateProperties).WarehouseId;
            }
            set 
            {
                this._state.WarehouseId = value;
            }
        }

		public virtual string Name
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Name"))
                {
                    return _state.Name;
                }
                return null;
            }
            set
            {
                _state.Name = value;
            }
        }

        string IWarehouseStateProperties.Name
        {
            get 
            {
                return (this._state as IWarehouseStateProperties).Name;
            }
            set 
            {
                this._state.Name = value;
            }
        }

		public virtual string Description
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Description"))
                {
                    return _state.Description;
                }
                return null;
            }
            set
            {
                _state.Description = value;
            }
        }

        string IWarehouseStateProperties.Description
        {
            get 
            {
                return (this._state as IWarehouseStateProperties).Description;
            }
            set 
            {
                this._state.Description = value;
            }
        }

		public virtual bool? IsInTransit
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("IsInTransit"))
                {
                    return _state.IsInTransit;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.IsInTransit = value.Value;
                }
            }
        }

        bool IWarehouseStateProperties.IsInTransit
        {
            get 
            {
                return (this._state as IWarehouseStateProperties).IsInTransit;
            }
            set 
            {
                this._state.IsInTransit = value;
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

        bool IWarehouseStateProperties.Active
        {
            get 
            {
                return (this._state as IWarehouseStateProperties).Active;
            }
            set 
            {
                this._state.Active = value;
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

        long IWarehouseStateProperties.Version
        {
            get 
            {
                return (this._state as IWarehouseStateProperties).Version;
            }
            set 
            {
                this._state.Version = value;
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

		string IGlobalIdentity<string>.GlobalId
		{
			get { return (_state as IWarehouseState).GlobalId; }
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
            get { return (_state as IWarehouseState).CreatedBy; }
            set { (_state as IWarehouseState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IWarehouseState).CreatedAt; }
            set { (_state as IWarehouseState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IWarehouseState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IWarehouseState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.Version; }
		}

		#endregion

        bool IWarehouseState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == WarehouseState.VersionZero; }
        }



		void IWarehouseState.When(IWarehouseStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IWarehouseState.When(IWarehouseStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IWarehouseState.When(IWarehouseStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IWarehouseState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class WarehouseStateDtoCollection : StateDtoCollectionBase<WarehouseStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(WarehouseStateDto._collectionFieldNames, fieldName);
        }

    }

}


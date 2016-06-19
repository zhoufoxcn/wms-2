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

	public partial class AttributeUseMvoStateDto : StateDtoBase, IAttributeUseMvoState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private AttributeUseMvoState _state;

        public AttributeUseMvoStateDto()
        {
            this._state = new AttributeUseMvoState();
        }

		public AttributeUseMvoStateDto(AttributeUseMvoState state)
		{
            this._state = state;
		}

		internal AttributeUseMvoState ToAttributeUseMvoState()
		{
			return this._state;
		}


        public AttributeSetAttributeUseIdDto AttributeSetAttributeUseId
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetAttributeUseId"))
                {
					return new AttributeSetAttributeUseIdDto(_state.AttributeSetAttributeUseId);
                }
                return null;
            }
            set
            {
                _state.AttributeSetAttributeUseId = value.ToAttributeSetAttributeUseId();
            }
        }


        AttributeSetAttributeUseId IAttributeUseMvoStateProperties.AttributeSetAttributeUseId
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetAttributeUseId;
            }
            set 
            {
                this._state.AttributeSetAttributeUseId = value;
            }
        }

		public virtual int? SequenceNumber
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("SequenceNumber"))
                {
                    return _state.SequenceNumber;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.SequenceNumber = value.Value;
                }
            }
        }

        int IAttributeUseMvoStateProperties.SequenceNumber
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).SequenceNumber;
            }
            set 
            {
                this._state.SequenceNumber = value;
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

        long IAttributeUseMvoStateProperties.Version
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).Version;
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

        bool IAttributeUseMvoStateProperties.Active
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).Active;
            }
            set 
            {
                this._state.Active = value;
            }
        }

		public virtual string AttributeSetName
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetName"))
                {
                    return _state.AttributeSetName;
                }
                return null;
            }
            set
            {
                _state.AttributeSetName = value;
            }
        }

        string IAttributeUseMvoStateProperties.AttributeSetName
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetName;
            }
            set 
            {
                this._state.AttributeSetName = value;
            }
        }

		public virtual string AttributeSetOrganizationId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetOrganizationId"))
                {
                    return _state.AttributeSetOrganizationId;
                }
                return null;
            }
            set
            {
                _state.AttributeSetOrganizationId = value;
            }
        }

        string IAttributeUseMvoStateProperties.AttributeSetOrganizationId
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetOrganizationId;
            }
            set 
            {
                this._state.AttributeSetOrganizationId = value;
            }
        }

		public virtual string AttributeSetDescription
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetDescription"))
                {
                    return _state.AttributeSetDescription;
                }
                return null;
            }
            set
            {
                _state.AttributeSetDescription = value;
            }
        }

        string IAttributeUseMvoStateProperties.AttributeSetDescription
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetDescription;
            }
            set 
            {
                this._state.AttributeSetDescription = value;
            }
        }

		public virtual string AttributeSetSerialNumberAttributeId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetSerialNumberAttributeId"))
                {
                    return _state.AttributeSetSerialNumberAttributeId;
                }
                return null;
            }
            set
            {
                _state.AttributeSetSerialNumberAttributeId = value;
            }
        }

        string IAttributeUseMvoStateProperties.AttributeSetSerialNumberAttributeId
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetSerialNumberAttributeId;
            }
            set 
            {
                this._state.AttributeSetSerialNumberAttributeId = value;
            }
        }

		public virtual string AttributeSetLotAttributeId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetLotAttributeId"))
                {
                    return _state.AttributeSetLotAttributeId;
                }
                return null;
            }
            set
            {
                _state.AttributeSetLotAttributeId = value;
            }
        }

        string IAttributeUseMvoStateProperties.AttributeSetLotAttributeId
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetLotAttributeId;
            }
            set 
            {
                this._state.AttributeSetLotAttributeId = value;
            }
        }

		public virtual string AttributeSetReferenceId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetReferenceId"))
                {
                    return _state.AttributeSetReferenceId;
                }
                return null;
            }
            set
            {
                _state.AttributeSetReferenceId = value;
            }
        }

        string IAttributeUseMvoStateProperties.AttributeSetReferenceId
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetReferenceId;
            }
            set 
            {
                this._state.AttributeSetReferenceId = value;
            }
        }

		public virtual string AttributeSetCreatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetCreatedBy"))
                {
                    return _state.AttributeSetCreatedBy;
                }
                return null;
            }
            set
            {
                _state.AttributeSetCreatedBy = value;
            }
        }

        string IAttributeUseMvoStateProperties.AttributeSetCreatedBy
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetCreatedBy;
            }
            set 
            {
                this._state.AttributeSetCreatedBy = value;
            }
        }

		public virtual DateTime? AttributeSetCreatedAt
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetCreatedAt"))
                {
                    return _state.AttributeSetCreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttributeSetCreatedAt = value.Value;
                }
            }
        }

        DateTime IAttributeUseMvoStateProperties.AttributeSetCreatedAt
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetCreatedAt;
            }
            set 
            {
                this._state.AttributeSetCreatedAt = value;
            }
        }

		public virtual string AttributeSetUpdatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetUpdatedBy"))
                {
                    return _state.AttributeSetUpdatedBy;
                }
                return null;
            }
            set
            {
                _state.AttributeSetUpdatedBy = value;
            }
        }

        string IAttributeUseMvoStateProperties.AttributeSetUpdatedBy
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetUpdatedBy;
            }
            set 
            {
                this._state.AttributeSetUpdatedBy = value;
            }
        }

		public virtual DateTime? AttributeSetUpdatedAt
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetUpdatedAt"))
                {
                    return _state.AttributeSetUpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttributeSetUpdatedAt = value.Value;
                }
            }
        }

        DateTime IAttributeUseMvoStateProperties.AttributeSetUpdatedAt
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetUpdatedAt;
            }
            set 
            {
                this._state.AttributeSetUpdatedAt = value;
            }
        }

		public virtual bool? AttributeSetActive
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetActive"))
                {
                    return _state.AttributeSetActive;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttributeSetActive = value.Value;
                }
            }
        }

        bool IAttributeUseMvoStateProperties.AttributeSetActive
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetActive;
            }
            set 
            {
                this._state.AttributeSetActive = value;
            }
        }

		public virtual bool? AttributeSetDeleted
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetDeleted"))
                {
                    return _state.AttributeSetDeleted;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttributeSetDeleted = value.Value;
                }
            }
        }

        bool IAttributeUseMvoStateProperties.AttributeSetDeleted
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetDeleted;
            }
            set 
            {
                this._state.AttributeSetDeleted = value;
            }
        }

		public virtual long? AttributeSetVersion
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetVersion"))
                {
                    return _state.AttributeSetVersion;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.AttributeSetVersion = value.Value;
                }
            }
        }

        long IAttributeUseMvoStateProperties.AttributeSetVersion
        {
            get 
            {
                return (this._state as IAttributeUseMvoStateProperties).AttributeSetVersion;
            }
            set 
            {
                this._state.AttributeSetVersion = value;
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

		AttributeSetAttributeUseId IGlobalIdentity<AttributeSetAttributeUseId>.GlobalId
		{
			get { return (_state as IAttributeUseMvoState).GlobalId; }
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
            get { return (_state as IAttributeUseMvoState).CreatedBy; }
            set { (_state as IAttributeUseMvoState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IAttributeUseMvoState).CreatedAt; }
            set { (_state as IAttributeUseMvoState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IAttributeUseMvoState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IAttributeUseMvoState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.AttributeSetVersion; }
		}

		#endregion

        bool IAttributeUseMvoState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == AttributeUseMvoState.VersionZero; }
        }



		void IAttributeUseMvoState.When(IAttributeUseMvoStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IAttributeUseMvoState.When(IAttributeUseMvoStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IAttributeUseMvoState.When(IAttributeUseMvoStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IAttributeUseMvoState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class AttributeUseMvoStateDtoCollection : StateDtoCollectionBase<AttributeUseMvoStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(AttributeUseMvoStateDto._collectionFieldNames, fieldName);
        }

    }

}


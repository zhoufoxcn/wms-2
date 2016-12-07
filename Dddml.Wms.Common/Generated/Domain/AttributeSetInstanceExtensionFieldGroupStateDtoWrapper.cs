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

	public partial class AttributeSetInstanceExtensionFieldGroupStateDtoWrapper : StateDtoWrapperBase, IAttributeSetInstanceExtensionFieldGroupStateDto, IAttributeSetInstanceExtensionFieldGroupState
	{

        internal static IList<string> _collectionFieldNames = new string[] { "Fields" };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private AttributeSetInstanceExtensionFieldGroupState _state;

        public AttributeSetInstanceExtensionFieldGroupStateDtoWrapper()
        {
            this._state = new AttributeSetInstanceExtensionFieldGroupState();
        }

		public AttributeSetInstanceExtensionFieldGroupStateDtoWrapper(AttributeSetInstanceExtensionFieldGroupState state)
		{
            this._state = state;
		}

		public IAttributeSetInstanceExtensionFieldGroupState ToAttributeSetInstanceExtensionFieldGroupState()
		{
			return this._state;
		}

		public virtual string Id
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Id"))
                {
                    return _state.Id;
                }
                return null;
            }
            set
            {
                _state.Id = value;
            }
        }

        string IAttributeSetInstanceExtensionFieldGroupStateProperties.Id
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldGroupStateProperties).Id;
            }
            set 
            {
                this._state.Id = value;
            }
        }

		public virtual string FieldType
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("FieldType"))
                {
                    return _state.FieldType;
                }
                return null;
            }
            set
            {
                _state.FieldType = value;
            }
        }

        string IAttributeSetInstanceExtensionFieldGroupStateProperties.FieldType
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldGroupStateProperties).FieldType;
            }
            set 
            {
                this._state.FieldType = value;
            }
        }

		public virtual int? FieldLength
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("FieldLength"))
                {
                    return _state.FieldLength;
                }
                return null;
            }
            set
            {
                _state.FieldLength = value;
            }
        }

        int? IAttributeSetInstanceExtensionFieldGroupStateProperties.FieldLength
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldGroupStateProperties).FieldLength;
            }
            set 
            {
                this._state.FieldLength = value;
            }
        }

		public virtual int? FieldCount
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("FieldCount"))
                {
                    return _state.FieldCount;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.FieldCount = value.Value;
                }
            }
        }

        int IAttributeSetInstanceExtensionFieldGroupStateProperties.FieldCount
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldGroupStateProperties).FieldCount;
            }
            set 
            {
                this._state.FieldCount = value;
            }
        }

		public virtual string NameFormat
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("NameFormat"))
                {
                    return _state.NameFormat;
                }
                return null;
            }
            set
            {
                _state.NameFormat = value;
            }
        }

        string IAttributeSetInstanceExtensionFieldGroupStateProperties.NameFormat
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldGroupStateProperties).NameFormat;
            }
            set 
            {
                this._state.NameFormat = value;
            }
        }

		public virtual string Description
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Description"))
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

        string IAttributeSetInstanceExtensionFieldGroupStateProperties.Description
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldGroupStateProperties).Description;
            }
            set 
            {
                this._state.Description = value;
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

        bool IAttributeSetInstanceExtensionFieldGroupStateProperties.Active
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldGroupStateProperties).Active;
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

        long IAttributeSetInstanceExtensionFieldGroupStateProperties.Version
        {
            get 
            {
                return (this._state as IAttributeSetInstanceExtensionFieldGroupStateProperties).Version;
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

		string IGlobalIdentity<string>.GlobalId
		{
			get { return (_state as IAttributeSetInstanceExtensionFieldGroupState).GlobalId; }
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
            get { return (_state as IAttributeSetInstanceExtensionFieldGroupState).CreatedBy; }
            set { (_state as IAttributeSetInstanceExtensionFieldGroupState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IAttributeSetInstanceExtensionFieldGroupState).CreatedAt; }
            set { (_state as IAttributeSetInstanceExtensionFieldGroupState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IAttributeSetInstanceExtensionFieldGroupState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IAttributeSetInstanceExtensionFieldGroupState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.Version; }
		}

		#endregion

        bool IAttributeSetInstanceExtensionFieldGroupState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == AttributeSetInstanceExtensionFieldGroupState.VersionZero; }
        }

        public virtual IAttributeSetInstanceExtensionFieldStateDto[] Fields
        {
            get 
            {
                if (!(this as IStateDtoWrapper).ReturnedFieldsContains("Fields"))
                {
                    return null;
                }
                var dtos = new List<IAttributeSetInstanceExtensionFieldStateDto>();
                if (this._state.Fields != null)
                {
                    foreach (var s in this._state.Fields)
                    {
                        var dto = new AttributeSetInstanceExtensionFieldStateDtoWrapper((AttributeSetInstanceExtensionFieldState)s);
                        var returnFS = CollectionUtils.DictionaryGetValueIgnoringCase(ReturnedFields, "Fields");
                        if (!String.IsNullOrWhiteSpace(returnFS))
                        {
                            (dto as IStateDtoWrapper).ReturnedFieldsString = returnFS;
                        }
                        else
                        {
                            (dto as IStateDtoWrapper).AllFieldsReturned = this.AllFieldsReturned;
                        }
                        dtos.Add(dto);
                    }
                }
                return dtos.ToArray();
            }
            set 
            {
                if (value == null) { value = new AttributeSetInstanceExtensionFieldStateDtoWrapper[0]; }
                var states = new List<IAttributeSetInstanceExtensionFieldState>();
                foreach (var s in value)
                {
                    states.Add(s.ToAttributeSetInstanceExtensionFieldState());
                }
                this._state.SetFields(new DtoAttributeSetInstanceExtensionFieldStates(this._state, states));
            }
        }

        IAttributeSetInstanceExtensionFieldStates IAttributeSetInstanceExtensionFieldGroupState.Fields
        {
            get { return _state.Fields; }
        }


		void IAttributeSetInstanceExtensionFieldGroupState.When(IAttributeSetInstanceExtensionFieldGroupStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IAttributeSetInstanceExtensionFieldGroupState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

		void IAttributeSetInstanceExtensionFieldGroupState.When(IAttributeSetInstanceExtensionFieldGroupStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IAttributeSetInstanceExtensionFieldGroupState.When(IAttributeSetInstanceExtensionFieldGroupStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IAttributeSetInstanceExtensionFieldGroupState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


        public class DtoAttributeSetInstanceExtensionFieldStates : IAttributeSetInstanceExtensionFieldStates
        {

            private IAttributeSetInstanceExtensionFieldGroupState _outerState;

            private IEnumerable<IAttributeSetInstanceExtensionFieldState> _innerStates;

            public DtoAttributeSetInstanceExtensionFieldStates(IAttributeSetInstanceExtensionFieldGroupState outerState, IEnumerable<IAttributeSetInstanceExtensionFieldState> innerStates)
            {
                this._outerState = outerState;
                if (innerStates == null)
                {
                    this._innerStates = new IAttributeSetInstanceExtensionFieldState[] { };
                }
                else
                {
                    this._innerStates = innerStates;
                }
            }

            public IEnumerator<IAttributeSetInstanceExtensionFieldState> GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            public IAttributeSetInstanceExtensionFieldState Get(string index)
            {
                throw new NotSupportedException();
            }

            public IAttributeSetInstanceExtensionFieldState Get(string index, bool forCreation)
            {
                throw new NotSupportedException();
            }

            public void Remove(IAttributeSetInstanceExtensionFieldState state)
            {
                throw new NotSupportedException();
            }

            public void AddToSave(IAttributeSetInstanceExtensionFieldState state)
            {
                throw new NotSupportedException();
            }

            public void Save()
            {
                throw new NotSupportedException();
            }
        }

	}

    partial class AttributeSetInstanceExtensionFieldGroupStateDtoWrapperCollection : StateDtoWrapperCollectionBase<AttributeSetInstanceExtensionFieldGroupStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(AttributeSetInstanceExtensionFieldGroupStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}


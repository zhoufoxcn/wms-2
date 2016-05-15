﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public partial class AttributeSetStateDto : StateDtoBase, IAttributeSetState
	{

        internal static IList<string> _collectionFieldNames = new string[] { "AttributeUses" };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private AttributeSetState _state;

        public AttributeSetStateDto()
        {
            this._state = new AttributeSetState();
        }

		public AttributeSetStateDto(AttributeSetState state)
		{
            this._state = state;
		}

		internal AttributeSetState ToAttributeSetState()
		{
			return this._state;
		}

		public virtual string AttributeSetId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetId"))
                {
                    return _state.AttributeSetId;
                }
                return null;
            }
            set
            {
                _state.AttributeSetId = value;
            }
        }

        string IAttributeSetStateProperties.AttributeSetId
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).AttributeSetId;
            }
            set 
            {
                this._state.AttributeSetId = value;
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

        string IAttributeSetStateProperties.Name
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).Name;
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

        string IAttributeSetStateProperties.Description
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).Description;
            }
            set 
            {
                this._state.Description = value;
            }
        }

		public virtual string SerialNumberAttributeId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("SerialNumberAttributeId"))
                {
                    return _state.SerialNumberAttributeId;
                }
                return null;
            }
            set
            {
                _state.SerialNumberAttributeId = value;
            }
        }

        string IAttributeSetStateProperties.SerialNumberAttributeId
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).SerialNumberAttributeId;
            }
            set 
            {
                this._state.SerialNumberAttributeId = value;
            }
        }

		public virtual string LotAttributeId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("LotAttributeId"))
                {
                    return _state.LotAttributeId;
                }
                return null;
            }
            set
            {
                _state.LotAttributeId = value;
            }
        }

        string IAttributeSetStateProperties.LotAttributeId
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).LotAttributeId;
            }
            set 
            {
                this._state.LotAttributeId = value;
            }
        }

		public virtual string ReferenceId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("ReferenceId"))
                {
                    return _state.ReferenceId;
                }
                return null;
            }
            set
            {
                _state.ReferenceId = value;
            }
        }

        string IAttributeSetStateProperties.ReferenceId
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).ReferenceId;
            }
            set 
            {
                this._state.ReferenceId = value;
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

        bool IAttributeSetStateProperties.Active
        {
            get 
            {
                return (this._state as IAttributeSetStateProperties).Active;
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
			get { return (_state as IAttributeSetState).GlobalId; }
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
            get { return (_state as IAttributeSetState).CreatedBy; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IAttributeSetState).CreatedAt; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IAttributeSetState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IAttributeSetState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return (_state as IAttributeSetState).Version; }
		}


		#endregion




        public virtual AttributeUseStateDto[] AttributeUses
        {
            get 
            {
                if (!(this as IStateDto).ReturnedFieldsContains("AttributeUses"))
                {
                    return null;
                }
                var dtos = new List<AttributeUseStateDto>();
                if (this._state.AttributeUses != null)
                {
                    foreach (var s in this._state.AttributeUses)
                    {
                        var dto = new AttributeUseStateDto((AttributeUseState)s);
                        var returnFS = CollectionUtils.DictionaryGetValueIgnoringCase(ReturnedFields, "AttributeUses");
                        if (!String.IsNullOrWhiteSpace(returnFS))
                        {
                            (dto as IStateDto).ReturnedFieldsString = returnFS;
                        }
                        else
                        {
                            (dto as IStateDto).AllFieldsReturned = this.AllFieldsReturned;
                        }
                        dtos.Add(dto);
                    }
                }
                return dtos.ToArray();
            }
            set 
            {
                var states = new List<AttributeUseState>();
                foreach (var s in value)
                {
                    states.Add(s.ToAttributeUseState());
                }
                this._state.SetAttributeUses(new DtoAttributeUseStates(this._state, states));
            }
        }

        IAttributeUseStates IAttributeSetState.AttributeUses
        {
            get { return _state.AttributeUses; }
        }


		void IAttributeSetState.When(IAttributeSetStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IAttributeSetState.When(IAttributeSetStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IAttributeSetState.When(IAttributeSetStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IAttributeSetState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


        public class DtoAttributeUseStates : IAttributeUseStates
        {

            private IAttributeSetState _outerState;

            private IEnumerable<IAttributeUseState> _innerStates;

            public DtoAttributeUseStates(IAttributeSetState outerState, IEnumerable<IAttributeUseState> innerStates)
            {
                this._outerState = outerState;
                if (innerStates == null)
                {
                    this._innerStates = new IAttributeUseState[] { };
                }
                else
                {
                    this._innerStates = innerStates;
                }
            }

            public IEnumerator<IAttributeUseState> GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            public IAttributeUseState Get(string attributeId)
            {
                throw new NotSupportedException();
            }

            public void Remove(IAttributeUseState state)
            {
                throw new NotSupportedException();
            }

            public void Save()
            {
                throw new NotSupportedException();
            }
        }

	}

    partial class AttributeSetStateDtoCollection : StateDtoCollectionBase<AttributeSetStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(AttributeSetStateDto._collectionFieldNames, fieldName);
        }

    }

}

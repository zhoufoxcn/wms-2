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

	public partial class YearPlanMvoStateDto : StateDtoBase, IYearPlanMvoState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private YearPlanMvoState _state;

        public YearPlanMvoStateDto()
        {
            this._state = new YearPlanMvoState();
        }

		public YearPlanMvoStateDto(YearPlanMvoState state)
		{
            this._state = state;
		}

		internal YearPlanMvoState ToYearPlanMvoState()
		{
			return this._state;
		}


        public YearPlanIdDto YearPlanId
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("YearPlanId"))
                {
					return (_state.YearPlanId == null) ? null : new YearPlanIdDto(_state.YearPlanId);
                }
                return null;
            }
            set
            {
                _state.YearPlanId = (value == null) ? null : value.ToYearPlanId();
            }
        }


        YearPlanId IYearPlanMvoStateProperties.YearPlanId
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).YearPlanId;
            }
            set 
            {
                this._state.YearPlanId = value;
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

        string IYearPlanMvoStateProperties.Description
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).Description;
            }
            set 
            {
                this._state.Description = value;
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

        long IYearPlanMvoStateProperties.Version
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).Version;
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

        bool IYearPlanMvoStateProperties.Active
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).Active;
            }
            set 
            {
                this._state.Active = value;
            }
        }

		public virtual DateTime? PersonBirthDate
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("PersonBirthDate"))
                {
                    return _state.PersonBirthDate;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.PersonBirthDate = value.Value;
                }
            }
        }

        DateTime IYearPlanMvoStateProperties.PersonBirthDate
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).PersonBirthDate;
            }
            set 
            {
                this._state.PersonBirthDate = value;
            }
        }


        public PersonalNameDto PersonLoves
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("PersonLoves"))
                {
					return (_state.PersonLoves == null) ? null : new PersonalNameDto(_state.PersonLoves);
                }
                return null;
            }
            set
            {
                _state.PersonLoves = (value == null) ? null : value.ToPersonalName();
            }
        }


        PersonalName IYearPlanMvoStateProperties.PersonLoves
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).PersonLoves;
            }
            set 
            {
                this._state.PersonLoves = value;
            }
        }


        public ContactDto PersonEmergencyContact
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("PersonEmergencyContact"))
                {
					return (_state.PersonEmergencyContact == null) ? null : new ContactDto(_state.PersonEmergencyContact);
                }
                return null;
            }
            set
            {
                _state.PersonEmergencyContact = (value == null) ? null : value.ToContact();
            }
        }


        Contact IYearPlanMvoStateProperties.PersonEmergencyContact
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).PersonEmergencyContact;
            }
            set 
            {
                this._state.PersonEmergencyContact = value;
            }
        }

		public virtual string PersonCreatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("PersonCreatedBy"))
                {
                    return _state.PersonCreatedBy;
                }
                return null;
            }
            set
            {
                _state.PersonCreatedBy = value;
            }
        }

        string IYearPlanMvoStateProperties.PersonCreatedBy
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).PersonCreatedBy;
            }
            set 
            {
                this._state.PersonCreatedBy = value;
            }
        }

		public virtual DateTime? PersonCreatedAt
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("PersonCreatedAt"))
                {
                    return _state.PersonCreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.PersonCreatedAt = value.Value;
                }
            }
        }

        DateTime IYearPlanMvoStateProperties.PersonCreatedAt
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).PersonCreatedAt;
            }
            set 
            {
                this._state.PersonCreatedAt = value;
            }
        }

		public virtual string PersonUpdatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("PersonUpdatedBy"))
                {
                    return _state.PersonUpdatedBy;
                }
                return null;
            }
            set
            {
                _state.PersonUpdatedBy = value;
            }
        }

        string IYearPlanMvoStateProperties.PersonUpdatedBy
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).PersonUpdatedBy;
            }
            set 
            {
                this._state.PersonUpdatedBy = value;
            }
        }

		public virtual DateTime? PersonUpdatedAt
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("PersonUpdatedAt"))
                {
                    return _state.PersonUpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.PersonUpdatedAt = value.Value;
                }
            }
        }

        DateTime IYearPlanMvoStateProperties.PersonUpdatedAt
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).PersonUpdatedAt;
            }
            set 
            {
                this._state.PersonUpdatedAt = value;
            }
        }

		public virtual bool? PersonActive
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("PersonActive"))
                {
                    return _state.PersonActive;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.PersonActive = value.Value;
                }
            }
        }

        bool IYearPlanMvoStateProperties.PersonActive
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).PersonActive;
            }
            set 
            {
                this._state.PersonActive = value;
            }
        }

		public virtual bool? PersonDeleted
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("PersonDeleted"))
                {
                    return _state.PersonDeleted;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.PersonDeleted = value.Value;
                }
            }
        }

        bool IYearPlanMvoStateProperties.PersonDeleted
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).PersonDeleted;
            }
            set 
            {
                this._state.PersonDeleted = value;
            }
        }

		public virtual long? PersonVersion
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("PersonVersion"))
                {
                    return _state.PersonVersion;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.PersonVersion = value.Value;
                }
            }
        }

        long IYearPlanMvoStateProperties.PersonVersion
        {
            get 
            {
                return (this._state as IYearPlanMvoStateProperties).PersonVersion;
            }
            set 
            {
                this._state.PersonVersion = value;
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

		YearPlanId IGlobalIdentity<YearPlanId>.GlobalId
		{
			get { return (_state as IYearPlanMvoState).GlobalId; }
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
            get { return (_state as IYearPlanMvoState).CreatedBy; }
            set { (_state as IYearPlanMvoState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IYearPlanMvoState).CreatedAt; }
            set { (_state as IYearPlanMvoState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IYearPlanMvoState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IYearPlanMvoState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.PersonVersion; }
		}

		#endregion

        bool IYearPlanMvoState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == YearPlanMvoState.VersionZero; }
        }


		void IYearPlanMvoState.When(IYearPlanMvoStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IYearPlanMvoState.When(IYearPlanMvoStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IYearPlanMvoState.When(IYearPlanMvoStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IYearPlanMvoState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class YearPlanMvoStateDtoCollection : StateDtoCollectionBase<YearPlanMvoStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(YearPlanMvoStateDto._collectionFieldNames, fieldName);
        }

    }

}


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

	public partial class MonthPlanMvoStateDto : StateDtoBase, IMonthPlanMvoState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private MonthPlanMvoState _state;

        public MonthPlanMvoStateDto()
        {
            this._state = new MonthPlanMvoState();
        }

		public MonthPlanMvoStateDto(MonthPlanMvoState state)
		{
            this._state = state;
		}

		internal MonthPlanMvoState ToMonthPlanMvoState()
		{
			return this._state;
		}


        public MonthPlanIdDto MonthPlanId
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("MonthPlanId"))
                {
					return (_state.MonthPlanId == null) ? null : new MonthPlanIdDto(_state.MonthPlanId);
                }
                return null;
            }
            set
            {
                _state.MonthPlanId = (value == null) ? null : value.ToMonthPlanId();
            }
        }


        MonthPlanId IMonthPlanMvoStateProperties.MonthPlanId
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).MonthPlanId;
            }
            set 
            {
                this._state.MonthPlanId = value;
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

        string IMonthPlanMvoStateProperties.Description
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).Description;
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

        long IMonthPlanMvoStateProperties.Version
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).Version;
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

        bool IMonthPlanMvoStateProperties.Active
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).Active;
            }
            set 
            {
                this._state.Active = value;
            }
        }

		public virtual string YearPlanDescription
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("YearPlanDescription"))
                {
                    return _state.YearPlanDescription;
                }
                return null;
            }
            set
            {
                _state.YearPlanDescription = value;
            }
        }

        string IMonthPlanMvoStateProperties.YearPlanDescription
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).YearPlanDescription;
            }
            set 
            {
                this._state.YearPlanDescription = value;
            }
        }

		public virtual long? YearPlanVersion
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("YearPlanVersion"))
                {
                    return _state.YearPlanVersion;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.YearPlanVersion = value.Value;
                }
            }
        }

        long IMonthPlanMvoStateProperties.YearPlanVersion
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).YearPlanVersion;
            }
            set 
            {
                this._state.YearPlanVersion = value;
            }
        }

		public virtual string YearPlanCreatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("YearPlanCreatedBy"))
                {
                    return _state.YearPlanCreatedBy;
                }
                return null;
            }
            set
            {
                _state.YearPlanCreatedBy = value;
            }
        }

        string IMonthPlanMvoStateProperties.YearPlanCreatedBy
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).YearPlanCreatedBy;
            }
            set 
            {
                this._state.YearPlanCreatedBy = value;
            }
        }

		public virtual DateTime? YearPlanCreatedAt
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("YearPlanCreatedAt"))
                {
                    return _state.YearPlanCreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.YearPlanCreatedAt = value.Value;
                }
            }
        }

        DateTime IMonthPlanMvoStateProperties.YearPlanCreatedAt
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).YearPlanCreatedAt;
            }
            set 
            {
                this._state.YearPlanCreatedAt = value;
            }
        }

		public virtual string YearPlanUpdatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("YearPlanUpdatedBy"))
                {
                    return _state.YearPlanUpdatedBy;
                }
                return null;
            }
            set
            {
                _state.YearPlanUpdatedBy = value;
            }
        }

        string IMonthPlanMvoStateProperties.YearPlanUpdatedBy
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).YearPlanUpdatedBy;
            }
            set 
            {
                this._state.YearPlanUpdatedBy = value;
            }
        }

		public virtual DateTime? YearPlanUpdatedAt
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("YearPlanUpdatedAt"))
                {
                    return _state.YearPlanUpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.YearPlanUpdatedAt = value.Value;
                }
            }
        }

        DateTime IMonthPlanMvoStateProperties.YearPlanUpdatedAt
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).YearPlanUpdatedAt;
            }
            set 
            {
                this._state.YearPlanUpdatedAt = value;
            }
        }

		public virtual bool? YearPlanActive
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("YearPlanActive"))
                {
                    return _state.YearPlanActive;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.YearPlanActive = value.Value;
                }
            }
        }

        bool IMonthPlanMvoStateProperties.YearPlanActive
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).YearPlanActive;
            }
            set 
            {
                this._state.YearPlanActive = value;
            }
        }

		public virtual bool? YearPlanDeleted
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("YearPlanDeleted"))
                {
                    return _state.YearPlanDeleted;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.YearPlanDeleted = value.Value;
                }
            }
        }

        bool IMonthPlanMvoStateProperties.YearPlanDeleted
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).YearPlanDeleted;
            }
            set 
            {
                this._state.YearPlanDeleted = value;
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

        DateTime IMonthPlanMvoStateProperties.PersonBirthDate
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).PersonBirthDate;
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


        PersonalName IMonthPlanMvoStateProperties.PersonLoves
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).PersonLoves;
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


        Contact IMonthPlanMvoStateProperties.PersonEmergencyContact
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).PersonEmergencyContact;
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

        string IMonthPlanMvoStateProperties.PersonCreatedBy
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).PersonCreatedBy;
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

        DateTime IMonthPlanMvoStateProperties.PersonCreatedAt
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).PersonCreatedAt;
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

        string IMonthPlanMvoStateProperties.PersonUpdatedBy
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).PersonUpdatedBy;
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

        DateTime IMonthPlanMvoStateProperties.PersonUpdatedAt
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).PersonUpdatedAt;
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

        bool IMonthPlanMvoStateProperties.PersonActive
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).PersonActive;
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

        bool IMonthPlanMvoStateProperties.PersonDeleted
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).PersonDeleted;
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

        long IMonthPlanMvoStateProperties.PersonVersion
        {
            get 
            {
                return (this._state as IMonthPlanMvoStateProperties).PersonVersion;
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

		MonthPlanId IGlobalIdentity<MonthPlanId>.GlobalId
		{
			get { return (_state as IMonthPlanMvoState).GlobalId; }
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
            get { return (_state as IMonthPlanMvoState).CreatedBy; }
            set { (_state as IMonthPlanMvoState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IMonthPlanMvoState).CreatedAt; }
            set { (_state as IMonthPlanMvoState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IMonthPlanMvoState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IMonthPlanMvoState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.PersonVersion; }
		}

		#endregion

        bool IMonthPlanMvoState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == MonthPlanMvoState.VersionZero; }
        }


		void IMonthPlanMvoState.When(IMonthPlanMvoStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IMonthPlanMvoState.When(IMonthPlanMvoStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IMonthPlanMvoState.When(IMonthPlanMvoStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IMonthPlanMvoState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class MonthPlanMvoStateDtoCollection : StateDtoCollectionBase<MonthPlanMvoStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(MonthPlanMvoStateDto._collectionFieldNames, fieldName);
        }

    }

}


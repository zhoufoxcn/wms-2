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

	public abstract class DayPlanMvoCommandDtoBase : ICommandDto, ICreateDayPlanMvo, IMergePatchDayPlanMvo, IDeleteDayPlanMvo
	{

		DayPlanId IAggregateCommand<DayPlanId, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteDayPlanMvo)this).DayPlanId;
			}
		}


		long IAggregateCommand<DayPlanId, long>.AggregateVersion
		{
			get
			{
				return this.PersonVersion;
			}
		}

		public virtual long PersonVersion { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual DayPlanIdDto DayPlanId { get; set; }

		public virtual string Description { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string MonthPlanDescription { get; set; }

		public virtual long? MonthPlanVersion { get; set; }

		public virtual string MonthPlanCreatedBy { get; set; }

		public virtual DateTime? MonthPlanCreatedAt { get; set; }

		public virtual string MonthPlanUpdatedBy { get; set; }

		public virtual DateTime? MonthPlanUpdatedAt { get; set; }

		public virtual bool? MonthPlanActive { get; set; }

		public virtual bool? MonthPlanDeleted { get; set; }

		public virtual string YearPlanDescription { get; set; }

		public virtual long? YearPlanVersion { get; set; }

		public virtual string YearPlanCreatedBy { get; set; }

		public virtual DateTime? YearPlanCreatedAt { get; set; }

		public virtual string YearPlanUpdatedBy { get; set; }

		public virtual DateTime? YearPlanUpdatedAt { get; set; }

		public virtual bool? YearPlanActive { get; set; }

		public virtual bool? YearPlanDeleted { get; set; }

		public virtual DateTime? PersonBirthDate { get; set; }


		public virtual PersonalNameDto PersonLoves { get; set; }

        PersonalName ICreateOrMergePatchOrDeleteDayPlanMvo.PersonLoves
        {
            get 
            {
                return this.PersonLoves.ToPersonalName();
            }
            set 
            {
                this.PersonLoves = new PersonalNameDto(value);
            }
        }


		public virtual ContactDto PersonEmergencyContact { get; set; }

        Contact ICreateOrMergePatchOrDeleteDayPlanMvo.PersonEmergencyContact
        {
            get 
            {
                return this.PersonEmergencyContact.ToContact();
            }
            set 
            {
                this.PersonEmergencyContact = new ContactDto(value);
            }
        }

		public virtual string PersonCreatedBy { get; set; }

		public virtual DateTime? PersonCreatedAt { get; set; }

		public virtual string PersonUpdatedBy { get; set; }

		public virtual DateTime? PersonUpdatedAt { get; set; }

		public virtual bool? PersonActive { get; set; }

		public virtual bool? PersonDeleted { get; set; }


        DayPlanId ICreateOrMergePatchOrDeleteDayPlanMvo.DayPlanId
        {
            get 
            {
                return this.DayPlanId.ToDayPlanId();
            }
            set 
            {
                this.DayPlanId = new DayPlanIdDto(value);
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyVersionRemoved
        {
            get
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanDescriptionRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyMonthPlanDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyMonthPlanDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyMonthPlanDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanVersionRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyMonthPlanVersionRemoved
        {
            get
            {
                var b = this.IsPropertyMonthPlanVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyMonthPlanVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanCreatedByRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyMonthPlanCreatedByRemoved
        {
            get
            {
                var b = this.IsPropertyMonthPlanCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyMonthPlanCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanCreatedAtRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyMonthPlanCreatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyMonthPlanCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyMonthPlanCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanUpdatedByRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyMonthPlanUpdatedByRemoved
        {
            get
            {
                var b = this.IsPropertyMonthPlanUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyMonthPlanUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanUpdatedAtRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyMonthPlanUpdatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyMonthPlanUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyMonthPlanUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanActiveRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyMonthPlanActiveRemoved
        {
            get
            {
                var b = this.IsPropertyMonthPlanActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyMonthPlanActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyMonthPlanDeletedRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyMonthPlanDeletedRemoved
        {
            get
            {
                var b = this.IsPropertyMonthPlanDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyMonthPlanDeletedRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanDescriptionRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyYearPlanDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyYearPlanDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyYearPlanDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanVersionRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyYearPlanVersionRemoved
        {
            get
            {
                var b = this.IsPropertyYearPlanVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyYearPlanVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanCreatedByRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyYearPlanCreatedByRemoved
        {
            get
            {
                var b = this.IsPropertyYearPlanCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyYearPlanCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanCreatedAtRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyYearPlanCreatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyYearPlanCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyYearPlanCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanUpdatedByRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyYearPlanUpdatedByRemoved
        {
            get
            {
                var b = this.IsPropertyYearPlanUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyYearPlanUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanUpdatedAtRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyYearPlanUpdatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyYearPlanUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyYearPlanUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanActiveRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyYearPlanActiveRemoved
        {
            get
            {
                var b = this.IsPropertyYearPlanActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyYearPlanActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyYearPlanDeletedRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyYearPlanDeletedRemoved
        {
            get
            {
                var b = this.IsPropertyYearPlanDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyYearPlanDeletedRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonBirthDateRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyPersonBirthDateRemoved
        {
            get
            {
                var b = this.IsPropertyPersonBirthDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPersonBirthDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonLovesRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyPersonLovesRemoved
        {
            get
            {
                var b = this.IsPropertyPersonLovesRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPersonLovesRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonEmergencyContactRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyPersonEmergencyContactRemoved
        {
            get
            {
                var b = this.IsPropertyPersonEmergencyContactRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPersonEmergencyContactRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonCreatedByRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyPersonCreatedByRemoved
        {
            get
            {
                var b = this.IsPropertyPersonCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPersonCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonCreatedAtRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyPersonCreatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyPersonCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPersonCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonUpdatedByRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyPersonUpdatedByRemoved
        {
            get
            {
                var b = this.IsPropertyPersonUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPersonUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonUpdatedAtRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyPersonUpdatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyPersonUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPersonUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonActiveRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyPersonActiveRemoved
        {
            get
            {
                var b = this.IsPropertyPersonActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPersonActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyPersonDeletedRemoved { get; set; }

        bool IMergePatchDayPlanMvo.IsPropertyPersonDeletedRemoved
        {
            get
            {
                var b = this.IsPropertyPersonDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPersonDeletedRemoved = value;
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteDayPlanMvoDto : DayPlanMvoCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateDayPlanMvoDto : CreateOrMergePatchOrDeleteDayPlanMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchDayPlanMvoDto : CreateOrMergePatchOrDeleteDayPlanMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteDayPlanMvoDto : CreateOrMergePatchOrDeleteDayPlanMvoDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}





}

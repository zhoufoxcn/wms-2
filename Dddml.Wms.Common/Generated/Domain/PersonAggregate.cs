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
    public partial class PersonAggregate : AggregateBase, IPersonAggregate
    {

        readonly IPersonState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IPersonState State
        {
            get
            {
                return _state;
            }
        }

        public IList<IEvent> Changes
        {
            get
            {
                return _changes;
            }
        }

        #region IIdentity implementation

        PersonalName IGlobalIdentity<PersonalName>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public PersonAggregate(IPersonState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IPersonStateProperties)_state).Version == PersonState.VersionZero)
            {
                if (IsCommandCreate((IPersonCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IPersonCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IPersonCommand c)
        {
            return c.Version == PersonState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreatePerson c)
        {
            IPersonStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchPerson c)
        {
            IPersonStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeletePerson c)
        {
            IPersonStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IPersonStateCreated Map(ICreatePerson c)
        {
			var stateEventId = new PersonStateEventId(c.PersonalName, c.Version);
            IPersonStateCreated e = NewPersonStateCreated(stateEventId);
		
            e.BirthDate = c.BirthDate;
            e.Loves = c.Loves;
            e.EmergencyContact = c.EmergencyContact;
            e.Active = c.Active;
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var version = c.Version;

            foreach (ICreateYearPlan innerCommand in c.YearPlans)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IYearPlanStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddYearPlanEvent(innerEvent);
            }


            return e;
        }

        protected virtual IPersonStateMergePatched Map(IMergePatchPerson c)
        {
			var stateEventId = new PersonStateEventId(c.PersonalName, c.Version);
            IPersonStateMergePatched e = NewPersonStateMergePatched(stateEventId);

            e.BirthDate = c.BirthDate;
            e.Loves = c.Loves;
            e.EmergencyContact = c.EmergencyContact;
            e.Active = c.Active;
            e.IsPropertyBirthDateRemoved = c.IsPropertyBirthDateRemoved;
            e.IsPropertyLovesRemoved = c.IsPropertyLovesRemoved;
            e.IsPropertyEmergencyContactRemoved = c.IsPropertyEmergencyContactRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var version = c.Version;

            foreach (IYearPlanCommand innerCommand in c.YearPlanCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IYearPlanStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddYearPlanEvent(innerEvent);
            }


            return e;
        }

        protected virtual IPersonStateDeleted Map(IDeletePerson c)
        {
			var stateEventId = new PersonStateEventId(c.PersonalName, c.Version);
            IPersonStateDeleted e = NewPersonStateDeleted(stateEventId);
			
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;


            return e;
        }


        protected void ThrowOnInconsistentCommands(IPersonCommand command, IYearPlanCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeletePerson;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveYearPlan;
            if (properties == null || innerProperties == null) { return; }
            if (innerProperties.PersonalName == null)
            {
                innerProperties.PersonalName = properties.PersonalName;
            }
            else
            {
                var outerPersonalNameName = "PersonalName";
                var outerPersonalNameValue = properties.PersonalName;
                var innerPersonalNameName = "PersonalName";
                var innerPersonalNameValue = innerProperties.PersonalName;
                ThrowOnInconsistentIds(innerProperties, innerPersonalNameName, innerPersonalNameValue, outerPersonalNameName, outerPersonalNameValue);
            }

        }// END ThrowOnInconsistentCommands /////////////////////


        protected void ThrowOnInconsistentCommands(IYearPlanCommand command, IMonthPlanCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrRemoveYearPlan;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveMonthPlan;
            if (properties == null || innerProperties == null) { return; }
            if (innerProperties.PersonalName == null)
            {
                innerProperties.PersonalName = properties.PersonalName;
            }
            else
            {
                var outerPersonalNameName = "PersonalName";
                var outerPersonalNameValue = properties.PersonalName;
                var innerPersonalNameName = "PersonalName";
                var innerPersonalNameValue = innerProperties.PersonalName;
                ThrowOnInconsistentIds(innerProperties, innerPersonalNameName, innerPersonalNameValue, outerPersonalNameName, outerPersonalNameValue);
            }

            if (innerProperties.Year == null)
            {
                innerProperties.Year = properties.Year;
            }
            else
            {
                var outerYearName = "Year";
                var outerYearValue = properties.Year;
                var innerYearName = "Year";
                var innerYearValue = innerProperties.Year;
                ThrowOnInconsistentIds(innerProperties, innerYearName, innerYearValue, outerYearName, outerYearValue);
            }

        }// END ThrowOnInconsistentCommands /////////////////////


        protected void ThrowOnInconsistentCommands(IMonthPlanCommand command, IDayPlanCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrRemoveMonthPlan;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveDayPlan;
            if (properties == null || innerProperties == null) { return; }
            if (innerProperties.PersonalName == null)
            {
                innerProperties.PersonalName = properties.PersonalName;
            }
            else
            {
                var outerPersonalNameName = "PersonalName";
                var outerPersonalNameValue = properties.PersonalName;
                var innerPersonalNameName = "PersonalName";
                var innerPersonalNameValue = innerProperties.PersonalName;
                ThrowOnInconsistentIds(innerProperties, innerPersonalNameName, innerPersonalNameValue, outerPersonalNameName, outerPersonalNameValue);
            }

            if (innerProperties.Year == null)
            {
                innerProperties.Year = properties.Year;
            }
            else
            {
                var outerYearName = "Year";
                var outerYearValue = properties.Year;
                var innerYearName = "Year";
                var innerYearValue = innerProperties.Year;
                ThrowOnInconsistentIds(innerProperties, innerYearName, innerYearValue, outerYearName, outerYearValue);
            }

            if (innerProperties.Month == null)
            {
                innerProperties.Month = properties.Month;
            }
            else
            {
                var outerMonthName = "Month";
                var outerMonthValue = properties.Month;
                var innerMonthName = "Month";
                var innerMonthValue = innerProperties.Month;
                ThrowOnInconsistentIds(innerProperties, innerMonthName, innerMonthValue, outerMonthName, outerMonthValue);
            }

        }// END ThrowOnInconsistentCommands /////////////////////


        protected virtual IYearPlanStateEvent Map(IYearPlanCommand c, IPersonCommand outerCommand, long version, IPersonState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateYearPlan) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchYearPlan) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            var remove = (c.CommandType == CommandType.Remove) ? (c as IRemoveYearPlan) : null;
            if (remove != null)
            {
                return MapRemove(remove, outerCommand, version);
            }
            throw new NotSupportedException();
        }


        protected virtual IYearPlanStateCreated MapCreate(ICreateYearPlan c, IPersonCommand outerCommand, long version, IPersonState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new YearPlanStateEventId(c.PersonalName, c.Year, version);
            IYearPlanStateCreated e = NewYearPlanStateCreated(stateEventId);
            var s = outerState.YearPlans.Get(c.Year);

            e.Description = c.Description;
            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            foreach (ICreateMonthPlan innerCommand in c.MonthPlans)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IMonthPlanStateCreated innerEvent = MapCreate(innerCommand, c, version, s);
                e.AddMonthPlanEvent(innerEvent);
            }

            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IYearPlanStateMergePatched MapMergePatch(IMergePatchYearPlan c, IPersonCommand outerCommand, long version, IPersonState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new YearPlanStateEventId(c.PersonalName, c.Year, version);
            IYearPlanStateMergePatched e = NewYearPlanStateMergePatched(stateEventId);
            var s = outerState.YearPlans.Get(c.Year);

            e.Description = c.Description;
            e.Active = c.Active;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            foreach (IMonthPlanCommand innerCommand in c.MonthPlanCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IMonthPlanStateEvent innerEvent = Map(innerCommand, c, version, s);
                e.AddMonthPlanEvent(innerEvent);
            }

            return e;

        }// END Map(IMergePatch... ////////////////////////////


        protected virtual IYearPlanStateRemoved MapRemove(IRemoveYearPlan c, IPersonCommand outerCommand, long version)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new YearPlanStateEventId(c.PersonalName, c.Year, version);
            IYearPlanStateRemoved e = NewYearPlanStateRemoved(stateEventId);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            return e;

        }// END Map(IRemove... ////////////////////////////


        protected virtual IMonthPlanStateEvent Map(IMonthPlanCommand c, IYearPlanCommand outerCommand, long version, IYearPlanState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateMonthPlan) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchMonthPlan) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            var remove = (c.CommandType == CommandType.Remove) ? (c as IRemoveMonthPlan) : null;
            if (remove != null)
            {
                return MapRemove(remove, outerCommand, version);
            }
            throw new NotSupportedException();
        }


        protected virtual IMonthPlanStateCreated MapCreate(ICreateMonthPlan c, IYearPlanCommand outerCommand, long version, IYearPlanState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new MonthPlanStateEventId(c.PersonalName, c.Year, c.Month, version);
            IMonthPlanStateCreated e = NewMonthPlanStateCreated(stateEventId);
            var s = outerState.MonthPlans.Get(c.Month);

            e.Description = c.Description;
            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            foreach (ICreateDayPlan innerCommand in c.DayPlans)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IDayPlanStateCreated innerEvent = MapCreate(innerCommand, c, version, s);
                e.AddDayPlanEvent(innerEvent);
            }

            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IMonthPlanStateMergePatched MapMergePatch(IMergePatchMonthPlan c, IYearPlanCommand outerCommand, long version, IYearPlanState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new MonthPlanStateEventId(c.PersonalName, c.Year, c.Month, version);
            IMonthPlanStateMergePatched e = NewMonthPlanStateMergePatched(stateEventId);
            var s = outerState.MonthPlans.Get(c.Month);

            e.Description = c.Description;
            e.Active = c.Active;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            foreach (IDayPlanCommand innerCommand in c.DayPlanCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IDayPlanStateEvent innerEvent = Map(innerCommand, c, version, s);
                e.AddDayPlanEvent(innerEvent);
            }

            return e;

        }// END Map(IMergePatch... ////////////////////////////


        protected virtual IMonthPlanStateRemoved MapRemove(IRemoveMonthPlan c, IYearPlanCommand outerCommand, long version)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new MonthPlanStateEventId(c.PersonalName, c.Year, c.Month, version);
            IMonthPlanStateRemoved e = NewMonthPlanStateRemoved(stateEventId);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            return e;

        }// END Map(IRemove... ////////////////////////////


        protected virtual IDayPlanStateEvent Map(IDayPlanCommand c, IMonthPlanCommand outerCommand, long version, IMonthPlanState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateDayPlan) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchDayPlan) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            var remove = (c.CommandType == CommandType.Remove) ? (c as IRemoveDayPlan) : null;
            if (remove != null)
            {
                return MapRemove(remove, outerCommand, version);
            }
            throw new NotSupportedException();
        }


        protected virtual IDayPlanStateCreated MapCreate(ICreateDayPlan c, IMonthPlanCommand outerCommand, long version, IMonthPlanState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new DayPlanStateEventId(c.PersonalName, c.Year, c.Month, c.Day, version);
            IDayPlanStateCreated e = NewDayPlanStateCreated(stateEventId);
            var s = outerState.DayPlans.Get(c.Day);

            e.Description = c.Description;
            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IDayPlanStateMergePatched MapMergePatch(IMergePatchDayPlan c, IMonthPlanCommand outerCommand, long version, IMonthPlanState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new DayPlanStateEventId(c.PersonalName, c.Year, c.Month, c.Day, version);
            IDayPlanStateMergePatched e = NewDayPlanStateMergePatched(stateEventId);
            var s = outerState.DayPlans.Get(c.Day);

            e.Description = c.Description;
            e.Active = c.Active;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
            return e;

        }// END Map(IMergePatch... ////////////////////////////


        protected virtual IDayPlanStateRemoved MapRemove(IRemoveDayPlan c, IMonthPlanCommand outerCommand, long version)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new DayPlanStateEventId(c.PersonalName, c.Year, c.Month, c.Day, version);
            IDayPlanStateRemoved e = NewDayPlanStateRemoved(stateEventId);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

            return e;

        }// END Map(IRemove... ////////////////////////////

        private void ThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected PersonStateCreated NewPersonStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new PersonStateEventId(_state.PersonalName, ((IPersonStateProperties)_state).Version);
            var e = NewPersonStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected PersonStateMergePatched NewPersonStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new PersonStateEventId(_state.PersonalName, ((IPersonStateProperties)_state).Version);
            var e = NewPersonStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected PersonStateDeleted NewPersonStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new PersonStateEventId(_state.PersonalName, ((IPersonStateProperties)_state).Version);
            var e = NewPersonStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private PersonStateCreated NewPersonStateCreated(PersonStateEventId stateEventId)
		{
			return new PersonStateCreated(stateEventId);			
		}

        private PersonStateMergePatched NewPersonStateMergePatched(PersonStateEventId stateEventId)
		{
			return new PersonStateMergePatched(stateEventId);
		}

        private PersonStateDeleted NewPersonStateDeleted(PersonStateEventId stateEventId)
		{
			return new PersonStateDeleted(stateEventId);
		}


		private YearPlanStateCreated NewYearPlanStateCreated(YearPlanStateEventId stateEventId)
		{
			return new YearPlanStateCreated(stateEventId);
		}

        private YearPlanStateMergePatched NewYearPlanStateMergePatched(YearPlanStateEventId stateEventId)
		{
			return new YearPlanStateMergePatched(stateEventId);
		}

        private YearPlanStateRemoved NewYearPlanStateRemoved(YearPlanStateEventId stateEventId)
		{
			return new YearPlanStateRemoved(stateEventId);
		}


		private MonthPlanStateCreated NewMonthPlanStateCreated(MonthPlanStateEventId stateEventId)
		{
			return new MonthPlanStateCreated(stateEventId);
		}

        private MonthPlanStateMergePatched NewMonthPlanStateMergePatched(MonthPlanStateEventId stateEventId)
		{
			return new MonthPlanStateMergePatched(stateEventId);
		}

        private MonthPlanStateRemoved NewMonthPlanStateRemoved(MonthPlanStateEventId stateEventId)
		{
			return new MonthPlanStateRemoved(stateEventId);
		}


		private DayPlanStateCreated NewDayPlanStateCreated(DayPlanStateEventId stateEventId)
		{
			return new DayPlanStateCreated(stateEventId);
		}

        private DayPlanStateMergePatched NewDayPlanStateMergePatched(DayPlanStateEventId stateEventId)
		{
			return new DayPlanStateMergePatched(stateEventId);
		}

        private DayPlanStateRemoved NewDayPlanStateRemoved(DayPlanStateEventId stateEventId)
		{
			return new DayPlanStateRemoved(stateEventId);
		}


    }

}


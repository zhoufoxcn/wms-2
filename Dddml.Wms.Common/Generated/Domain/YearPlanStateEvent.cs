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

	public abstract class YearPlanStateEventBase : IYearPlanStateEvent
	{

		public virtual YearPlanStateEventId StateEventId { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }


		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		YearPlanStateEventId IGlobalIdentity<YearPlanStateEventId>.GlobalId {
			get {
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IYearPlanStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }

		public virtual long Version { get; set; }


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}

        protected YearPlanStateEventBase()
        {
        }

        protected YearPlanStateEventBase(YearPlanStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }

		protected IMonthPlanStateEventDao MonthPlanStateEventDao
		{
			get { return ApplicationContext.Current["MonthPlanStateEventDao"] as IMonthPlanStateEventDao; }
		}

        protected MonthPlanStateEventId NewMonthPlanStateEventId(int month)
        {
            var stateEventId = new MonthPlanStateEventId(this.StateEventId.PersonalName, this.StateEventId.Year, month, this.StateEventId.PersonVersion);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(IMonthPlanStateEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(IYearPlanStateEvent oe, IMonthPlanStateEvent e)
		{
			if (!oe.StateEventId.PersonalName.Equals(e.StateEventId.PersonalName))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id PersonalName {0} but inner id PersonalName {1}", 
					oe.StateEventId.PersonalName, e.StateEventId.PersonalName);
			}
			if (!oe.StateEventId.Year.Equals(e.StateEventId.Year))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id Year {0} but inner id Year {1}", 
					oe.StateEventId.Year, e.StateEventId.Year);
			}
		}



        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class YearPlanStateCreated : YearPlanStateEventBase, IYearPlanStateCreated, ISaveable
	{
		public YearPlanStateCreated ()
		{
		}

		public YearPlanStateCreated (YearPlanStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<MonthPlanStateEventId, IMonthPlanStateCreated> _monthPlanEvents = new Dictionary<MonthPlanStateEventId, IMonthPlanStateCreated>();
		
        private IEnumerable<IMonthPlanStateCreated> _readOnlyMonthPlanEvents;

        public virtual IEnumerable<IMonthPlanStateCreated> MonthPlanEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
					return this._monthPlanEvents.Values;
                }
                else
                {
                    if (_readOnlyMonthPlanEvents != null) { return _readOnlyMonthPlanEvents; }
                    var eventDao = MonthPlanStateEventDao;
                    var eL = new List<IMonthPlanStateCreated>();
                    foreach (var e in eventDao.FindByYearPlanStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IMonthPlanStateCreated)e);
                    }
                    return (_readOnlyMonthPlanEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddMonthPlanEvent(e);
                    }
                }
                else { this._monthPlanEvents.Clear(); }
            }
        }
	
		public virtual void AddMonthPlanEvent(IMonthPlanStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._monthPlanEvents[e.StateEventId] = e;
		}

        public virtual IMonthPlanStateCreated NewMonthPlanStateCreated(int month)
        {
            var stateEvent = new MonthPlanStateCreated(NewMonthPlanStateEventId(month));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IMonthPlanStateCreated e in this.MonthPlanEvents) {
				MonthPlanStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class YearPlanStateMergePatched : YearPlanStateEventBase, IYearPlanStateMergePatched, ISaveable
	{
		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public YearPlanStateMergePatched ()
		{
		}

		public YearPlanStateMergePatched (YearPlanStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<MonthPlanStateEventId, IMonthPlanStateEvent> _monthPlanEvents = new Dictionary<MonthPlanStateEventId, IMonthPlanStateEvent>();

	    private IEnumerable<IMonthPlanStateEvent> _readOnlyMonthPlanEvents;
		
        public virtual IEnumerable<IMonthPlanStateEvent> MonthPlanEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
					return this._monthPlanEvents.Values;
                }
                else
                {
                    if (_readOnlyMonthPlanEvents != null) { return _readOnlyMonthPlanEvents; }
                    var eventDao = MonthPlanStateEventDao;
                    var eL = new List<IMonthPlanStateEvent>();
                    foreach (var e in eventDao.FindByYearPlanStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IMonthPlanStateEvent)e);
                    }
                    return (_readOnlyMonthPlanEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddMonthPlanEvent(e);
                    }
                }
                else { this._monthPlanEvents.Clear(); }
            }
        }

		public virtual void AddMonthPlanEvent(IMonthPlanStateEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._monthPlanEvents[e.StateEventId] = e;
		}

        public virtual IMonthPlanStateCreated NewMonthPlanStateCreated(int month)
        {
            var stateEvent = new MonthPlanStateCreated(NewMonthPlanStateEventId(month));
            return stateEvent;
        }

        public virtual IMonthPlanStateMergePatched NewMonthPlanStateMergePatched(int month)
        {
            var stateEvent = new MonthPlanStateMergePatched(NewMonthPlanStateEventId(month));
            return stateEvent;
        }

        public virtual IMonthPlanStateRemoved NewMonthPlanStateRemoved(int month)
        {
            var stateEvent = new MonthPlanStateRemoved(NewMonthPlanStateEventId(month));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IMonthPlanStateEvent e in this.MonthPlanEvents) {
				MonthPlanStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class YearPlanStateRemoved : YearPlanStateEventBase, IYearPlanStateRemoved, ISaveable
	{
		public YearPlanStateRemoved ()
		{
		}

		public YearPlanStateRemoved (YearPlanStateEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }

		private Dictionary<MonthPlanStateEventId, IMonthPlanStateRemoved> _monthPlanEvents = new Dictionary<MonthPlanStateEventId, IMonthPlanStateRemoved>();
		
        private IEnumerable<IMonthPlanStateRemoved> _readOnlyMonthPlanEvents;

        public virtual IEnumerable<IMonthPlanStateRemoved> MonthPlanEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
					return this._monthPlanEvents.Values;
                }
                else
                {
                    if (_readOnlyMonthPlanEvents != null) { return _readOnlyMonthPlanEvents; }
                    var eventDao = MonthPlanStateEventDao;
                    var eL = new List<IMonthPlanStateRemoved>();
                    foreach (var e in eventDao.FindByYearPlanStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IMonthPlanStateRemoved)e);
                    }
                    return (_readOnlyMonthPlanEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddMonthPlanEvent(e);
                    }
                }
                else { this._monthPlanEvents.Clear(); }
            }
        }
	
		public virtual void AddMonthPlanEvent(IMonthPlanStateRemoved e)
		{
			ThrowOnInconsistentEventIds(e);
			this._monthPlanEvents[e.StateEventId] = e;
		}

        public virtual IMonthPlanStateRemoved NewMonthPlanStateRemoved(int month)
        {
            var stateEvent = new MonthPlanStateRemoved(NewMonthPlanStateEventId(month));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IMonthPlanStateRemoved e in this.MonthPlanEvents) {
				MonthPlanStateEventDao.Save(e);
			}
		}


	}



}


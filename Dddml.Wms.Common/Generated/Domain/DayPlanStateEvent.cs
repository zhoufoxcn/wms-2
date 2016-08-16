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

	public abstract class DayPlanStateEventBase : IDayPlanStateEvent
	{

		public virtual DayPlanStateEventId StateEventId { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }


		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		DayPlanStateEventId IGlobalIdentity<DayPlanStateEventId>.GlobalId {
			get {
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IDayPlanStateEvent.ReadOnly
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

        protected DayPlanStateEventBase()
        {
        }

        protected DayPlanStateEventBase(DayPlanStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class DayPlanStateCreated : DayPlanStateEventBase, IDayPlanStateCreated
	{
		public DayPlanStateCreated ()
		{
		}

		public DayPlanStateCreated (DayPlanStateEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class DayPlanStateMergePatched : DayPlanStateEventBase, IDayPlanStateMergePatched
	{
		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public DayPlanStateMergePatched ()
		{
		}

		public DayPlanStateMergePatched (DayPlanStateEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class DayPlanStateRemoved : DayPlanStateEventBase, IDayPlanStateRemoved
	{
		public DayPlanStateRemoved ()
		{
		}

		public DayPlanStateRemoved (DayPlanStateEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}


﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{

	public abstract class InOutLineStateEventBase : IInOutLineStateEvent
	{

		public virtual InOutLineStateEventId StateEventId { get; set; }

		public virtual string Description { get; set; }

		public virtual string LocatorId { get; set; }

		public virtual string ProductId { get; set; }

		public virtual string UomId { get; set; }

		public virtual decimal? MovementQuantity { get; set; }

		public virtual decimal? ConfirmedQuantity { get; set; }

		public virtual decimal? ScrappedQuantity { get; set; }

		public virtual decimal? TargetQuantity { get; set; }

		public virtual decimal? PickedQuantity { get; set; }

		public virtual bool? IsInvoiced { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual bool? IsDescription { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual decimal? QuantityEntered { get; set; }

		public virtual long? RmaLineNumber { get; set; }

		public virtual long? ReversalLineNumber { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InOutLineStateEventId IGlobalIdentity<InOutLineStateEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IInOutLineStateEvent.ReadOnly
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

        protected InOutLineStateEventBase()
        {
        }

        protected InOutLineStateEventBase(InOutLineStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class InOutLineStateCreated : InOutLineStateEventBase, IInOutLineStateCreated
	{
		public InOutLineStateCreated ()
		{
		}

		public InOutLineStateCreated (InOutLineStateEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class InOutLineStateMergePatched : InOutLineStateEventBase, IInOutLineStateMergePatched
	{
		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyLocatorIdRemoved { get; set; }

		public virtual bool IsPropertyProductIdRemoved { get; set; }

		public virtual bool IsPropertyUomIdRemoved { get; set; }

		public virtual bool IsPropertyMovementQuantityRemoved { get; set; }

		public virtual bool IsPropertyConfirmedQuantityRemoved { get; set; }

		public virtual bool IsPropertyScrappedQuantityRemoved { get; set; }

		public virtual bool IsPropertyTargetQuantityRemoved { get; set; }

		public virtual bool IsPropertyPickedQuantityRemoved { get; set; }

		public virtual bool IsPropertyIsInvoicedRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		public virtual bool IsPropertyIsDescriptionRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyQuantityEnteredRemoved { get; set; }

		public virtual bool IsPropertyRmaLineNumberRemoved { get; set; }

		public virtual bool IsPropertyReversalLineNumberRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public InOutLineStateMergePatched ()
		{
		}

		public InOutLineStateMergePatched (InOutLineStateEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class InOutLineStateRemoved : InOutLineStateEventBase, IInOutLineStateRemoved
	{
		public InOutLineStateRemoved ()
		{
		}

		public InOutLineStateRemoved (InOutLineStateEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}


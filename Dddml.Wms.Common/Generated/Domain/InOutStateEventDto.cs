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

	public abstract class InOutStateEventDtoBase : IStateEventDto, IInOutStateCreated, IInOutStateMergePatched, IInOutStateDeleted
	{

        private InOutStateEventIdDto _stateEventId;

		protected internal virtual InOutStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new InOutStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string DocumentNumber
        {
            get { return StateEventId.DocumentNumber; }
            set { StateEventId.DocumentNumber = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
        }

		public virtual bool? IsSOTransaction { get; set; }

		public virtual string DocumentStatus { get; set; }

		public virtual bool? Posted { get; set; }

		public virtual bool? Processing { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual int? DocumentType { get; set; }

		public virtual string Description { get; set; }

		public virtual string OrderNumber { get; set; }

		public virtual DateTime? DateOrdered { get; set; }

		public virtual bool? IsPrinted { get; set; }

		public virtual string MovementType { get; set; }

		public virtual DateTime? MovementDate { get; set; }

		public virtual string BusinessPartnerId { get; set; }

		public virtual string WarehouseId { get; set; }

		public virtual string POReference { get; set; }

		public virtual Money? FreightAmount { get; set; }

		public virtual string ShipperId { get; set; }

		public virtual Money? ChargeAmount { get; set; }

		public virtual DateTime? DatePrinted { get; set; }

		public virtual string SalesRepresentative { get; set; }

		public virtual int? NumberOfPackages { get; set; }

		public virtual DateTime? PickDate { get; set; }

		public virtual DateTime? ShipDate { get; set; }

		public virtual string TrackingNumber { get; set; }

		public virtual DateTime? DateReceived { get; set; }

		public virtual bool? IsInTransit { get; set; }

		public virtual bool? IsApproved { get; set; }

		public virtual bool? IsInDispute { get; set; }

		public virtual decimal? Volume { get; set; }

		public virtual decimal? Weight { get; set; }

		public virtual string RmaNumber { get; set; }

		public virtual string ReversalNumber { get; set; }

		public virtual bool? IsDropShip { get; set; }

		public virtual string DropShipBusinessPartnerId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InOutStateEventId IGlobalIdentity<InOutStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToInOutStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IInOutStateEvent.ReadOnly
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

		public virtual bool? IsPropertyIsSOTransactionRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyIsSOTransactionRemoved
        {
            get 
            {
                var b = this.IsPropertyIsSOTransactionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsSOTransactionRemoved = value;
            }
        }

		public virtual bool? IsPropertyDocumentStatusRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDocumentStatusRemoved
        {
            get 
            {
                var b = this.IsPropertyDocumentStatusRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDocumentStatusRemoved = value;
            }
        }

		public virtual bool? IsPropertyPostedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyPostedRemoved
        {
            get 
            {
                var b = this.IsPropertyPostedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPostedRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessingRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyProcessingRemoved
        {
            get 
            {
                var b = this.IsPropertyProcessingRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProcessingRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyProcessedRemoved
        {
            get 
            {
                var b = this.IsPropertyProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyDocumentTypeRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDocumentTypeRemoved
        {
            get 
            {
                var b = this.IsPropertyDocumentTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDocumentTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderNumberRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyOrderNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyOrderNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOrderNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyDateOrderedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDateOrderedRemoved
        {
            get 
            {
                var b = this.IsPropertyDateOrderedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDateOrderedRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsPrintedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyIsPrintedRemoved
        {
            get 
            {
                var b = this.IsPropertyIsPrintedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsPrintedRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementTypeRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyMovementTypeRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementDateRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyMovementDateRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyBusinessPartnerIdRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyBusinessPartnerIdRemoved
        {
            get 
            {
                var b = this.IsPropertyBusinessPartnerIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyBusinessPartnerIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyWarehouseIdRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyWarehouseIdRemoved
        {
            get 
            {
                var b = this.IsPropertyWarehouseIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyWarehouseIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPOReferenceRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyPOReferenceRemoved
        {
            get 
            {
                var b = this.IsPropertyPOReferenceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPOReferenceRemoved = value;
            }
        }

		public virtual bool? IsPropertyFreightAmountRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyFreightAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyFreightAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyFreightAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipperIdRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyShipperIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipperIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipperIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyChargeAmountRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyChargeAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyChargeAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyChargeAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyDatePrintedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDatePrintedRemoved
        {
            get 
            {
                var b = this.IsPropertyDatePrintedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDatePrintedRemoved = value;
            }
        }

		public virtual bool? IsPropertySalesRepresentativeRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertySalesRepresentativeRemoved
        {
            get 
            {
                var b = this.IsPropertySalesRepresentativeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySalesRepresentativeRemoved = value;
            }
        }

		public virtual bool? IsPropertyNumberOfPackagesRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyNumberOfPackagesRemoved
        {
            get 
            {
                var b = this.IsPropertyNumberOfPackagesRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyNumberOfPackagesRemoved = value;
            }
        }

		public virtual bool? IsPropertyPickDateRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyPickDateRemoved
        {
            get 
            {
                var b = this.IsPropertyPickDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPickDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipDateRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyShipDateRemoved
        {
            get 
            {
                var b = this.IsPropertyShipDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyTrackingNumberRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyTrackingNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyTrackingNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyTrackingNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyDateReceivedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDateReceivedRemoved
        {
            get 
            {
                var b = this.IsPropertyDateReceivedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDateReceivedRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInTransitRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyIsInTransitRemoved
        {
            get 
            {
                var b = this.IsPropertyIsInTransitRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsInTransitRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsApprovedRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyIsApprovedRemoved
        {
            get 
            {
                var b = this.IsPropertyIsApprovedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsApprovedRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInDisputeRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyIsInDisputeRemoved
        {
            get 
            {
                var b = this.IsPropertyIsInDisputeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsInDisputeRemoved = value;
            }
        }

		public virtual bool? IsPropertyVolumeRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyVolumeRemoved
        {
            get 
            {
                var b = this.IsPropertyVolumeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVolumeRemoved = value;
            }
        }

		public virtual bool? IsPropertyWeightRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyWeightRemoved
        {
            get 
            {
                var b = this.IsPropertyWeightRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyWeightRemoved = value;
            }
        }

		public virtual bool? IsPropertyRmaNumberRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyRmaNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyRmaNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyRmaNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyReversalNumberRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyReversalNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyReversalNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyReversalNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsDropShipRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyIsDropShipRemoved
        {
            get 
            {
                var b = this.IsPropertyIsDropShipRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsDropShipRemoved = value;
            }
        }

		public virtual bool? IsPropertyDropShipBusinessPartnerIdRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyDropShipBusinessPartnerIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDropShipBusinessPartnerIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDropShipBusinessPartnerIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IInOutStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

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


        private InOutLineStateCreatedOrMergePatchedOrRemovedDtos _inOutLineEvents = new InOutLineStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual InOutLineStateCreatedOrMergePatchedOrRemovedDto[] InOutLineEvents
        {
            get
            {
                return _inOutLineEvents.ToArray();
            }
            set
            {
                _inOutLineEvents.Clear();
                _inOutLineEvents.AddRange(value);
            }
        }



        private InOutLineStateEventIdDto NewInOutLineStateEventId(long lineNumber)
        {
            var eId = new InOutLineStateEventIdDto();
            eId.InOutDocumentNumber = this.StateEventId.DocumentNumber;
            eId.LineNumber = lineNumber;
            eId.InOutVersion = this.StateEventId.Version;
            return eId;
        }

        public virtual InOutLineStateCreatedDto NewInOutLineStateCreated(long lineNumber)
        {
            var e = new InOutLineStateCreatedDto();
            var eId = NewInOutLineStateEventId(lineNumber);
            e.StateEventId = eId;
            return e;
        }

        public virtual InOutLineStateMergePatchedDto NewInOutLineStateMergePatched(long lineNumber)
        {
            var e = new InOutLineStateMergePatchedDto();
            var eId = NewInOutLineStateEventId(lineNumber);
            e.StateEventId = eId;
            return e;
        }

        public virtual InOutLineStateRemovedDto NewInOutLineStateRemoved(long lineNumber)
        {
            var e = new InOutLineStateRemovedDto();
            var eId = NewInOutLineStateEventId(lineNumber);
            e.StateEventId = eId;
            return e;
        }

        IEnumerable<IInOutLineStateCreated> IInOutStateCreated.InOutLineEvents
        {
            get { return this._inOutLineEvents; }
        }

        void IInOutStateCreated.AddInOutLineEvent(IInOutLineStateCreated e)
        {
            this._inOutLineEvents.AddInOutLineEvent(e);
        }

        IInOutLineStateCreated IInOutStateCreated.NewInOutLineStateCreated(long lineNumber)
        {
            return NewInOutLineStateCreated(lineNumber);
        }

        IEnumerable<IInOutLineStateEvent> IInOutStateMergePatched.InOutLineEvents
        {
            get { return this._inOutLineEvents; }
        }

        void IInOutStateMergePatched.AddInOutLineEvent(IInOutLineStateEvent e)
        {
            this._inOutLineEvents.AddInOutLineEvent(e);
        }

        IInOutLineStateCreated IInOutStateMergePatched.NewInOutLineStateCreated(long lineNumber)
        {
            return NewInOutLineStateCreated(lineNumber);
        }

        IInOutLineStateMergePatched IInOutStateMergePatched.NewInOutLineStateMergePatched(long lineNumber)
        {
            return NewInOutLineStateMergePatched(lineNumber);
        }

        IInOutLineStateRemoved IInOutStateMergePatched.NewInOutLineStateRemoved(long lineNumber)
        {
            return NewInOutLineStateRemoved(lineNumber);
        }


        IEnumerable<IInOutLineStateRemoved> IInOutStateDeleted.InOutLineEvents
        {
            get { return this._inOutLineEvents; }
        }

        void IInOutStateDeleted.AddInOutLineEvent(IInOutLineStateRemoved e)
        {
            this._inOutLineEvents.AddInOutLineEvent(e);
        }

        IInOutLineStateRemoved IInOutStateDeleted.NewInOutLineStateRemoved(long lineNumber)
        {
            return NewInOutLineStateRemoved(lineNumber);
        }



        InOutStateEventId IInOutStateEvent.StateEventId
        {
            get { return this.StateEventId.ToInOutStateEventId(); }
        }

        protected InOutStateEventDtoBase()
        {
        }

        protected InOutStateEventDtoBase(InOutStateEventIdDto stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class InOutStateCreatedOrMergePatchedOrDeletedDto : InOutStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class InOutStateCreatedDto : InOutStateCreatedOrMergePatchedOrDeletedDto
	{
		public InOutStateCreatedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class InOutStateMergePatchedDto : InOutStateCreatedOrMergePatchedOrDeletedDto
	{
		public InOutStateMergePatchedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class InOutStateDeletedDto : InOutStateCreatedOrMergePatchedOrDeletedDto
	{
		public InOutStateDeletedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class InOutStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IInOutStateCreated>, IEnumerable<IInOutStateMergePatched>, IEnumerable<IInOutStateDeleted>
    {
        private List<InOutStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<InOutStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual InOutStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<InOutStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInOutStateCreated> IEnumerable<IInOutStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInOutStateMergePatched> IEnumerable<IInOutStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInOutStateDeleted> IEnumerable<IInOutStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddInOutEvent(IInOutStateCreated e)
        {
            _innerStateEvents.Add((InOutStateCreatedDto)e);
        }

        public void AddInOutEvent(IInOutStateEvent e)
        {
            _innerStateEvents.Add((InOutStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddInOutEvent(IInOutStateDeleted e)
        {
            _innerStateEvents.Add((InOutStateDeletedDto)e);
        }

    }


}


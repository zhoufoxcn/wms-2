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

	public abstract class InOutLineStateEventDtoBase : IStateEventDto, IInOutLineStateCreated, IInOutLineStateMergePatched, IInOutLineStateRemoved
	{

        private InOutLineStateEventIdDto _stateEventId;

		protected internal virtual InOutLineStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new InOutLineStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual SkuIdDto SkuId
        {
            get { return StateEventId.SkuId; }
            set { StateEventId.SkuId = value; }
        }

		public virtual long? LineNumber { get; set; }

		public virtual string Description { get; set; }

		public virtual string LocatorId { get; set; }

		public virtual string Product { get; set; }

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
				return this.StateEventId.ToInOutLineStateEventId();
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

		public virtual bool? IsPropertyLineNumberRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyLineNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyLocatorIdRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyLocatorIdRemoved
        {
            get 
            {
                var b = this.IsPropertyLocatorIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLocatorIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyProductRemoved
        {
            get 
            {
                var b = this.IsPropertyProductRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductRemoved = value;
            }
        }

		public virtual bool? IsPropertyUomIdRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementQuantityRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyMovementQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyConfirmedQuantityRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyConfirmedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyConfirmedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyConfirmedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyScrappedQuantityRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyScrappedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyScrappedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyScrappedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyTargetQuantityRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyTargetQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyTargetQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyTargetQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyPickedQuantityRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyPickedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyPickedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPickedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInvoicedRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyIsInvoicedRemoved
        {
            get 
            {
                var b = this.IsPropertyIsInvoicedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsInvoicedRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetInstanceIdRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyAttributeSetInstanceIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetInstanceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetInstanceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsDescriptionRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyIsDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyIsDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyProcessedRemoved
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

		public virtual bool? IsPropertyQuantityEnteredRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyQuantityEnteredRemoved
        {
            get 
            {
                var b = this.IsPropertyQuantityEnteredRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyQuantityEnteredRemoved = value;
            }
        }

		public virtual bool? IsPropertyRmaLineNumberRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyRmaLineNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyRmaLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyRmaLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyReversalLineNumberRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyReversalLineNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyReversalLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyReversalLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IInOutLineStateMergePatched.IsPropertyActiveRemoved
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


        InOutLineStateEventId IInOutLineStateEvent.StateEventId
        {
            get { return this.StateEventId.ToInOutLineStateEventId(); }
        }

        protected InOutLineStateEventDtoBase()
        {
        }

        protected InOutLineStateEventDtoBase(InOutLineStateEventIdDto stateEventId)
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


    public class InOutLineStateCreatedOrMergePatchedOrRemovedDto : InOutLineStateEventDtoBase
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



	public class InOutLineStateCreatedDto : InOutLineStateCreatedOrMergePatchedOrRemovedDto
	{
		public InOutLineStateCreatedDto()
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


	public class InOutLineStateMergePatchedDto : InOutLineStateCreatedOrMergePatchedOrRemovedDto
	{
		public InOutLineStateMergePatchedDto()
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


	public class InOutLineStateRemovedDto : InOutLineStateCreatedOrMergePatchedOrRemovedDto
	{
		public InOutLineStateRemovedDto()
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
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }

	}


    public partial class InOutLineStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IInOutLineStateCreated>, IEnumerable<IInOutLineStateMergePatched>, IEnumerable<IInOutLineStateRemoved>
    {
        private List<InOutLineStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<InOutLineStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual InOutLineStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<InOutLineStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInOutLineStateCreated> IEnumerable<IInOutLineStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInOutLineStateMergePatched> IEnumerable<IInOutLineStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInOutLineStateRemoved> IEnumerable<IInOutLineStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddInOutLineEvent(IInOutLineStateCreated e)
        {
            _innerStateEvents.Add((InOutLineStateCreatedDto)e);
        }

        public void AddInOutLineEvent(IInOutLineStateEvent e)
        {
            _innerStateEvents.Add((InOutLineStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddInOutLineEvent(IInOutLineStateRemoved e)
        {
            _innerStateEvents.Add((InOutLineStateRemovedDto)e);
        }

    }


}


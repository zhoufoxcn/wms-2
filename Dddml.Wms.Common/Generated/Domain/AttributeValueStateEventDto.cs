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

	public abstract class AttributeValueStateEventDtoBase : IStateEventDto, IAttributeValueStateCreated, IAttributeValueStateMergePatched, IAttributeValueStateRemoved
	{

        private AttributeValueStateEventIdDto _stateEventId;

		protected internal virtual AttributeValueStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new AttributeValueStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string Value
        {
            get { return StateEventId.Value; }
            set { StateEventId.Value = value; }
        }

		public virtual string Name { get; set; }

		public virtual string Description { get; set; }

		public virtual string ReferenceId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeValueStateEventId IGlobalIdentity<AttributeValueStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToAttributeValueStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeValueStateEvent.ReadOnly
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

		public virtual bool? IsPropertyNameRemoved { get; set; }

        bool IAttributeValueStateMergePatched.IsPropertyNameRemoved
        {
            get 
            {
                var b = this.IsPropertyNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IAttributeValueStateMergePatched.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyReferenceIdRemoved { get; set; }

        bool IAttributeValueStateMergePatched.IsPropertyReferenceIdRemoved
        {
            get 
            {
                var b = this.IsPropertyReferenceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyReferenceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IAttributeValueStateMergePatched.IsPropertyActiveRemoved
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


        AttributeValueStateEventId IAttributeValueStateEvent.StateEventId
        {
            get { return this.StateEventId.ToAttributeValueStateEventId(); }
        }

        protected AttributeValueStateEventDtoBase()
        {
        }

        protected AttributeValueStateEventDtoBase(AttributeValueStateEventIdDto stateEventId)
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


    public class AttributeValueStateCreatedOrMergePatchedOrRemovedDto : AttributeValueStateEventDtoBase
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



	public class AttributeValueStateCreatedDto : AttributeValueStateCreatedOrMergePatchedOrRemovedDto
	{
		public AttributeValueStateCreatedDto()
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


	public class AttributeValueStateMergePatchedDto : AttributeValueStateCreatedOrMergePatchedOrRemovedDto
	{
		public AttributeValueStateMergePatchedDto()
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


	public class AttributeValueStateRemovedDto : AttributeValueStateCreatedOrMergePatchedOrRemovedDto
	{
		public AttributeValueStateRemovedDto()
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


    public partial class AttributeValueStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IAttributeValueStateCreated>, IEnumerable<IAttributeValueStateMergePatched>, IEnumerable<IAttributeValueStateRemoved>
    {
        private List<AttributeValueStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<AttributeValueStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual AttributeValueStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<AttributeValueStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeValueStateCreated> IEnumerable<IAttributeValueStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeValueStateMergePatched> IEnumerable<IAttributeValueStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeValueStateRemoved> IEnumerable<IAttributeValueStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddAttributeValueEvent(IAttributeValueStateCreated e)
        {
            _innerStateEvents.Add((AttributeValueStateCreatedDto)e);
        }

        public void AddAttributeValueEvent(IAttributeValueStateEvent e)
        {
            _innerStateEvents.Add((AttributeValueStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddAttributeValueEvent(IAttributeValueStateRemoved e)
        {
            _innerStateEvents.Add((AttributeValueStateRemovedDto)e);
        }

    }


}


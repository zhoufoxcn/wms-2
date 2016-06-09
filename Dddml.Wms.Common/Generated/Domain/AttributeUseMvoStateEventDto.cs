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

	public abstract class AttributeUseMvoStateEventDtoBase : IStateEventDto, IAttributeUseMvoStateCreated, IAttributeUseMvoStateMergePatched, IAttributeUseMvoStateDeleted
	{

		public virtual AttributeUseMvoStateEventIdDto StateEventId { get; set; }

		public virtual int? SequenceNumber { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string AttributeSetName { get; set; }

		public virtual string AttributeSetOrganizationId { get; set; }

		public virtual string AttributeSetDescription { get; set; }

		public virtual string AttributeSetSerialNumberAttributeId { get; set; }

		public virtual string AttributeSetLotAttributeId { get; set; }

		public virtual string AttributeSetReferenceId { get; set; }

		public virtual string AttributeSetCreatedBy { get; set; }

		public virtual DateTime? AttributeSetCreatedAt { get; set; }

		public virtual string AttributeSetUpdatedBy { get; set; }

		public virtual DateTime? AttributeSetUpdatedAt { get; set; }

		public virtual bool? AttributeSetActive { get; set; }

		public virtual bool? AttributeSetDeleted { get; set; }


		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		AttributeUseMvoStateEventId IGlobalIdentity<AttributeUseMvoStateEventId>.GlobalId {
			get {
				return this.StateEventId.ToAttributeUseMvoStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeUseMvoStateEvent.ReadOnly
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

		public virtual bool? IsPropertySequenceNumberRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertySequenceNumberRemoved
        {
            get 
            {
                var b = this.IsPropertySequenceNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySequenceNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyVersionRemoved
        {
            get 
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyActiveRemoved
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

		public virtual bool? IsPropertyAttributeSetNameRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyAttributeSetNameRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetOrganizationIdRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyAttributeSetOrganizationIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetOrganizationIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetOrganizationIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetDescriptionRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyAttributeSetDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetSerialNumberAttributeIdRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyAttributeSetSerialNumberAttributeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetSerialNumberAttributeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetSerialNumberAttributeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetLotAttributeIdRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyAttributeSetLotAttributeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetLotAttributeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetLotAttributeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetReferenceIdRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyAttributeSetReferenceIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetReferenceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetReferenceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetCreatedByRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyAttributeSetCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetCreatedAtRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyAttributeSetCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetUpdatedByRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyAttributeSetUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetUpdatedAtRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyAttributeSetUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetActiveRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyAttributeSetActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetDeletedRemoved { get; set; }

        bool IAttributeUseMvoStateMergePatched.IsPropertyAttributeSetDeletedRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetDeletedRemoved = value;
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


        AttributeUseMvoStateEventId IAttributeUseMvoStateEvent.StateEventId
        {
            get { return this.StateEventId.ToAttributeUseMvoStateEventId(); }
        }

        protected AttributeUseMvoStateEventDtoBase()
        {
        }

        protected AttributeUseMvoStateEventDtoBase(AttributeUseMvoStateEventIdDto stateEventId)
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


    public class AttributeUseMvoStateCreatedOrMergePatchedOrDeletedDto : AttributeUseMvoStateEventDtoBase
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



	public class AttributeUseMvoStateCreatedDto : AttributeUseMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeUseMvoStateCreatedDto()
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


	public class AttributeUseMvoStateMergePatchedDto : AttributeUseMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeUseMvoStateMergePatchedDto()
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


	public class AttributeUseMvoStateDeletedDto : AttributeUseMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeUseMvoStateDeletedDto()
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


    public partial class AttributeUseMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IAttributeUseMvoStateCreated>, IEnumerable<IAttributeUseMvoStateMergePatched>, IEnumerable<IAttributeUseMvoStateDeleted>
    {
        private List<AttributeUseMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<AttributeUseMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual AttributeUseMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<AttributeUseMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        public IEnumerator<IAttributeUseMvoStateCreated> GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeUseMvoStateMergePatched> IEnumerable<IAttributeUseMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeUseMvoStateDeleted> IEnumerable<IAttributeUseMvoStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddAttributeUseMvoEvent(IAttributeUseMvoStateCreated e)
        {
            _innerStateEvents.Add((AttributeUseMvoStateCreatedDto)e);
        }

        public void AddAttributeUseMvoEvent(IAttributeUseMvoStateEvent e)
        {
            _innerStateEvents.Add((AttributeUseMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddAttributeUseMvoEvent(IAttributeUseMvoStateDeleted e)
        {
            _innerStateEvents.Add((AttributeUseMvoStateDeletedDto)e);
        }

    }


}

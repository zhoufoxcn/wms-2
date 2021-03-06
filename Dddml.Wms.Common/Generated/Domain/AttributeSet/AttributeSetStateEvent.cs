﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeSet
{

	public abstract class AttributeSetStateEventBase : IAttributeSetStateEvent
	{

		public virtual AttributeSetStateEventId StateEventId { get; set; }

		public virtual string Name { get; set; }

		public virtual string OrganizationId { get; set; }

		public virtual string Description { get; set; }

		public virtual string SerialNumberAttributeId { get; set; }

		public virtual string LotAttributeId { get; set; }

		public virtual string ReferenceId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeSetStateEventId IGlobalIdentity<AttributeSetStateEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeSetStateEvent.ReadOnly
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

        protected AttributeSetStateEventBase()
        {
        }

        protected AttributeSetStateEventBase(AttributeSetStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }

		protected IAttributeUseStateEventDao AttributeUseStateEventDao
		{
			get { return ApplicationContext.Current["AttributeUseStateEventDao"] as IAttributeUseStateEventDao; }
		}

        protected AttributeUseStateEventId NewAttributeUseStateEventId(string attributeId)
        {
            var stateEventId = new AttributeUseStateEventId(this.StateEventId.AttributeSetId, attributeId, this.StateEventId.Version);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(IAttributeUseStateEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(IAttributeSetStateEvent oe, IAttributeUseStateEvent e)
		{
			if (!oe.StateEventId.AttributeSetId.Equals(e.StateEventId.AttributeSetId))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id AttributeSetId {0} but inner id AttributeSetId {1}", 
					oe.StateEventId.AttributeSetId, e.StateEventId.AttributeSetId);
			}
		}



        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class AttributeSetStateCreated : AttributeSetStateEventBase, IAttributeSetStateCreated, ISaveable
	{
		public AttributeSetStateCreated ()
		{
		}

		public AttributeSetStateCreated (AttributeSetStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<AttributeUseStateEventId, IAttributeUseStateCreated> _attributeUseEvents = new Dictionary<AttributeUseStateEventId, IAttributeUseStateCreated>();
        
        private IEnumerable<IAttributeUseStateCreated> _readOnlyAttributeUseEvents;

        public virtual IEnumerable<IAttributeUseStateCreated> AttributeUseEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
                    return this._attributeUseEvents.Values;
                }
                else
                {
                    if (_readOnlyAttributeUseEvents != null) { return _readOnlyAttributeUseEvents; }
                    var eventDao = AttributeUseStateEventDao;
                    var eL = new List<IAttributeUseStateCreated>();
                    foreach (var e in eventDao.FindByAttributeSetStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IAttributeUseStateCreated)e);
                    }
                    return (_readOnlyAttributeUseEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddAttributeUseEvent(e);
                    }
                }
                else { this._attributeUseEvents.Clear(); }
            }
        }
    
		public virtual void AddAttributeUseEvent(IAttributeUseStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._attributeUseEvents[e.StateEventId] = e;
		}

        public virtual IAttributeUseStateCreated NewAttributeUseStateCreated(string attributeId)
        {
            var stateEvent = new AttributeUseStateCreated(NewAttributeUseStateEventId(attributeId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IAttributeUseStateCreated e in this.AttributeUseEvents) {
				AttributeUseStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class AttributeSetStateMergePatched : AttributeSetStateEventBase, IAttributeSetStateMergePatched, ISaveable
	{
		public virtual bool IsPropertyNameRemoved { get; set; }

		public virtual bool IsPropertyOrganizationIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertySerialNumberAttributeIdRemoved { get; set; }

		public virtual bool IsPropertyLotAttributeIdRemoved { get; set; }

		public virtual bool IsPropertyReferenceIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public AttributeSetStateMergePatched ()
		{
		}

		public AttributeSetStateMergePatched (AttributeSetStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<AttributeUseStateEventId, IAttributeUseStateEvent> _attributeUseEvents = new Dictionary<AttributeUseStateEventId, IAttributeUseStateEvent>();

        private IEnumerable<IAttributeUseStateEvent> _readOnlyAttributeUseEvents;
        
        public virtual IEnumerable<IAttributeUseStateEvent> AttributeUseEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
                    return this._attributeUseEvents.Values;
                }
                else
                {
                    if (_readOnlyAttributeUseEvents != null) { return _readOnlyAttributeUseEvents; }
                    var eventDao = AttributeUseStateEventDao;
                    var eL = new List<IAttributeUseStateEvent>();
                    foreach (var e in eventDao.FindByAttributeSetStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IAttributeUseStateEvent)e);
                    }
                    return (_readOnlyAttributeUseEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddAttributeUseEvent(e);
                    }
                }
                else { this._attributeUseEvents.Clear(); }
            }
        }

		public virtual void AddAttributeUseEvent(IAttributeUseStateEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._attributeUseEvents[e.StateEventId] = e;
		}

        public virtual IAttributeUseStateCreated NewAttributeUseStateCreated(string attributeId)
        {
            var stateEvent = new AttributeUseStateCreated(NewAttributeUseStateEventId(attributeId));
            return stateEvent;
        }

        public virtual IAttributeUseStateMergePatched NewAttributeUseStateMergePatched(string attributeId)
        {
            var stateEvent = new AttributeUseStateMergePatched(NewAttributeUseStateEventId(attributeId));
            return stateEvent;
        }

        public virtual IAttributeUseStateRemoved NewAttributeUseStateRemoved(string attributeId)
        {
            var stateEvent = new AttributeUseStateRemoved(NewAttributeUseStateEventId(attributeId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IAttributeUseStateEvent e in this.AttributeUseEvents) {
				AttributeUseStateEventDao.Save(e);
			}
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class AttributeSetStateDeleted : AttributeSetStateEventBase, IAttributeSetStateDeleted, ISaveable
	{
		public AttributeSetStateDeleted ()
		{
		}

		public AttributeSetStateDeleted (AttributeSetStateEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

		private Dictionary<AttributeUseStateEventId, IAttributeUseStateRemoved> _attributeUseEvents = new Dictionary<AttributeUseStateEventId, IAttributeUseStateRemoved>();
		
        private IEnumerable<IAttributeUseStateRemoved> _readOnlyAttributeUseEvents;

        public virtual IEnumerable<IAttributeUseStateRemoved> AttributeUseEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
                    return this._attributeUseEvents.Values;
                }
                else
                {
                    if (_readOnlyAttributeUseEvents != null) { return _readOnlyAttributeUseEvents; }
                    var eventDao = AttributeUseStateEventDao;
                    var eL = new List<IAttributeUseStateRemoved>();
                    foreach (var e in eventDao.FindByAttributeSetStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IAttributeUseStateRemoved)e);
                    }
                    return (_readOnlyAttributeUseEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddAttributeUseEvent(e);
                    }
                }
                else { this._attributeUseEvents.Clear(); }
            }
        }
	
		public virtual void AddAttributeUseEvent(IAttributeUseStateRemoved e)
		{
			ThrowOnInconsistentEventIds(e);
			this._attributeUseEvents[e.StateEventId] = e;
		}

        public virtual IAttributeUseStateRemoved NewAttributeUseStateRemoved(string attributeId)
        {
            var stateEvent = new AttributeUseStateRemoved(NewAttributeUseStateEventId(attributeId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IAttributeUseStateRemoved e in this.AttributeUseEvents) {
				AttributeUseStateEventDao.Save(e);
			}
		}


	}



}


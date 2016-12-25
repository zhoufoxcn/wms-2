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

	public abstract class AttributeSetInstanceExtensionFieldStateEventBase : IAttributeSetInstanceExtensionFieldStateEvent
	{

		public virtual AttributeSetInstanceExtensionFieldStateEventId StateEventId { get; set; }

		public virtual string Name { get; set; }

		public virtual string Type { get; set; }

		public virtual int? Length { get; set; }

		public virtual string Alias { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeSetInstanceExtensionFieldStateEventId IGlobalIdentity<AttributeSetInstanceExtensionFieldStateEventId>.GlobalId {
			get
			{
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeSetInstanceExtensionFieldStateEvent.ReadOnly
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

        protected AttributeSetInstanceExtensionFieldStateEventBase()
        {
        }

        protected AttributeSetInstanceExtensionFieldStateEventBase(AttributeSetInstanceExtensionFieldStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class AttributeSetInstanceExtensionFieldStateCreated : AttributeSetInstanceExtensionFieldStateEventBase, IAttributeSetInstanceExtensionFieldStateCreated
	{
		public AttributeSetInstanceExtensionFieldStateCreated ()
		{
		}

		public AttributeSetInstanceExtensionFieldStateCreated (AttributeSetInstanceExtensionFieldStateEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class AttributeSetInstanceExtensionFieldStateMergePatched : AttributeSetInstanceExtensionFieldStateEventBase, IAttributeSetInstanceExtensionFieldStateMergePatched
	{
		public virtual bool IsPropertyNameRemoved { get; set; }

		public virtual bool IsPropertyTypeRemoved { get; set; }

		public virtual bool IsPropertyLengthRemoved { get; set; }

		public virtual bool IsPropertyAliasRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public AttributeSetInstanceExtensionFieldStateMergePatched ()
		{
		}

		public AttributeSetInstanceExtensionFieldStateMergePatched (AttributeSetInstanceExtensionFieldStateEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class AttributeSetInstanceExtensionFieldStateRemoved : AttributeSetInstanceExtensionFieldStateEventBase, IAttributeSetInstanceExtensionFieldStateRemoved
	{
		public AttributeSetInstanceExtensionFieldStateRemoved ()
		{
		}

		public AttributeSetInstanceExtensionFieldStateRemoved (AttributeSetInstanceExtensionFieldStateEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}


﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public abstract class AttributeUseStateEventBase : AttributeUseStateProperties, IAttributeUseStateEvent
	{

		public virtual AttributeUseStateEventId StateEventId { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }//TODO CommandId 太特殊了！！！

		AttributeUseStateEventId IGlobalIdentity<AttributeUseStateEventId>.GlobalId {
			get {
				return this.StateEventId;
			}
		}

		public override string AttributeSetId {
			get {
				return StateEventId.AttributeSetId;
			}
			set {
				throw new NotSupportedException ();
			}
		}

		public override string AttributeId {
			get {
				return StateEventId.AttributeUseAttributeId;
			}
			set {
				throw new NotSupportedException ();
			}
		}


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
		}

        protected AttributeUseStateEventBase()
        {
        }

        protected AttributeUseStateEventBase(AttributeUseStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }


	}

	public class AttributeUseStateCreated : AttributeUseStateEventBase, IAttributeUseStateCreated
	{
		public AttributeUseStateCreated ()
		{
		}

		public AttributeUseStateCreated (AttributeUseStateEventId stateEventId) : base(stateEventId)
		{
		}


	}


	public class AttributeUseStateMergePatched : AttributeUseStateEventBase, IAttributeUseStateMergePatched
	{
		public virtual bool IsPropertySequenceNumberRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public AttributeUseStateMergePatched ()
		{
		}

		public AttributeUseStateMergePatched (AttributeUseStateEventId stateEventId) : base(stateEventId)
		{
		}



	}


	public class AttributeUseStateRemoved : AttributeUseStateEventBase, IAttributeUseStateRemoved
	{
		public AttributeUseStateRemoved ()
		{
		}

		public AttributeUseStateRemoved (AttributeUseStateEventId stateEventId) : base(stateEventId)
		{
		}

	}



}

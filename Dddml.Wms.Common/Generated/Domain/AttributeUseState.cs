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

	public partial class AttributeUseState : AttributeUseStateProperties, IAttributeUseState
	{

		//public virtual long Version { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }



		#region IIdentity implementation

        private AttributeSetAttributeUseId _attributeSetAttributeUseId = new AttributeSetAttributeUseId();

        public virtual AttributeSetAttributeUseId AttributeSetAttributeUseId 
        {
            get { return this._attributeSetAttributeUseId; }
            set { this._attributeSetAttributeUseId = value; }
        }

		AttributeSetAttributeUseId IGlobalIdentity<AttributeSetAttributeUseId>.GlobalId {
			get {
				return  this.AttributeSetAttributeUseId;
			}
		}

        string ILocalIdentity<string>.LocalId
        {
            get
            {
                return this.AttributeId;
            }
        }


        public override string AttributeSetId {
			get {
				return this.AttributeSetAttributeUseId.AttributeSetId;
			}
			set {
				this.AttributeSetAttributeUseId.AttributeSetId = value;
			}
		}

        public override string AttributeId {
			get {
				return this.AttributeSetAttributeUseId.AttributeId;
			}
			set {
				this.AttributeSetAttributeUseId.AttributeId = value;
			}
		}

		#endregion



		#region IActive implementation

		bool IActive.Active
		{
			get
			{
				return this.Active;
			}
		}

		#endregion


		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get
			{
				return this.UpdatedBy;
			}
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get
			{
				return this.UpdatedAt;
			}
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


		public AttributeUseState ()
		{
		}



		public virtual void When(IAttributeUseStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.SequenceNumber = (e.SequenceNumber != null && e.SequenceNumber.HasValue) ? e.SequenceNumber.Value : default(int);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IAttributeUseStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.SequenceNumber == null)
			{
				if (e.IsPropertySequenceNumberRemoved)
				{
					this.SequenceNumber = default(int);
				}
			}
			else
			{
				this.SequenceNumber = (e.SequenceNumber != null && e.SequenceNumber.HasValue) ? e.SequenceNumber.Value : default(int);
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IAttributeUseStateRemoved e)
		{
			ThrowOnWrongEvent(e);
		}


		public virtual void Mutate(IEvent e)
		{
			((dynamic)this).When((dynamic)e);
		}

		protected void ThrowOnWrongEvent(IAttributeUseStateEvent stateEvent)
		{
				var stateEntityIdAttributeSetId = (this as IGlobalIdentity<AttributeSetAttributeUseId>).GlobalId.AttributeSetId;
				var eventEntityIdAttributeSetId = stateEvent.StateEventId.AttributeSetId;
				if (stateEntityIdAttributeSetId != eventEntityIdAttributeSetId)
				{
					DomainError.Named("mutateWrongEntity", "Entity Id AttributeSetId {0} in state but entity id AttributeSetId {1} in event", stateEntityIdAttributeSetId, eventEntityIdAttributeSetId);
				}

				var stateEntityIdAttributeId = (this as IGlobalIdentity<AttributeSetAttributeUseId>).GlobalId.AttributeId;
				var eventEntityIdAttributeId = stateEvent.StateEventId.AttributeId;
				if (stateEntityIdAttributeId != eventEntityIdAttributeId)
				{
					DomainError.Named("mutateWrongEntity", "Entity Id AttributeId {0} in state but entity id AttributeId {1} in event", stateEntityIdAttributeId, eventEntityIdAttributeId);
				}

			var stateVersion = this.Version;
			var eventVersion = stateEvent.Version;
			if (AttributeUseState.VersionZero == eventVersion)
			{
				eventVersion = stateEvent.Version = stateVersion;
			}
			if (stateVersion != eventVersion)
			{
				throw DomainError.Named("concurrencyConflict", "Conflict between state version {0} and event version {1}", stateVersion, eventVersion);
			}

		}
	}

}


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

	public partial class AttributeSetInstanceExtensionFieldMvoState : AttributeSetInstanceExtensionFieldMvoStateProperties, IAttributeSetInstanceExtensionFieldMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		AttributeSetInstanceExtensionFieldId IGlobalIdentity<AttributeSetInstanceExtensionFieldId>.GlobalId
		{
			get
			{
				return this.AttributeSetInstanceExtensionFieldId;
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

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
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
				return this.AttrSetInstEFGroupVersion;
			}
		}


		#endregion

        bool IAttributeSetInstanceExtensionFieldMvoState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


		public AttributeSetInstanceExtensionFieldMvoState ()
		{
            InitializeProperties();
		}



		public virtual void When(IAttributeSetInstanceExtensionFieldMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.Name = e.Name;

			this.Type = e.Type;

			this.Length = e.Length;

			this.Alias = e.Alias;

			this.Description = e.Description;

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.AttrSetInstEFGroupFieldType = e.AttrSetInstEFGroupFieldType;

			this.AttrSetInstEFGroupFieldLength = e.AttrSetInstEFGroupFieldLength;

            this.AttrSetInstEFGroupFieldCount = (e.AttrSetInstEFGroupFieldCount != null && e.AttrSetInstEFGroupFieldCount.HasValue) ? e.AttrSetInstEFGroupFieldCount.Value : default(int);

			this.AttrSetInstEFGroupNameFormat = e.AttrSetInstEFGroupNameFormat;

			this.AttrSetInstEFGroupDescription = e.AttrSetInstEFGroupDescription;

			this.AttrSetInstEFGroupCreatedBy = e.AttrSetInstEFGroupCreatedBy;

            this.AttrSetInstEFGroupCreatedAt = (e.AttrSetInstEFGroupCreatedAt != null && e.AttrSetInstEFGroupCreatedAt.HasValue) ? e.AttrSetInstEFGroupCreatedAt.Value : default(DateTime);

			this.AttrSetInstEFGroupUpdatedBy = e.AttrSetInstEFGroupUpdatedBy;

            this.AttrSetInstEFGroupUpdatedAt = (e.AttrSetInstEFGroupUpdatedAt != null && e.AttrSetInstEFGroupUpdatedAt.HasValue) ? e.AttrSetInstEFGroupUpdatedAt.Value : default(DateTime);

            this.AttrSetInstEFGroupActive = (e.AttrSetInstEFGroupActive != null && e.AttrSetInstEFGroupActive.HasValue) ? e.AttrSetInstEFGroupActive.Value : default(bool);

            this.AttrSetInstEFGroupDeleted = (e.AttrSetInstEFGroupDeleted != null && e.AttrSetInstEFGroupDeleted.HasValue) ? e.AttrSetInstEFGroupDeleted.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IAttributeSetInstanceExtensionFieldMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.Name == null)
			{
				if (e.IsPropertyNameRemoved)
				{
					this.Name = default(string);
				}
			}
			else
			{
				this.Name = e.Name;
			}

			if (e.Type == null)
			{
				if (e.IsPropertyTypeRemoved)
				{
					this.Type = default(string);
				}
			}
			else
			{
				this.Type = e.Type;
			}

			if (e.Length == null)
			{
				if (e.IsPropertyLengthRemoved)
				{
					this.Length = default(int?);
				}
			}
			else
			{
				this.Length = e.Length;
			}

			if (e.Alias == null)
			{
				if (e.IsPropertyAliasRemoved)
				{
					this.Alias = default(string);
				}
			}
			else
			{
				this.Alias = e.Alias;
			}

			if (e.Description == null)
			{
				if (e.IsPropertyDescriptionRemoved)
				{
					this.Description = default(string);
				}
			}
			else
			{
				this.Description = e.Description;
			}

			if (e.Version == null)
			{
				if (e.IsPropertyVersionRemoved)
				{
					this.Version = default(long);
				}
			}
			else
			{
				this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);
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

			if (e.AttrSetInstEFGroupFieldType == null)
			{
				if (e.IsPropertyAttrSetInstEFGroupFieldTypeRemoved)
				{
					this.AttrSetInstEFGroupFieldType = default(string);
				}
			}
			else
			{
				this.AttrSetInstEFGroupFieldType = e.AttrSetInstEFGroupFieldType;
			}

			if (e.AttrSetInstEFGroupFieldLength == null)
			{
				if (e.IsPropertyAttrSetInstEFGroupFieldLengthRemoved)
				{
					this.AttrSetInstEFGroupFieldLength = default(int?);
				}
			}
			else
			{
				this.AttrSetInstEFGroupFieldLength = e.AttrSetInstEFGroupFieldLength;
			}

			if (e.AttrSetInstEFGroupFieldCount == null)
			{
				if (e.IsPropertyAttrSetInstEFGroupFieldCountRemoved)
				{
					this.AttrSetInstEFGroupFieldCount = default(int);
				}
			}
			else
			{
				this.AttrSetInstEFGroupFieldCount = (e.AttrSetInstEFGroupFieldCount != null && e.AttrSetInstEFGroupFieldCount.HasValue) ? e.AttrSetInstEFGroupFieldCount.Value : default(int);
			}

			if (e.AttrSetInstEFGroupNameFormat == null)
			{
				if (e.IsPropertyAttrSetInstEFGroupNameFormatRemoved)
				{
					this.AttrSetInstEFGroupNameFormat = default(string);
				}
			}
			else
			{
				this.AttrSetInstEFGroupNameFormat = e.AttrSetInstEFGroupNameFormat;
			}

			if (e.AttrSetInstEFGroupDescription == null)
			{
				if (e.IsPropertyAttrSetInstEFGroupDescriptionRemoved)
				{
					this.AttrSetInstEFGroupDescription = default(string);
				}
			}
			else
			{
				this.AttrSetInstEFGroupDescription = e.AttrSetInstEFGroupDescription;
			}

			if (e.AttrSetInstEFGroupCreatedBy == null)
			{
				if (e.IsPropertyAttrSetInstEFGroupCreatedByRemoved)
				{
					this.AttrSetInstEFGroupCreatedBy = default(string);
				}
			}
			else
			{
				this.AttrSetInstEFGroupCreatedBy = e.AttrSetInstEFGroupCreatedBy;
			}

			if (e.AttrSetInstEFGroupCreatedAt == null)
			{
				if (e.IsPropertyAttrSetInstEFGroupCreatedAtRemoved)
				{
					this.AttrSetInstEFGroupCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.AttrSetInstEFGroupCreatedAt = (e.AttrSetInstEFGroupCreatedAt != null && e.AttrSetInstEFGroupCreatedAt.HasValue) ? e.AttrSetInstEFGroupCreatedAt.Value : default(DateTime);
			}

			if (e.AttrSetInstEFGroupUpdatedBy == null)
			{
				if (e.IsPropertyAttrSetInstEFGroupUpdatedByRemoved)
				{
					this.AttrSetInstEFGroupUpdatedBy = default(string);
				}
			}
			else
			{
				this.AttrSetInstEFGroupUpdatedBy = e.AttrSetInstEFGroupUpdatedBy;
			}

			if (e.AttrSetInstEFGroupUpdatedAt == null)
			{
				if (e.IsPropertyAttrSetInstEFGroupUpdatedAtRemoved)
				{
					this.AttrSetInstEFGroupUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.AttrSetInstEFGroupUpdatedAt = (e.AttrSetInstEFGroupUpdatedAt != null && e.AttrSetInstEFGroupUpdatedAt.HasValue) ? e.AttrSetInstEFGroupUpdatedAt.Value : default(DateTime);
			}

			if (e.AttrSetInstEFGroupActive == null)
			{
				if (e.IsPropertyAttrSetInstEFGroupActiveRemoved)
				{
					this.AttrSetInstEFGroupActive = default(bool);
				}
			}
			else
			{
				this.AttrSetInstEFGroupActive = (e.AttrSetInstEFGroupActive != null && e.AttrSetInstEFGroupActive.HasValue) ? e.AttrSetInstEFGroupActive.Value : default(bool);
			}

			if (e.AttrSetInstEFGroupDeleted == null)
			{
				if (e.IsPropertyAttrSetInstEFGroupDeletedRemoved)
				{
					this.AttrSetInstEFGroupDeleted = default(bool);
				}
			}
			else
			{
				this.AttrSetInstEFGroupDeleted = (e.AttrSetInstEFGroupDeleted != null && e.AttrSetInstEFGroupDeleted.HasValue) ? e.AttrSetInstEFGroupDeleted.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IAttributeSetInstanceExtensionFieldMvoStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
			((dynamic)this).When((dynamic)e);
		}

		protected void ThrowOnWrongEvent(IAttributeSetInstanceExtensionFieldMvoStateEvent stateEvent)
		{
			var stateEntityId = this.AttributeSetInstanceExtensionFieldId; // Aggregate Id
			var eventEntityId = stateEvent.StateEventId.AttributeSetInstanceExtensionFieldId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
			if (stateEntityId != eventEntityId)
			{
				DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
			}

			var stateVersion = this.AttrSetInstEFGroupVersion;
			var eventVersion = stateEvent.StateEventId.AttrSetInstEFGroupVersion;
			if (stateVersion != eventVersion)
			{
				throw DomainError.Named("concurrencyConflict", "Conflict between state version {0} and event version {1}", stateVersion, eventVersion);
			}

		}
	}

}


﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

    public partial class AttributeUseMvoStateDto : IAttributeUseMvoStateDto
    {

        public virtual AttributeSetAttributeUseIdDto AttributeSetAttributeUseId
        {
            get;
            set;
        }

        public virtual int? SequenceNumber
        {
            get;
            set;
        }

        public virtual long? Version
        {
            get;
            set;
        }

        public virtual bool? Active
        {
            get;
            set;
        }

        public virtual string AttributeSetName
        {
            get;
            set;
        }

        public virtual string AttributeSetOrganizationId
        {
            get;
            set;
        }

        public virtual string AttributeSetDescription
        {
            get;
            set;
        }

        public virtual string AttributeSetSerialNumberAttributeId
        {
            get;
            set;
        }

        public virtual string AttributeSetLotAttributeId
        {
            get;
            set;
        }

        public virtual string AttributeSetReferenceId
        {
            get;
            set;
        }

        public virtual string AttributeSetCreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? AttributeSetCreatedAt
        {
            get;
            set;
        }

        public virtual string AttributeSetUpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? AttributeSetUpdatedAt
        {
            get;
            set;
        }

        public virtual bool? AttributeSetActive
        {
            get;
            set;
        }

        public virtual bool? AttributeSetDeleted
        {
            get;
            set;
        }

        public virtual long? AttributeSetVersion
        {
            get;
            set;
        }

        public virtual string CreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? CreatedAt
        {
            get;
            set;
        }

        public virtual string UpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? UpdatedAt
        {
            get;
            set;
        }

        public virtual IAttributeUseMvoState ToAttributeUseMvoState()
        {
            var state = new AttributeUseMvoState(true);
            state.AttributeSetAttributeUseId = (this.AttributeSetAttributeUseId == null) ? null : this.AttributeSetAttributeUseId.ToAttributeSetAttributeUseId();
            if (this.SequenceNumber != null && this.SequenceNumber.HasValue) { state.SequenceNumber = this.SequenceNumber.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            state.AttributeSetName = this.AttributeSetName;
            state.AttributeSetOrganizationId = this.AttributeSetOrganizationId;
            state.AttributeSetDescription = this.AttributeSetDescription;
            state.AttributeSetSerialNumberAttributeId = this.AttributeSetSerialNumberAttributeId;
            state.AttributeSetLotAttributeId = this.AttributeSetLotAttributeId;
            state.AttributeSetReferenceId = this.AttributeSetReferenceId;
            state.AttributeSetCreatedBy = this.AttributeSetCreatedBy;
            if (this.AttributeSetCreatedAt != null && this.AttributeSetCreatedAt.HasValue) { state.AttributeSetCreatedAt = this.AttributeSetCreatedAt.Value; }
            state.AttributeSetUpdatedBy = this.AttributeSetUpdatedBy;
            if (this.AttributeSetUpdatedAt != null && this.AttributeSetUpdatedAt.HasValue) { state.AttributeSetUpdatedAt = this.AttributeSetUpdatedAt.Value; }
            if (this.AttributeSetActive != null && this.AttributeSetActive.HasValue) { state.AttributeSetActive = this.AttributeSetActive.Value; }
            if (this.AttributeSetDeleted != null && this.AttributeSetDeleted.HasValue) { state.AttributeSetDeleted = this.AttributeSetDeleted.Value; }
            if (this.AttributeSetVersion != null && this.AttributeSetVersion.HasValue) { state.AttributeSetVersion = this.AttributeSetVersion.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}


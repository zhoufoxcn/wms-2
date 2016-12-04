﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{

    public partial class InOutLineStateDto : IInOutLineStateDto
    {

        public virtual SkuIdDto SkuId
        {
            get;
            set;
        }

        public virtual long? LineNumber
        {
            get;
            set;
        }

        public virtual string Description
        {
            get;
            set;
        }

        public virtual string LocatorId
        {
            get;
            set;
        }

        public virtual string Product
        {
            get;
            set;
        }

        public virtual string UomId
        {
            get;
            set;
        }

        public virtual decimal? MovementQuantity
        {
            get;
            set;
        }

        public virtual decimal? ConfirmedQuantity
        {
            get;
            set;
        }

        public virtual decimal? ScrappedQuantity
        {
            get;
            set;
        }

        public virtual decimal? TargetQuantity
        {
            get;
            set;
        }

        public virtual decimal? PickedQuantity
        {
            get;
            set;
        }

        public virtual bool? IsInvoiced
        {
            get;
            set;
        }

        public virtual string AttributeSetInstanceId
        {
            get;
            set;
        }

        public virtual bool? IsDescription
        {
            get;
            set;
        }

        public virtual bool? Processed
        {
            get;
            set;
        }

        public virtual decimal? QuantityEntered
        {
            get;
            set;
        }

        public virtual long? RmaLineNumber
        {
            get;
            set;
        }

        public virtual long? ReversalLineNumber
        {
            get;
            set;
        }

        public virtual bool? Active
        {
            get;
            set;
        }

        public virtual long? Version
        {
            get;
            set;
        }

        public virtual string InOutDocumentNumber
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

        public virtual IInOutLineState ToInOutLineState()
        {
            var state = new InOutLineState(true);
            state.SkuId = (this.SkuId == null) ? null : this.SkuId.ToSkuId();
            if (this.LineNumber != null && this.LineNumber.HasValue) { state.LineNumber = this.LineNumber.Value; }
            state.Description = this.Description;
            state.LocatorId = this.LocatorId;
            state.Product = this.Product;
            state.UomId = this.UomId;
            if (this.MovementQuantity != null && this.MovementQuantity.HasValue) { state.MovementQuantity = this.MovementQuantity.Value; }
            if (this.ConfirmedQuantity != null && this.ConfirmedQuantity.HasValue) { state.ConfirmedQuantity = this.ConfirmedQuantity.Value; }
            if (this.ScrappedQuantity != null && this.ScrappedQuantity.HasValue) { state.ScrappedQuantity = this.ScrappedQuantity.Value; }
            if (this.TargetQuantity != null && this.TargetQuantity.HasValue) { state.TargetQuantity = this.TargetQuantity.Value; }
            if (this.PickedQuantity != null && this.PickedQuantity.HasValue) { state.PickedQuantity = this.PickedQuantity.Value; }
            if (this.IsInvoiced != null && this.IsInvoiced.HasValue) { state.IsInvoiced = this.IsInvoiced.Value; }
            state.AttributeSetInstanceId = this.AttributeSetInstanceId;
            if (this.IsDescription != null && this.IsDescription.HasValue) { state.IsDescription = this.IsDescription.Value; }
            if (this.Processed != null && this.Processed.HasValue) { state.Processed = this.Processed.Value; }
            if (this.QuantityEntered != null && this.QuantityEntered.HasValue) { state.QuantityEntered = this.QuantityEntered.Value; }
            if (this.RmaLineNumber != null && this.RmaLineNumber.HasValue) { state.RmaLineNumber = this.RmaLineNumber.Value; }
            if (this.ReversalLineNumber != null && this.ReversalLineNumber.HasValue) { state.ReversalLineNumber = this.ReversalLineNumber.Value; }
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.InOutDocumentNumber = this.InOutDocumentNumber;
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}


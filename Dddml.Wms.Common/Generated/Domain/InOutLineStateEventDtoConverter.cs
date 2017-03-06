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

    public class InOutLineStateEventDtoConverter
    {
        public virtual InOutLineStateCreatedOrMergePatchedOrRemovedDto ToInOutLineStateEventDto(IInOutLineStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IInOutLineStateCreated)stateEvent;
                return ToInOutLineStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IInOutLineStateMergePatched)stateEvent;
                return ToInOutLineStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Removed)
            {
                var e = (IInOutLineStateRemoved)stateEvent;
                return ToInOutLineStateRemovedDto(e);
            }

            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual InOutLineStateCreatedDto ToInOutLineStateCreatedDto(IInOutLineStateCreated e)
        {
            var dto = new InOutLineStateCreatedDto();
            dto.StateEventId = new InOutLineStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Description = e.Description;
            dto.LocatorId = e.LocatorId;
            dto.ProductId = e.ProductId;
            dto.UomId = e.UomId;
            dto.MovementQuantity = e.MovementQuantity;
            dto.ConfirmedQuantity = e.ConfirmedQuantity;
            dto.ScrappedQuantity = e.ScrappedQuantity;
            dto.TargetQuantity = e.TargetQuantity;
            dto.PickedQuantity = e.PickedQuantity;
            dto.IsInvoiced = e.IsInvoiced;
            dto.AttributeSetInstanceId = e.AttributeSetInstanceId;
            dto.IsDescription = e.IsDescription;
            dto.Processed = e.Processed;
            dto.QuantityEntered = e.QuantityEntered;
            dto.RmaLineNumber = e.RmaLineNumber;
            dto.ReversalLineNumber = e.ReversalLineNumber;
            dto.Active = e.Active;
            return dto;
        }

        public virtual InOutLineStateMergePatchedDto ToInOutLineStateMergePatchedDto(IInOutLineStateMergePatched e)
        {
            var dto = new InOutLineStateMergePatchedDto();
            dto.StateEventId = new InOutLineStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Description = e.Description;
            dto.LocatorId = e.LocatorId;
            dto.ProductId = e.ProductId;
            dto.UomId = e.UomId;
            dto.MovementQuantity = e.MovementQuantity;
            dto.ConfirmedQuantity = e.ConfirmedQuantity;
            dto.ScrappedQuantity = e.ScrappedQuantity;
            dto.TargetQuantity = e.TargetQuantity;
            dto.PickedQuantity = e.PickedQuantity;
            dto.IsInvoiced = e.IsInvoiced;
            dto.AttributeSetInstanceId = e.AttributeSetInstanceId;
            dto.IsDescription = e.IsDescription;
            dto.Processed = e.Processed;
            dto.QuantityEntered = e.QuantityEntered;
            dto.RmaLineNumber = e.RmaLineNumber;
            dto.ReversalLineNumber = e.ReversalLineNumber;
            dto.Active = e.Active;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyLocatorIdRemoved = e.IsPropertyLocatorIdRemoved;
            dto.IsPropertyProductIdRemoved = e.IsPropertyProductIdRemoved;
            dto.IsPropertyUomIdRemoved = e.IsPropertyUomIdRemoved;
            dto.IsPropertyMovementQuantityRemoved = e.IsPropertyMovementQuantityRemoved;
            dto.IsPropertyConfirmedQuantityRemoved = e.IsPropertyConfirmedQuantityRemoved;
            dto.IsPropertyScrappedQuantityRemoved = e.IsPropertyScrappedQuantityRemoved;
            dto.IsPropertyTargetQuantityRemoved = e.IsPropertyTargetQuantityRemoved;
            dto.IsPropertyPickedQuantityRemoved = e.IsPropertyPickedQuantityRemoved;
            dto.IsPropertyIsInvoicedRemoved = e.IsPropertyIsInvoicedRemoved;
            dto.IsPropertyAttributeSetInstanceIdRemoved = e.IsPropertyAttributeSetInstanceIdRemoved;
            dto.IsPropertyIsDescriptionRemoved = e.IsPropertyIsDescriptionRemoved;
            dto.IsPropertyProcessedRemoved = e.IsPropertyProcessedRemoved;
            dto.IsPropertyQuantityEnteredRemoved = e.IsPropertyQuantityEnteredRemoved;
            dto.IsPropertyRmaLineNumberRemoved = e.IsPropertyRmaLineNumberRemoved;
            dto.IsPropertyReversalLineNumberRemoved = e.IsPropertyReversalLineNumberRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual InOutLineStateRemovedDto ToInOutLineStateRemovedDto(IInOutLineStateRemoved e)
        {
            var dto = new InOutLineStateRemovedDto();
            dto.StateEventId = new InOutLineStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}


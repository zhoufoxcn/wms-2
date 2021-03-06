﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{

    public class AttributeValueStateEventDtoConverter
    {
        public virtual AttributeValueStateCreatedOrMergePatchedOrRemovedDto ToAttributeValueStateEventDto(IAttributeValueStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IAttributeValueStateCreated)stateEvent;
                return ToAttributeValueStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IAttributeValueStateMergePatched)stateEvent;
                return ToAttributeValueStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Removed)
            {
                var e = (IAttributeValueStateRemoved)stateEvent;
                return ToAttributeValueStateRemovedDto(e);
            }

            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual AttributeValueStateCreatedDto ToAttributeValueStateCreatedDto(IAttributeValueStateCreated e)
        {
            var dto = new AttributeValueStateCreatedDto();
            dto.StateEventId = new AttributeValueStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Name = e.Name;
            dto.Description = e.Description;
            dto.ReferenceId = e.ReferenceId;
            dto.Active = e.Active;
            return dto;
        }

        public virtual AttributeValueStateMergePatchedDto ToAttributeValueStateMergePatchedDto(IAttributeValueStateMergePatched e)
        {
            var dto = new AttributeValueStateMergePatchedDto();
            dto.StateEventId = new AttributeValueStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Name = e.Name;
            dto.Description = e.Description;
            dto.ReferenceId = e.ReferenceId;
            dto.Active = e.Active;
            dto.IsPropertyNameRemoved = e.IsPropertyNameRemoved;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyReferenceIdRemoved = e.IsPropertyReferenceIdRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual AttributeValueStateRemovedDto ToAttributeValueStateRemovedDto(IAttributeValueStateRemoved e)
        {
            var dto = new AttributeValueStateRemovedDto();
            dto.StateEventId = new AttributeValueStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}


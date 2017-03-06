﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationStructureTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrganizationStructureType;

namespace Dddml.Wms.Domain.OrganizationStructureType
{

    public class OrganizationStructureTypeStateEventDtoConverter
    {
        public virtual OrganizationStructureTypeStateCreatedOrMergePatchedOrDeletedDto ToOrganizationStructureTypeStateEventDto(IOrganizationStructureTypeStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IOrganizationStructureTypeStateCreated)stateEvent;
                return ToOrganizationStructureTypeStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IOrganizationStructureTypeStateMergePatched)stateEvent;
                return ToOrganizationStructureTypeStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IOrganizationStructureTypeStateDeleted)stateEvent;
                return ToOrganizationStructureTypeStateDeletedDto(e);
            }

            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual OrganizationStructureTypeStateCreatedDto ToOrganizationStructureTypeStateCreatedDto(IOrganizationStructureTypeStateCreated e)
        {
            var dto = new OrganizationStructureTypeStateCreatedDto();
            dto.StateEventId = new OrganizationStructureTypeStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Active = e.Active;
            return dto;
        }

        public virtual OrganizationStructureTypeStateMergePatchedDto ToOrganizationStructureTypeStateMergePatchedDto(IOrganizationStructureTypeStateMergePatched e)
        {
            var dto = new OrganizationStructureTypeStateMergePatchedDto();
            dto.StateEventId = new OrganizationStructureTypeStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Active = e.Active;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual OrganizationStructureTypeStateDeletedDto ToOrganizationStructureTypeStateDeletedDto(IOrganizationStructureTypeStateDeleted e)
        {
            var dto = new OrganizationStructureTypeStateDeletedDto();
            dto.StateEventId = new OrganizationStructureTypeStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

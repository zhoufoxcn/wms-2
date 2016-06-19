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

	public static partial class OrganizationStateExtensions
	{

        public static IOrganizationCommand ToCreateOrMergePatchOrganization(this OrganizationState state)
        {
            bool bUnsaved = ((IOrganizationState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateOrganization();
            }
            else 
            {
                return state.ToMergePatchOrganization();
            }
        }

        public static DeleteOrganization ToDeleteOrganization(this OrganizationState state)
        {
            var cmd = new DeleteOrganization();
            cmd.OrganizationId = state.OrganizationId;
            cmd.Version = state.Version;

            return cmd;
        }

        public static MergePatchOrganization ToMergePatchOrganization(this OrganizationState state)
        {
            var cmd = new MergePatchOrganization();

            cmd.Version = state.Version;

            cmd.OrganizationId = state.OrganizationId;
            cmd.Name = state.Name;
            cmd.Description = state.Description;
            cmd.Type = state.Type;
            cmd.IsSummary = state.IsSummary;
            cmd.Active = state.Active;
            
            if (state.Name == null) { cmd.IsPropertyNameRemoved = true; }
            if (state.Description == null) { cmd.IsPropertyDescriptionRemoved = true; }
            if (state.Type == null) { cmd.IsPropertyTypeRemoved = true; }
            return cmd;
        }

        public static CreateOrganization ToCreateOrganization(this OrganizationState state)
        {
            var cmd = new CreateOrganization();

            cmd.Version = state.Version;

            cmd.OrganizationId = state.OrganizationId;
            cmd.Name = state.Name;
            cmd.Description = state.Description;
            cmd.Type = state.Type;
            cmd.IsSummary = state.IsSummary;
            cmd.Active = state.Active;
            return cmd;
        }
		

	}

}


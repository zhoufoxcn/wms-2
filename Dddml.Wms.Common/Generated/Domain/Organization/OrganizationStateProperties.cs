﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Organization;

namespace Dddml.Wms.Domain.Organization
{

	public abstract class OrganizationStateProperties : IOrganizationStateProperties
	{
		public virtual string OrganizationId { get; set; }

		public virtual string Name { get; set; }

		public virtual string Description { get; set; }

		public virtual string Type { get; set; }

		public virtual bool IsSummary { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
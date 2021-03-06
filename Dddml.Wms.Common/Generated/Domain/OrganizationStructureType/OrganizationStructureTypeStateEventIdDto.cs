﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationStructureTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrganizationStructureType;

namespace Dddml.Wms.Domain.OrganizationStructureType
{

	public class OrganizationStructureTypeStateEventIdDto
	{

		public OrganizationStructureTypeStateEventIdDto()
		{
		}

        public virtual OrganizationStructureTypeStateEventId ToOrganizationStructureTypeStateEventId()
        {
            OrganizationStructureTypeStateEventId v = new OrganizationStructureTypeStateEventId();
            v.Id = this.Id;
            v.Version = this.Version;
            return v;
        }

		public virtual string Id { 
			get;
			set;
		}

		public virtual long Version { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			OrganizationStructureTypeStateEventIdDto other = obj as OrganizationStructureTypeStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.Id, other.Id)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.Id != null) {
				hash += 13 * this.Id.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

	}

}



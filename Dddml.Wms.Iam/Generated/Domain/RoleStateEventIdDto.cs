﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Role;

namespace Dddml.Wms.Domain.Role
{

	public class RoleStateEventIdDto
	{

		public RoleStateEventIdDto()
		{
		}

        public virtual RoleStateEventId ToRoleStateEventId()
        {
            RoleStateEventId v = new RoleStateEventId();
            v.RoleId = this.RoleId;
            v.Version = this.Version;
            return v;
        }

		public virtual string RoleId { 
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

			RoleStateEventIdDto other = obj as RoleStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.RoleId, other.RoleId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.RoleId != null) {
				hash += 13 * this.RoleId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

	}

}



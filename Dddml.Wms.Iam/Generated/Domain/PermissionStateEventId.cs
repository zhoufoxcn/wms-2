﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Permission;

namespace Dddml.Wms.Domain.Permission
{

	public class PermissionStateEventId
	{

		private string _permissionId;

		public virtual string PermissionId { 
			get { return this._permissionId; } 
			internal set { _permissionId = value; } 
		}

		private long _version;

		public virtual long Version { 
			get { return this._version; } 
			internal set { _version = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal PermissionStateEventId ()
		{
		}

		public PermissionStateEventId (string permissionId, long version)
		{
			this._permissionId = permissionId;
			this._version = version;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			PermissionStateEventId other = obj as PermissionStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.PermissionId, other.PermissionId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.PermissionId != null) {
				hash += 13 * this.PermissionId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(PermissionStateEventId obj1, PermissionStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(PermissionStateEventId obj1, PermissionStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}



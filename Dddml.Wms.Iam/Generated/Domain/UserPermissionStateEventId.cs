﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

	public class UserPermissionStateEventId
	{

		private string _userId;

		public virtual string UserId { 
			get { return this._userId; } 
			internal set { _userId = value; } 
		}

		private string _permissionId;

		public virtual string PermissionId { 
			get { return this._permissionId; } 
			internal set { _permissionId = value; } 
		}

		private long _userVersion;

		public virtual long UserVersion { 
			get { return this._userVersion; } 
			internal set { _userVersion = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal UserPermissionStateEventId ()
		{
		}

		public UserPermissionStateEventId (string userId, string permissionId, long userVersion)
		{
			this._userId = userId;
			this._permissionId = permissionId;
			this._userVersion = userVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserPermissionStateEventId other = obj as UserPermissionStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.UserId, other.UserId)
				&& Object.Equals (this.PermissionId, other.PermissionId)
				&& Object.Equals (this.UserVersion, other.UserVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.UserId != null) {
				hash += 13 * this.UserId.GetHashCode ();
			}
			if (this.PermissionId != null) {
				hash += 13 * this.PermissionId.GetHashCode ();
			}
			if (this.UserVersion != null) {
				hash += 13 * this.UserVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(UserPermissionStateEventId obj1, UserPermissionStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(UserPermissionStateEventId obj1, UserPermissionStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}



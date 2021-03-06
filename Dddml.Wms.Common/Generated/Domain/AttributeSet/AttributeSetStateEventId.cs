﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeSet
{

	public class AttributeSetStateEventId
	{

		private string _attributeSetId;

		public virtual string AttributeSetId { 
			get { return this._attributeSetId; } 
			internal set { _attributeSetId = value; } 
		}

		private long _version;

		public virtual long Version { 
			get { return this._version; } 
			internal set { _version = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal AttributeSetStateEventId ()
		{
		}

		public AttributeSetStateEventId (string attributeSetId, long version)
		{
			this._attributeSetId = attributeSetId;
			this._version = version;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeSetStateEventId other = obj as AttributeSetStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.AttributeSetId, other.AttributeSetId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.AttributeSetId != null) {
				hash += 13 * this.AttributeSetId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(AttributeSetStateEventId obj1, AttributeSetStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(AttributeSetStateEventId obj1, AttributeSetStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}



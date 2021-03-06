﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstance;

namespace Dddml.Wms.Domain.AttributeSetInstance
{

	public class AttributeSetInstanceStateEventIdDto
	{

		public AttributeSetInstanceStateEventIdDto()
		{
		}

        public virtual AttributeSetInstanceStateEventId ToAttributeSetInstanceStateEventId()
        {
            AttributeSetInstanceStateEventId v = new AttributeSetInstanceStateEventId();
            v.AttributeSetInstanceId = this.AttributeSetInstanceId;
            v.Version = this.Version;
            return v;
        }

		public virtual string AttributeSetInstanceId { 
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

			AttributeSetInstanceStateEventIdDto other = obj as AttributeSetInstanceStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.AttributeSetInstanceId, other.AttributeSetInstanceId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.AttributeSetInstanceId != null) {
				hash += 13 * this.AttributeSetInstanceId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

	}

}



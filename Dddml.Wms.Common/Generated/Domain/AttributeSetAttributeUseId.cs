﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using Dddml.Wms.Domain;
using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public class AttributeSetAttributeUseId
	{

		private string _attributeSetId;

		public virtual string AttributeSetId { 
			get { return this._attributeSetId; } 
			internal set { _attributeSetId = value; } 
		}

		private string _attributeUseAttributeId;

		public virtual string AttributeUseAttributeId { 
			get { return this._attributeUseAttributeId; } 
			internal set { _attributeUseAttributeId = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal AttributeSetAttributeUseId ()
		{
		}

		public AttributeSetAttributeUseId (string attributeSetId, string attributeUseAttributeId)
		{
			this._attributeSetId = attributeSetId;
			this._attributeUseAttributeId = attributeUseAttributeId;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeSetAttributeUseId other = obj as AttributeSetAttributeUseId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.AttributeSetId, other.AttributeSetId)
				&& Object.Equals (this.AttributeUseAttributeId, other.AttributeUseAttributeId)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.AttributeSetId != null) {
				hash += 13 * this.AttributeSetId.GetHashCode ();
			}
			if (this.AttributeUseAttributeId != null) {
				hash += 13 * this.AttributeUseAttributeId.GetHashCode ();
			}
			return hash;
		}

	}

}



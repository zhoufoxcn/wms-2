﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldGroupDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup
{

	public class AttributeSetInstanceExtensionFieldIdDtoWrapper : AttributeSetInstanceExtensionFieldIdDto
	{

        private AttributeSetInstanceExtensionFieldId _value = new AttributeSetInstanceExtensionFieldId();

		public AttributeSetInstanceExtensionFieldIdDtoWrapper()
		{
		}

		public AttributeSetInstanceExtensionFieldIdDtoWrapper(AttributeSetInstanceExtensionFieldId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override AttributeSetInstanceExtensionFieldId ToAttributeSetInstanceExtensionFieldId()
        {
            return this._value;
        }

		public override string GroupId { 
			get { return _value.GroupId; } 
			set { _value.GroupId = value; } 
		}

		public override string Index { 
			get { return _value.Index; } 
			set { _value.Index = value; } 
		}


	}

}



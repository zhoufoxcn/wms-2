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

	public class AttributeSetInstanceExtensionFieldGroupStateEventIdDtoWrapper : AttributeSetInstanceExtensionFieldGroupStateEventIdDto
	{

        private AttributeSetInstanceExtensionFieldGroupStateEventId _value = new AttributeSetInstanceExtensionFieldGroupStateEventId();

		public AttributeSetInstanceExtensionFieldGroupStateEventIdDtoWrapper()
		{
		}

		public AttributeSetInstanceExtensionFieldGroupStateEventIdDtoWrapper(AttributeSetInstanceExtensionFieldGroupStateEventId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override AttributeSetInstanceExtensionFieldGroupStateEventId ToAttributeSetInstanceExtensionFieldGroupStateEventId()
        {
            return this._value;
        }

		public override string Id { 
			get { return _value.Id; } 
			set { _value.Id = value; } 
		}

		public override long Version { 
			get { return _value.Version; } 
			set { _value.Version = value; } 
		}


	}

}



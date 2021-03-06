﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{

	public class AttributeValueStateEventIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "AttributeId", "Value", "AttributeVersion" };

        string[] IIdFlattenedDto.FieldNames
        {
            get { return _flattenedPropertyNames; }
        }

        object IIdFlattenedDto.GetFieldValue(string fieldName)
        {
            return ReflectUtils.GetPropertyValue(fieldName, this._value);
        }

        void IIdFlattenedDto.SetFieldValue(string fieldName, object fieldValue)
        {
            ReflectUtils.SetPropertyValue(fieldName, this._value, fieldValue);
        }

        Type IIdFlattenedDto.GetFieldType(string fieldName)
        {
            if (fieldName.Equals("AttributeId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("Value", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("AttributeVersion", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(long);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private AttributeValueStateEventIdDto _value = new AttributeValueStateEventIdDto();

		public AttributeValueStateEventIdFlattenedDto()
		{
		}

		public AttributeValueStateEventIdFlattenedDto(AttributeValueStateEventIdDto val)
		{
			this._value = val;
		}

        public AttributeValueStateEventIdDto ToAttributeValueStateEventIdDto()
        {
            return this._value;
        }

		public AttributeValueStateEventIdFlattenedDto(AttributeValueStateEventId val)
		{
			this._value = new AttributeValueStateEventIdDtoWrapper(val);
		}

        public AttributeValueStateEventId ToAttributeValueStateEventId()
        {
            return this._value.ToAttributeValueStateEventId();
        }

		public virtual string AttributeId { 
			get { return _value.AttributeId; } 
			set { _value.AttributeId = value; } 
		}

		public virtual string Value { 
			get { return _value.Value; } 
			set { _value.Value = value; } 
		}

		public virtual long AttributeVersion { 
			get { return _value.AttributeVersion; } 
			set { _value.AttributeVersion = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeValueStateEventIdFlattenedDto other = obj as AttributeValueStateEventIdFlattenedDto;
			if (other == null) {
				return false;
			}

            return _value.Equals(other._value);

		}

		public override int GetHashCode ()
		{
			return _value.GetHashCode();
		}

	}

    public class AttributeValueStateEventIdFlattenedDtoFormatter : IdFlattenedDtoFormatterBase<AttributeValueStateEventIdFlattenedDto>
    {

    }

}



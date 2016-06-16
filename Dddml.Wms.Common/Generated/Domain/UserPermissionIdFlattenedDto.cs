﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public class UserPermissionIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "UserId", "PermissionId" };

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
            if (fieldName.Equals("UserId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("PermissionId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private UserPermissionId _value = new UserPermissionId();

		public UserPermissionIdFlattenedDto()
		{
		}

		public UserPermissionIdFlattenedDto(UserPermissionId val)
		{
			this._value = val;
		}

        public UserPermissionId ToUserPermissionId()
        {
            return this._value;
        }


		public virtual string UserId { 
			get { return _value.UserId; } 
			set { _value.UserId = value; } 
		}

		public virtual string PermissionId { 
			get { return _value.PermissionId; } 
			set { _value.PermissionId = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserPermissionIdFlattenedDto other = obj as UserPermissionIdFlattenedDto;
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

}



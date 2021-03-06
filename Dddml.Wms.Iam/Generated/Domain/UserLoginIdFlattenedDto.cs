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

	public class UserLoginIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "UserId", "LoginKeyLoginProvider", "LoginKeyProviderKey" };

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

            if (fieldName.Equals("LoginKeyLoginProvider", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("LoginKeyProviderKey", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private UserLoginIdDto _value = new UserLoginIdDto();

		public UserLoginIdFlattenedDto()
		{
		}

		public UserLoginIdFlattenedDto(UserLoginIdDto val)
		{
			this._value = val;
		}

        public UserLoginIdDto ToUserLoginIdDto()
        {
            return this._value;
        }

		public UserLoginIdFlattenedDto(UserLoginId val)
		{
			this._value = new UserLoginIdDtoWrapper(val);
		}

        public UserLoginId ToUserLoginId()
        {
            return this._value.ToUserLoginId();
        }

		public virtual string UserId { 
			get { return _value.UserId; } 
			set { _value.UserId = value; } 
		}

		public virtual string LoginKeyLoginProvider {
			get { return _value.LoginKey.LoginProvider; }
			set { _value.LoginKey.LoginProvider = value; }
		}

		public virtual string LoginKeyProviderKey {
			get { return _value.LoginKey.ProviderKey; }
			set { _value.LoginKey.ProviderKey = value; }
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserLoginIdFlattenedDto other = obj as UserLoginIdFlattenedDto;
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

    public class UserLoginIdFlattenedDtoFormatter : IdFlattenedDtoFormatterBase<UserLoginIdFlattenedDto>
    {

    }

}



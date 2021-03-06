﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserLoginMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserLoginMvo
{

	public class UserLoginMvoStateEventIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "UserLoginIdUserId", "UserLoginIdLoginKeyLoginProvider", "UserLoginIdLoginKeyProviderKey", "UserVersion" };

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
            if (fieldName.Equals("UserLoginIdUserId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("UserLoginIdLoginKeyLoginProvider", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("UserLoginIdLoginKeyProviderKey", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("UserVersion", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(long);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private UserLoginMvoStateEventIdDto _value = new UserLoginMvoStateEventIdDto();

		public UserLoginMvoStateEventIdFlattenedDto()
		{
		}

		public UserLoginMvoStateEventIdFlattenedDto(UserLoginMvoStateEventIdDto val)
		{
			this._value = val;
		}

        public UserLoginMvoStateEventIdDto ToUserLoginMvoStateEventIdDto()
        {
            return this._value;
        }

		public UserLoginMvoStateEventIdFlattenedDto(UserLoginMvoStateEventId val)
		{
			this._value = new UserLoginMvoStateEventIdDtoWrapper(val);
		}

        public UserLoginMvoStateEventId ToUserLoginMvoStateEventId()
        {
            return this._value.ToUserLoginMvoStateEventId();
        }

		public virtual string UserLoginIdUserId {
			get { return _value.UserLoginId.UserId; }
			set { _value.UserLoginId.UserId = value; }
		}

		public virtual string UserLoginIdLoginKeyLoginProvider {
			get { return _value.UserLoginId.LoginKey.LoginProvider; }
			set { _value.UserLoginId.LoginKey.LoginProvider = value; }
		}

		public virtual string UserLoginIdLoginKeyProviderKey {
			get { return _value.UserLoginId.LoginKey.ProviderKey; }
			set { _value.UserLoginId.LoginKey.ProviderKey = value; }
		}

		public virtual long UserVersion { 
			get { return _value.UserVersion; } 
			set { _value.UserVersion = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserLoginMvoStateEventIdFlattenedDto other = obj as UserLoginMvoStateEventIdFlattenedDto;
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

    public class UserLoginMvoStateEventIdFlattenedDtoFormatter : IdFlattenedDtoFormatterBase<UserLoginMvoStateEventIdFlattenedDto>
    {

    }

}



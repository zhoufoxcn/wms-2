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

	public class UserPermissionIdDtoWrapper : UserPermissionIdDto
	{

        private UserPermissionId _value = new UserPermissionId();

		public UserPermissionIdDtoWrapper()
		{
		}

		public UserPermissionIdDtoWrapper(UserPermissionId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override UserPermissionId ToUserPermissionId()
        {
            return this._value;
        }

		public override string UserId { 
			get { return _value.UserId; } 
			set { _value.UserId = value; } 
		}

		public override string PermissionId { 
			get { return _value.PermissionId; } 
			set { _value.PermissionId = value; } 
		}


	}

}



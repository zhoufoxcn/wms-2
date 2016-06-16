﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

    public partial class UserPermissionApplicationServiceFactory : IUserPermissionApplicationServiceFactory
    {

        public virtual IUserPermissionApplicationService UserPermissionApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["UserPermissionApplicationService"] as IUserPermissionApplicationService;
		    }
        }

        public virtual ICreateUserPermission NewCreateUserPermission()
        {
		    return new CreateUserPermission();
        }

        public virtual IMergePatchUserPermission NewMergePatchUserPermission()
        {
            return new MergePatchUserPermission();
        }

        public virtual IDeleteUserPermission NewDeleteUserPermission()
        {
            return new DeleteUserPermission();
        }

    }


}


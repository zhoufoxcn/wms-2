﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserClaimMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserClaimMvo
{

    public partial class UserClaimMvoApplicationServiceFactory : IUserClaimMvoApplicationServiceFactory
    {

        public virtual IUserClaimMvoApplicationService UserClaimMvoApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["UserClaimMvoApplicationService"] as IUserClaimMvoApplicationService;
		    }
        }

        public virtual ICreateUserClaimMvo NewCreateUserClaimMvo()
        {
		    return new CreateUserClaimMvo();
        }

        public virtual IMergePatchUserClaimMvo NewMergePatchUserClaimMvo()
        {
            return new MergePatchUserClaimMvo();
        }

        public virtual IDeleteUserClaimMvo NewDeleteUserClaimMvo()
        {
            return new DeleteUserClaimMvo();
        }

    }


}


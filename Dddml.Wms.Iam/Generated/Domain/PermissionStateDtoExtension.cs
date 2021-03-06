﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Permission;

namespace Dddml.Wms.Domain.Permission
{

	public static partial class PermissionStateDtoExtension
	{

        public static IPermissionCommand ToCreateOrMergePatchPermission(this PermissionStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchPermission<CreatePermissionDto, MergePatchPermissionDto>();
        }

        public static DeletePermissionDto ToDeletePermission(this PermissionStateDtoWrapper state)
        {
            return state.ToDeletePermission<DeletePermissionDto>();
        }

        public static MergePatchPermissionDto ToMergePatchPermission(this PermissionStateDtoWrapper state)
        {
            return state.ToMergePatchPermission<MergePatchPermissionDto>();
        }

        public static CreatePermissionDto ToCreatePermission(this PermissionStateDtoWrapper state)
        {
            return state.ToCreatePermission<CreatePermissionDto>();
        }
		

	}

}


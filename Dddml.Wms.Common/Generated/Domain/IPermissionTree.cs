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
    public partial interface IPermissionTree : ITree<IPermissionState>
    {
        new IEnumerable<IPermissionTree> Children { get; }
    }

    public partial interface IPermissionTreeRepository : ITreeRepository<IPermissionTree, string>
    {
    }

}


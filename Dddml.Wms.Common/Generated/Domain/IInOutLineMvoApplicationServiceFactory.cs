﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{

    public partial interface IInOutLineMvoApplicationServiceFactory
    {

        IInOutLineMvoApplicationService InOutLineMvoApplicationService { get; }

        ICreateInOutLineMvo NewCreateInOutLineMvo();

        IMergePatchInOutLineMvo NewMergePatchInOutLineMvo();

        IDeleteInOutLineMvo NewDeleteInOutLineMvo();
    }


}


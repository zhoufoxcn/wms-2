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

    public partial class YearPlanMvoApplicationServiceFactory : IYearPlanMvoApplicationServiceFactory
    {

        public virtual IYearPlanMvoApplicationService YearPlanMvoApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["YearPlanMvoApplicationService"] as IYearPlanMvoApplicationService;
		    }
        }

        public virtual ICreateYearPlanMvo NewCreateYearPlanMvo()
        {
		    return new CreateYearPlanMvo();
        }

        public virtual IMergePatchYearPlanMvo NewMergePatchYearPlanMvo()
        {
            return new MergePatchYearPlanMvo();
        }

        public virtual IDeleteYearPlanMvo NewDeleteYearPlanMvo()
        {
            return new DeleteYearPlanMvo();
        }

    }


}


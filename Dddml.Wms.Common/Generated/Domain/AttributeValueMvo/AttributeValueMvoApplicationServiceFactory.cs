﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeValueMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeValueMvo;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.AttributeValueMvo
{

    public partial class AttributeValueMvoApplicationServiceFactory : IAttributeValueMvoApplicationServiceFactory
    {

        public virtual IAttributeValueMvoApplicationService AttributeValueMvoApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["AttributeValueMvoApplicationService"] as IAttributeValueMvoApplicationService;
		    }
        }

        public virtual ICreateAttributeValueMvo NewCreateAttributeValueMvo()
        {
		    return new CreateAttributeValueMvo();
        }

        public virtual IMergePatchAttributeValueMvo NewMergePatchAttributeValueMvo()
        {
            return new MergePatchAttributeValueMvo();
        }

        public virtual IDeleteAttributeValueMvo NewDeleteAttributeValueMvo()
        {
            return new DeleteAttributeValueMvo();
        }

    }


}

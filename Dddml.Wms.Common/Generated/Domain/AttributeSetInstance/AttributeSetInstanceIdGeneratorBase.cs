﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstance;

namespace Dddml.Wms.Domain.AttributeSetInstance
{

    public abstract class AttributeSetInstanceIdGeneratorBase : IIdGenerator<string, ICreateAttributeSetInstance, IAttributeSetInstanceState>
    {
        public abstract string GenerateId(ICreateAttributeSetInstance command);

        public abstract string GetNextId();

        public abstract bool Equals(ICreateAttributeSetInstance command, IAttributeSetInstanceState state);

        public virtual bool IsSurrogateIdEnabled()
        {
            return true;
        }

    }

}

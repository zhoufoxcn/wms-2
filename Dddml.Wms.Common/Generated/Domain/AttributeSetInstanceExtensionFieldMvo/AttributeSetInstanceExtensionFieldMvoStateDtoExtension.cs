﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldMvo;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldMvo
{

	public static partial class AttributeSetInstanceExtensionFieldMvoStateDtoExtension
	{

        public static IAttributeSetInstanceExtensionFieldMvoCommand ToCreateOrMergePatchAttributeSetInstanceExtensionFieldMvo(this AttributeSetInstanceExtensionFieldMvoStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchAttributeSetInstanceExtensionFieldMvo<CreateAttributeSetInstanceExtensionFieldMvoDto, MergePatchAttributeSetInstanceExtensionFieldMvoDto>();
        }

        public static DeleteAttributeSetInstanceExtensionFieldMvoDto ToDeleteAttributeSetInstanceExtensionFieldMvo(this AttributeSetInstanceExtensionFieldMvoStateDtoWrapper state)
        {
            return state.ToDeleteAttributeSetInstanceExtensionFieldMvo<DeleteAttributeSetInstanceExtensionFieldMvoDto>();
        }

        public static MergePatchAttributeSetInstanceExtensionFieldMvoDto ToMergePatchAttributeSetInstanceExtensionFieldMvo(this AttributeSetInstanceExtensionFieldMvoStateDtoWrapper state)
        {
            return state.ToMergePatchAttributeSetInstanceExtensionFieldMvo<MergePatchAttributeSetInstanceExtensionFieldMvoDto>();
        }

        public static CreateAttributeSetInstanceExtensionFieldMvoDto ToCreateAttributeSetInstanceExtensionFieldMvo(this AttributeSetInstanceExtensionFieldMvoStateDtoWrapper state)
        {
            return state.ToCreateAttributeSetInstanceExtensionFieldMvo<CreateAttributeSetInstanceExtensionFieldMvoDto>();
        }
		

	}

}

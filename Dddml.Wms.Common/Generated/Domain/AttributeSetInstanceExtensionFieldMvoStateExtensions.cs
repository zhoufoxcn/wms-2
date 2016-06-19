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

	public static partial class AttributeSetInstanceExtensionFieldMvoStateExtensions
	{

        public static IAttributeSetInstanceExtensionFieldMvoCommand ToCreateOrMergePatchAttributeSetInstanceExtensionFieldMvo(this AttributeSetInstanceExtensionFieldMvoState state)
        {
            bool bUnsaved = ((IAttributeSetInstanceExtensionFieldMvoState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateAttributeSetInstanceExtensionFieldMvo();
            }
            else 
            {
                return state.ToMergePatchAttributeSetInstanceExtensionFieldMvo();
            }
        }

        public static DeleteAttributeSetInstanceExtensionFieldMvo ToDeleteAttributeSetInstanceExtensionFieldMvo(this AttributeSetInstanceExtensionFieldMvoState state)
        {
            var cmd = new DeleteAttributeSetInstanceExtensionFieldMvo();
            cmd.AttributeSetInstanceExtensionFieldId = state.AttributeSetInstanceExtensionFieldId;
            cmd.AttrSetInstEFGroupVersion = state.AttrSetInstEFGroupVersion;

            return cmd;
        }

        public static MergePatchAttributeSetInstanceExtensionFieldMvo ToMergePatchAttributeSetInstanceExtensionFieldMvo(this AttributeSetInstanceExtensionFieldMvoState state)
        {
            var cmd = new MergePatchAttributeSetInstanceExtensionFieldMvo();

            cmd.AttrSetInstEFGroupVersion = state.AttrSetInstEFGroupVersion;

            cmd.AttributeSetInstanceExtensionFieldId = state.AttributeSetInstanceExtensionFieldId;
            cmd.Name = state.Name;
            cmd.Type = state.Type;
            cmd.Length = state.Length;
            cmd.Alias = state.Alias;
            cmd.Description = state.Description;
            cmd.Version = state.Version;
            cmd.Active = state.Active;
            cmd.AttrSetInstEFGroupFieldType = state.AttrSetInstEFGroupFieldType;
            cmd.AttrSetInstEFGroupFieldLength = state.AttrSetInstEFGroupFieldLength;
            cmd.AttrSetInstEFGroupFieldCount = state.AttrSetInstEFGroupFieldCount;
            cmd.AttrSetInstEFGroupNameFormat = state.AttrSetInstEFGroupNameFormat;
            cmd.AttrSetInstEFGroupDescription = state.AttrSetInstEFGroupDescription;
            cmd.AttrSetInstEFGroupCreatedBy = state.AttrSetInstEFGroupCreatedBy;
            cmd.AttrSetInstEFGroupCreatedAt = state.AttrSetInstEFGroupCreatedAt;
            cmd.AttrSetInstEFGroupUpdatedBy = state.AttrSetInstEFGroupUpdatedBy;
            cmd.AttrSetInstEFGroupUpdatedAt = state.AttrSetInstEFGroupUpdatedAt;
            cmd.AttrSetInstEFGroupActive = state.AttrSetInstEFGroupActive;
            cmd.AttrSetInstEFGroupDeleted = state.AttrSetInstEFGroupDeleted;
            
            if (state.Name == null) { cmd.IsPropertyNameRemoved = true; }
            if (state.Type == null) { cmd.IsPropertyTypeRemoved = true; }
            if (state.Length == null) { cmd.IsPropertyLengthRemoved = true; }
            if (state.Alias == null) { cmd.IsPropertyAliasRemoved = true; }
            if (state.Description == null) { cmd.IsPropertyDescriptionRemoved = true; }
            if (state.AttrSetInstEFGroupFieldType == null) { cmd.IsPropertyAttrSetInstEFGroupFieldTypeRemoved = true; }
            if (state.AttrSetInstEFGroupFieldLength == null) { cmd.IsPropertyAttrSetInstEFGroupFieldLengthRemoved = true; }
            if (state.AttrSetInstEFGroupNameFormat == null) { cmd.IsPropertyAttrSetInstEFGroupNameFormatRemoved = true; }
            if (state.AttrSetInstEFGroupDescription == null) { cmd.IsPropertyAttrSetInstEFGroupDescriptionRemoved = true; }
            if (state.AttrSetInstEFGroupCreatedBy == null) { cmd.IsPropertyAttrSetInstEFGroupCreatedByRemoved = true; }
            if (state.AttrSetInstEFGroupUpdatedBy == null) { cmd.IsPropertyAttrSetInstEFGroupUpdatedByRemoved = true; }
            return cmd;
        }

        public static CreateAttributeSetInstanceExtensionFieldMvo ToCreateAttributeSetInstanceExtensionFieldMvo(this AttributeSetInstanceExtensionFieldMvoState state)
        {
            var cmd = new CreateAttributeSetInstanceExtensionFieldMvo();

            cmd.AttrSetInstEFGroupVersion = state.AttrSetInstEFGroupVersion;

            cmd.AttributeSetInstanceExtensionFieldId = state.AttributeSetInstanceExtensionFieldId;
            cmd.Name = state.Name;
            cmd.Type = state.Type;
            cmd.Length = state.Length;
            cmd.Alias = state.Alias;
            cmd.Description = state.Description;
            cmd.Version = state.Version;
            cmd.Active = state.Active;
            cmd.AttrSetInstEFGroupFieldType = state.AttrSetInstEFGroupFieldType;
            cmd.AttrSetInstEFGroupFieldLength = state.AttrSetInstEFGroupFieldLength;
            cmd.AttrSetInstEFGroupFieldCount = state.AttrSetInstEFGroupFieldCount;
            cmd.AttrSetInstEFGroupNameFormat = state.AttrSetInstEFGroupNameFormat;
            cmd.AttrSetInstEFGroupDescription = state.AttrSetInstEFGroupDescription;
            cmd.AttrSetInstEFGroupCreatedBy = state.AttrSetInstEFGroupCreatedBy;
            cmd.AttrSetInstEFGroupCreatedAt = state.AttrSetInstEFGroupCreatedAt;
            cmd.AttrSetInstEFGroupUpdatedBy = state.AttrSetInstEFGroupUpdatedBy;
            cmd.AttrSetInstEFGroupUpdatedAt = state.AttrSetInstEFGroupUpdatedAt;
            cmd.AttrSetInstEFGroupActive = state.AttrSetInstEFGroupActive;
            cmd.AttrSetInstEFGroupDeleted = state.AttrSetInstEFGroupDeleted;
            return cmd;
        }
		

	}

}


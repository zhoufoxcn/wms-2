package org.dddml.wms.domain.meta;

import java.util.HashMap;
import java.util.Map;

public final class AttributeSetInstanceExtensionFieldMvoFilteringProperties
{

    private AttributeSetInstanceExtensionFieldMvoFilteringProperties()
    {
    }

    public final static String[] propertyNames = new String[] {
            "Name",
            "Type",
            "Length",
            "Alias",
            "Description",
            "Version",
            "CreatedBy",
            "CreatedAt",
            "UpdatedBy",
            "UpdatedAt",
            "Active",
            "Deleted",
            "AttrSetInstEFGroupFieldType",
            "AttrSetInstEFGroupFieldLength",
            "AttrSetInstEFGroupFieldCount",
            "AttrSetInstEFGroupNameFormat",
            "AttrSetInstEFGroupDescription",
            "AttrSetInstEFGroupVersion",
            "AttrSetInstEFGroupCreatedBy",
            "AttrSetInstEFGroupCreatedAt",
            "AttrSetInstEFGroupUpdatedBy",
            "AttrSetInstEFGroupUpdatedAt",
            "AttrSetInstEFGroupActive",
            "AttrSetInstEFGroupDeleted",
            "AttributeSetInstanceExtensionFieldId.GroupId",
            "AttributeSetInstanceExtensionFieldId.Index",
    };

    public final static String[] propertyTypes = new String[] {
            "String",
            "String",
            "Integer",
            "String",
            "String",
            "Long",
            "String",
            "Date",
            "String",
            "Date",
            "Boolean",
            "Boolean",
            "String",
            "Integer",
            "Integer",
            "String",
            "String",
            "Long",
            "String",
            "Date",
            "String",
            "Date",
            "Boolean",
            "Boolean",
            "String",
            "String",
    };

    public final static Map<String, String> propertyMap;

    static {
        propertyMap = new HashMap<String, String>();
        for (int i = 0; i < propertyNames.length; i++ ) {
            propertyMap.put(propertyNames[i], propertyTypes[i]);
        }
    }

}


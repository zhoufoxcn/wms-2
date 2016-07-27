package org.dddml.wms.domain.meta;

import java.util.HashMap;
import java.util.Map;

public final class UserLoginFilteringProperties
{

    private UserLoginFilteringProperties()
    {
    }

    public static final String[] propertyNames = new String[] {
            "version",
            "createdBy",
            "createdAt",
            "updatedBy",
            "updatedAt",
            "active",
            "deleted",
            "userId",
            "loginKey.loginProvider",
            "loginKey.providerKey",
            "userLoginId.userId",
            "userLoginId.loginKeyLoginProvider",
            "userLoginId.loginKeyProviderKey",
    };

    public static final String[] propertyTypes = new String[] {
            "Long",
            "String",
            "Date",
            "String",
            "Date",
            "Boolean",
            "Boolean",
            "String",
            "String",
            "String",
            "String",
            "String",
            "String",
    };

    public static final Map<String, String> propertyTypeMap;

    static {
        propertyTypeMap = new HashMap<String, String>();
        for (int i = 0; i < propertyNames.length; i++ ) {
            propertyTypeMap.put(propertyNames[i], propertyTypes[i]);
        }
    }

}


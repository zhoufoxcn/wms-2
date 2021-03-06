package org.dddml.wms.domain;

import org.dddml.wms.specialization.CommandType;

public interface Command
{
    String COMMAND_TYPE_CREATE = CommandType.CREATE;

    String COMMAND_TYPE_MERGE_PATCH = CommandType.MERGE_PATCH;

    String COMMAND_TYPE_DELETE = CommandType.DELETE;

    String COMMAND_TYPE_REMOVE = CommandType.REMOVE;

    String getCommandType();

    void setCommandType(String commandType);

    String getCommandId();

    void setCommandId(String commandId);

    String getRequesterId();

    void setRequesterId(String requesterId);
}



package org.dddml.wms.domain.attributesetinstanceextensionfieldgroup;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractAttributeSetInstanceExtensionFieldCommandDto extends AbstractCommand
{
    private String index;

    public String getIndex()
    {
        return this.index;
    }

    public void setIndex(String index)
    {
        this.index = index;
    }


    public void copyTo(AbstractAttributeSetInstanceExtensionFieldCommand command)
    {
        command.setIndex(this.getIndex());
        
        command.setRequesterId(this.getRequesterId());
        command.setCommandId(this.getCommandId());
    }

}

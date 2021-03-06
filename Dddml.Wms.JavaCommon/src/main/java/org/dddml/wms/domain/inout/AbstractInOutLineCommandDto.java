package org.dddml.wms.domain.inout;

import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractInOutLineCommandDto extends AbstractCommand
{
    private Long lineNumber;

    public Long getLineNumber()
    {
        return this.lineNumber;
    }

    public void setLineNumber(Long lineNumber)
    {
        this.lineNumber = lineNumber;
    }


    public void copyTo(AbstractInOutLineCommand command)
    {
        command.setLineNumber(this.getLineNumber());
        
        command.setRequesterId(this.getRequesterId());
        command.setCommandId(this.getCommandId());
    }

}

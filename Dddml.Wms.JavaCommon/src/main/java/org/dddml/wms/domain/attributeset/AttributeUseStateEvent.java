package org.dddml.wms.domain.attributeset;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;

public interface AttributeUseStateEvent extends Event
{
    AttributeUseStateEventId getStateEventId();

    boolean getStateEventReadOnly();

    void setStateEventReadOnly(boolean readOnly);

    Long getVersion();

    void setVersion(Long version);

    Integer getSequenceNumber();

    void setSequenceNumber(Integer sequenceNumber);

    String getCreatedBy();

    void setCreatedBy(String createdBy);

    Date getCreatedAt();

    void setCreatedAt(Date createdAt);

    Boolean getActive();

    void setActive(Boolean active);

    String getAttributeSetId();

    void setAttributeSetId(String attributeSetId);

    String getCommandId();

    void setCommandId(String commandId);

    interface AttributeUseStateCreated extends AttributeUseStateEvent
    {
    
    }


    interface AttributeUseStateMergePatched extends AttributeUseStateEvent
    {
        Boolean getIsPropertySequenceNumberRemoved();

        void setIsPropertySequenceNumberRemoved(Boolean removed);

        Boolean getIsPropertyActiveRemoved();

        void setIsPropertyActiveRemoved(Boolean removed);


    }

    interface AttributeUseStateRemoved extends AttributeUseStateEvent
    {
    }


}


package org.dddml.wms.domain;

import java.util.*;
import java.util.Date;
import org.dddml.wms.specialization.*;

public abstract class AbstractAttributeValueStateEvent implements AttributeValueStateEvent
{
    private AttributeValueStateEventId stateEventId;

    public AttributeValueStateEventId getStateEventId() {
        return this.stateEventId;
    }

    public void setStateEventId(AttributeValueStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }
    
    private boolean stateEventReadOnly;

    public boolean getStateEventReadOnly() { return this.stateEventReadOnly; }

    public void setStateEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }

    private String name;

    public String getName()
    {
        return this.name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    private String description;

    public String getDescription()
    {
        return this.description;
    }

    public void setDescription(String description)
    {
        this.description = description;
    }

    private String referenceId;

    public String getReferenceId()
    {
        return this.referenceId;
    }

    public void setReferenceId(String referenceId)
    {
        this.referenceId = referenceId;
    }

    private String createdBy;

    public String getCreatedBy()
    {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy)
    {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt()
    {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt)
    {
        this.createdAt = createdAt;
    }

    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    private String attributeId;

    public String getAttributeId()
    {
        return this.attributeId;
    }

    public void setAttributeId(String attributeId)
    {
        this.attributeId = attributeId;
    }

    protected AbstractAttributeValueStateEvent() {
    }

    protected AbstractAttributeValueStateEvent(AttributeValueStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }


    public abstract String getStateEventType();


    public static abstract class AbstractAttributeValueStateCreated extends AbstractAttributeValueStateEvent implements AttributeValueStateCreated
    {
        public AbstractAttributeValueStateCreated() {
        }

        public AbstractAttributeValueStateCreated(AttributeValueStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

    }


/*
    public static abstract class AbstractAttributeValueStateMergePatched extends AbstractAttributeValueStateEvent implements AttributeValueStateMergePatched
    {
        Boolean isPropertyNameRemoved();

        void setPropertyNameRemoved(Boolean removed);

        Boolean isPropertyDescriptionRemoved();

        void setPropertyDescriptionRemoved(Boolean removed);

        Boolean isPropertyReferenceIdRemoved();

        void setPropertyReferenceIdRemoved(Boolean removed);

        Boolean isPropertyActiveRemoved();

        void setPropertyActiveRemoved(Boolean removed);


    }
*/

    public static abstract class AbstractAttributeValueStateRemoved extends AbstractAttributeValueStateEvent implements AttributeValueStateRemoved
    {
        public AbstractAttributeValueStateRemoved() {
        }

        public AbstractAttributeValueStateRemoved(AttributeValueStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.REMOVED;
        }

    }

}

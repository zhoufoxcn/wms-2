package org.dddml.wms.domain;

import java.util.*;
import java.util.Date;
import org.dddml.wms.specialization.*;

public abstract class AbstractOrganizationStructureStateEvent implements OrganizationStructureStateEvent
{
    private OrganizationStructureStateEventId stateEventId;

    public OrganizationStructureStateEventId getStateEventId() {
        return this.stateEventId;
    }

    public void setStateEventId(OrganizationStructureStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }
    
    private boolean stateEventReadOnly;

    public boolean getStateEventReadOnly() { return this.stateEventReadOnly; }

    public void setStateEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

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

    protected AbstractOrganizationStructureStateEvent() {
    }

    protected AbstractOrganizationStructureStateEvent(OrganizationStructureStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }


    public abstract String getStateEventType();


    public static abstract class AbstractOrganizationStructureStateCreated extends AbstractOrganizationStructureStateEvent implements OrganizationStructureStateCreated
    {
        public AbstractOrganizationStructureStateCreated() {
        }

        public AbstractOrganizationStructureStateCreated(OrganizationStructureStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

    }


/*
    public static abstract class AbstractOrganizationStructureStateMergePatched extends AbstractOrganizationStructureStateEvent implements OrganizationStructureStateMergePatched
    {
        Boolean isPropertyActiveRemoved();

        void setPropertyActiveRemoved(Boolean removed);


    }
*/

    public static abstract class AbstractOrganizationStructureStateDeleted extends AbstractOrganizationStructureStateEvent implements OrganizationStructureStateDeleted
    {
        public AbstractOrganizationStructureStateDeleted() {
        }

        public AbstractOrganizationStructureStateDeleted(OrganizationStructureStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.DELETED;
        }

    }

}

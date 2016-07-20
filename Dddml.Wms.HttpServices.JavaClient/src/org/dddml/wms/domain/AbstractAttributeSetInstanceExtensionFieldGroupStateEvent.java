package org.dddml.wms.domain;

import java.util.*;
import java.util.Date;
import org.dddml.wms.specialization.*;

public abstract class AbstractAttributeSetInstanceExtensionFieldGroupStateEvent implements AttributeSetInstanceExtensionFieldGroupStateEvent
{
    private AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId;

    public AttributeSetInstanceExtensionFieldGroupStateEventId getStateEventId() {
        return this.stateEventId;
    }

    public void setStateEventId(AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }
    
    private boolean stateEventReadOnly;

    public boolean getStateEventReadOnly() { return this.stateEventReadOnly; }

    public void setStateEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

    private String fieldType;

    public String getFieldType()
    {
        return this.fieldType;
    }

    public void setFieldType(String fieldType)
    {
        this.fieldType = fieldType;
    }

    private Integer fieldLength;

    public Integer getFieldLength()
    {
        return this.fieldLength;
    }

    public void setFieldLength(Integer fieldLength)
    {
        this.fieldLength = fieldLength;
    }

    private Integer fieldCount;

    public Integer getFieldCount()
    {
        return this.fieldCount;
    }

    public void setFieldCount(Integer fieldCount)
    {
        this.fieldCount = fieldCount;
    }

    private String nameFormat;

    public String getNameFormat()
    {
        return this.nameFormat;
    }

    public void setNameFormat(String nameFormat)
    {
        this.nameFormat = nameFormat;
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

    protected AbstractAttributeSetInstanceExtensionFieldGroupStateEvent() {
    }

    protected AbstractAttributeSetInstanceExtensionFieldGroupStateEvent(AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }

    protected AttributeSetInstanceExtensionFieldStateEventDao getAttributeSetInstanceExtensionFieldStateEventDao() {
        return (AttributeSetInstanceExtensionFieldStateEventDao)ApplicationContext.current.get("AttributeSetInstanceExtensionFieldStateEventDao");
    }

    protected AttributeSetInstanceExtensionFieldStateEventId newAttributeSetInstanceExtensionFieldStateEventId(String index)
    {
        AttributeSetInstanceExtensionFieldStateEventId stateEventId = new AttributeSetInstanceExtensionFieldStateEventId(this.getStateEventId().getId(), 
            index, 
            this.getStateEventId().getVersion());
        return stateEventId;
    }

    protected void throwOnInconsistentEventIds(AttributeSetInstanceExtensionFieldStateEvent e)
    {
        throwOnInconsistentEventIds(this, e);
    }

    public static void throwOnInconsistentEventIds(AttributeSetInstanceExtensionFieldGroupStateEvent oe, AttributeSetInstanceExtensionFieldStateEvent e)
    {
        if (!oe.getStateEventId().getId().equals(e.getStateEventId().getGroupId()))
        { 
            throw DomainError.named("inconsistentEventIds", "Outer Id Id %1$s but inner id GroupId %2$s", 
                oe.getStateEventId().getId(), e.getStateEventId().getGroupId());
        }
    }


    public abstract String getStateEventType();


    public static abstract class AbstractAttributeSetInstanceExtensionFieldGroupStateCreated extends AbstractAttributeSetInstanceExtensionFieldGroupStateEvent implements AttributeSetInstanceExtensionFieldGroupStateCreated, Saveable
    {
        public AbstractAttributeSetInstanceExtensionFieldGroupStateCreated() {
        }

        public AbstractAttributeSetInstanceExtensionFieldGroupStateCreated(AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

        private Map<AttributeSetInstanceExtensionFieldStateEventId, AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated> attributeSetInstanceExtensionFieldEvents = new HashMap<AttributeSetInstanceExtensionFieldStateEventId, AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated>();
        
        private Iterable<AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated> readOnlyAttributeSetInstanceExtensionFieldEvents;

        public Iterable<AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated> getAttributeSetInstanceExtensionFieldEvents()
        {
            if (!getStateEventReadOnly())
            {
                return this.attributeSetInstanceExtensionFieldEvents.values();
            }
            else
            {
                if (readOnlyAttributeSetInstanceExtensionFieldEvents != null) { return readOnlyAttributeSetInstanceExtensionFieldEvents; }
                AttributeSetInstanceExtensionFieldStateEventDao eventDao = getAttributeSetInstanceExtensionFieldStateEventDao();
                List<AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated> eL = new ArrayList<AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated>();
                for (AttributeSetInstanceExtensionFieldStateEvent e : eventDao.findByAttributeSetInstanceExtensionFieldGroupStateEventId(this.getStateEventId()))
                {
                    e.setStateEventReadOnly(true);
                    eL.add((AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated)e);
                }
                return (readOnlyAttributeSetInstanceExtensionFieldEvents = eL);
            }
        }

        public void setAttributeSetInstanceExtensionFieldEvents(Iterable<AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated> es)
        {
            if (es != null)
            {
                for (AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated e : es)
                {
                    addAttributeSetInstanceExtensionFieldEvent(e);
                }
            }
            else { this.attributeSetInstanceExtensionFieldEvents.clear(); }
        }
        
        public void addAttributeSetInstanceExtensionFieldEvent(AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated e)
        {
            throwOnInconsistentEventIds(e);
            this.attributeSetInstanceExtensionFieldEvents.put(e.getStateEventId(), e);
        }

        public abstract AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated newAttributeSetInstanceExtensionFieldStateCreated(String index);
//        {
//            return new AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated(newAttributeSetInstanceExtensionFieldStateEventId(index));
//        }

        public void save()
        {
            for (AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated e : this.getAttributeSetInstanceExtensionFieldEvents()) {
                getAttributeSetInstanceExtensionFieldStateEventDao().save(e);
            }
        }
    }


/*
    public static abstract class AbstractAttributeSetInstanceExtensionFieldGroupStateMergePatched extends AbstractAttributeSetInstanceExtensionFieldGroupStateEvent implements AttributeSetInstanceExtensionFieldGroupStateMergePatched, Saveable
    {
        Boolean isPropertyFieldTypeRemoved();

        void setPropertyFieldTypeRemoved(Boolean removed);

        Boolean isPropertyFieldLengthRemoved();

        void setPropertyFieldLengthRemoved(Boolean removed);

        Boolean isPropertyFieldCountRemoved();

        void setPropertyFieldCountRemoved(Boolean removed);

        Boolean isPropertyNameFormatRemoved();

        void setPropertyNameFormatRemoved(Boolean removed);

        Boolean isPropertyDescriptionRemoved();

        void setPropertyDescriptionRemoved(Boolean removed);

        Boolean isPropertyActiveRemoved();

        void setPropertyActiveRemoved(Boolean removed);

        Iterable<AttributeSetInstanceExtensionFieldStateEvent> getAttributeSetInstanceExtensionFieldEvents();
        
        void addAttributeSetInstanceExtensionFieldEvent(AttributeSetInstanceExtensionFieldStateEvent e);

        AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateCreated newAttributeSetInstanceExtensionFieldStateCreated(String index);

        AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateMergePatched newAttributeSetInstanceExtensionFieldStateMergePatched(String index);

        AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved newAttributeSetInstanceExtensionFieldStateRemoved(String index);


    }
*/

    public static abstract class AbstractAttributeSetInstanceExtensionFieldGroupStateDeleted extends AbstractAttributeSetInstanceExtensionFieldGroupStateEvent implements AttributeSetInstanceExtensionFieldGroupStateDeleted, Saveable
    {
        public AbstractAttributeSetInstanceExtensionFieldGroupStateDeleted() {
        }

        public AbstractAttributeSetInstanceExtensionFieldGroupStateDeleted(AttributeSetInstanceExtensionFieldGroupStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.DELETED;
        }

		
        private Map<AttributeSetInstanceExtensionFieldStateEventId, AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved> attributeSetInstanceExtensionFieldEvents = new HashMap<AttributeSetInstanceExtensionFieldStateEventId, AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved>();
        
        private Iterable<AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved> readOnlyAttributeSetInstanceExtensionFieldEvents;

        public Iterable<AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved> getAttributeSetInstanceExtensionFieldEvents()
        {
            if (!getStateEventReadOnly())
            {
                return this.attributeSetInstanceExtensionFieldEvents.values();
            }
            else
            {
                if (readOnlyAttributeSetInstanceExtensionFieldEvents != null) { return readOnlyAttributeSetInstanceExtensionFieldEvents; }
                AttributeSetInstanceExtensionFieldStateEventDao eventDao = getAttributeSetInstanceExtensionFieldStateEventDao();
                List<AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved> eL = new ArrayList<AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved>();
                for (AttributeSetInstanceExtensionFieldStateEvent e : eventDao.findByAttributeSetInstanceExtensionFieldGroupStateEventId(this.getStateEventId()))
                {
                    e.setStateEventReadOnly(true);
                    eL.add((AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved)e);
                }
                return (readOnlyAttributeSetInstanceExtensionFieldEvents = eL);
            }
        }

        public void setAttributeSetInstanceExtensionFieldEvents(Iterable<AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved> es)
        {
            if (es != null)
            {
                for (AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved e : es)
                {
                    addAttributeSetInstanceExtensionFieldEvent(e);
                }
            }
            else { this.attributeSetInstanceExtensionFieldEvents.clear(); }
        }
        
        public void addAttributeSetInstanceExtensionFieldEvent(AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved e)
        {
            throwOnInconsistentEventIds(e);
            this.attributeSetInstanceExtensionFieldEvents.put(e.getStateEventId(), e);
        }

        public abstract AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved newAttributeSetInstanceExtensionFieldStateRemoved(String index);
//        {
//            return new AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved(newAttributeSetInstanceExtensionFieldStateEventId(index));
//        }

        public void save()
        {
            for (AttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldStateRemoved e : this.getAttributeSetInstanceExtensionFieldEvents()) {
                getAttributeSetInstanceExtensionFieldStateEventDao().save(e);
            }
        }
    }

}

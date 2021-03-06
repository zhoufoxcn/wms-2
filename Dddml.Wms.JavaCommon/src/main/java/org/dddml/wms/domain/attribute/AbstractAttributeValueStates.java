package org.dddml.wms.domain.attribute;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.ApplicationContext;

public abstract class AbstractAttributeValueStates implements AttributeValueStates
{
    protected AttributeValueStateDao getAttributeValueStateDao()
    {
        return (AttributeValueStateDao)ApplicationContext.current.get("AttributeValueStateDao");
    }

    private AttributeState attributeState;

    private Map<AttributeValueId, AttributeValueState> loadedAttributeValueStates = new HashMap<AttributeValueId, AttributeValueState>();

    private Map<AttributeValueId, AttributeValueState> removedAttributeValueStates = new HashMap<AttributeValueId, AttributeValueState>();

    protected Iterable<AttributeValueState> getLoadedAttributeValueStates() {
        return this.loadedAttributeValueStates.values();
    }

    private boolean forReapplying;

    public boolean getForReapplying() {
        return forReapplying;
    }

    public void setForReapplying(boolean forReapplying) {
        this.forReapplying = forReapplying;
    }

    protected Iterable<AttributeValueState> getInnerIterable() {
        if (!getForReapplying()) {
            return getAttributeValueStateDao().findByAttributeId(attributeState.getAttributeId());
        } else {
            List<AttributeValueState> ss = new ArrayList<AttributeValueState>();
            for (AttributeValueState s : loadedAttributeValueStates.values()) {
                if (!(removedAttributeValueStates.containsKey(s.getAttributeValueId()) && s.getDeleted())) {
                    ss.add(s);
                }
            }
            return ss;
        }
    }

    public AbstractAttributeValueStates(AttributeState outerState) {
        this.attributeState = outerState;
        this.setForReapplying(outerState.getForReapplying());
    }

    @Override
    public Iterator<AttributeValueState> iterator() {
        return getInnerIterable().iterator();
    }

    public AttributeValueState get(String value) {
        return get(value, false, false);
    }

    public AttributeValueState get(String value, boolean forCreation) {
        return get(value, forCreation, false);
    }

    public AttributeValueState get(String value, boolean forCreation, boolean nullAllowed) {
        AttributeValueId globalId = new AttributeValueId(attributeState.getAttributeId(), value);
        if (loadedAttributeValueStates.containsKey(globalId)) {
            return loadedAttributeValueStates.get(globalId);
        }
        if (forCreation || getForReapplying()) {
            AttributeValueState state = new AbstractAttributeValueState.SimpleAttributeValueState(getForReapplying());
            state.setAttributeValueId(globalId);
            loadedAttributeValueStates.put(globalId, state);
            return state;
        } else {
            AttributeValueState state = getAttributeValueStateDao().get(globalId, nullAllowed);
            if (state != null) {
                loadedAttributeValueStates.put(globalId, state);
            }
            return state;
        }

    }

    public void remove(AttributeValueState state)
    {
        this.removedAttributeValueStates.put(state.getAttributeValueId(), state);
    }

    public void addToSave(AttributeValueState state)
    {
        this.loadedAttributeValueStates.put(state.getAttributeValueId(), state);
    }

    //region Saveable Implements

    public void save ()
    {
        for (AttributeValueState s : this.getLoadedAttributeValueStates()) {
            getAttributeValueStateDao().save(s);
        }
        for (AttributeValueState s : this.removedAttributeValueStates.values()) {
            getAttributeValueStateDao().delete(s);
        }
    }

    //endregion

}



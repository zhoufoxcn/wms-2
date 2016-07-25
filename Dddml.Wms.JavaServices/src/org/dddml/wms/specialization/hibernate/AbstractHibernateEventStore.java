package org.dddml.wms.specialization.hibernate;

import org.dddml.wms.specialization.*;
import org.hibernate.*;

import java.io.Serializable;
import java.util.Collection;
import java.util.function.Consumer;

/**
 * Created by Yang on 2016/7/25.
 */
public abstract class AbstractHibernateEventStore implements EventStore {
    public SessionFactory sessionFactory;

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }

    //[Transaction (ReadOnly = true)]
    @Override
    public EventStream loadEventStream(EventStoreAggregateId aggregateId) {
        throw new UnsupportedOperationException();
    }

    //[Transaction]
    @Override
    public void appendEvents(EventStoreAggregateId aggregateId, long version, Collection<Event> events, Consumer<Collection<Event>> afterEventsAppended) {
        for (Event e : events) {
            getCurrentSession().save(e);
            if (e instanceof Saveable) {
                Saveable saveable = (Saveable) e;
                saveable.save();
            }
        }
        //System.out.println("####################################################");
        afterEventsAppended.accept(events);
        //System.out.println("####################################################");
    }

    //[Transaction(ReadOnly = true)]
    @Override
    public Event findLastEvent(Class eventType, EventStoreAggregateId eventStoreAggregateId, long version) {
        Class supportedEventType = getSupportedStateEventType();
        if (!eventType.isAssignableFrom(supportedEventType)) {
            throw new UnsupportedOperationException();
        }
        Serializable eventId = getEventId(eventStoreAggregateId, version);
        return (Event) getCurrentSession().get(eventType, eventId);
    }

    //[Transaction(ReadOnly = true)]
    @Override
    public Event getStateEvent(EventStoreAggregateId eventStoreAggregateId, long version) {
        Serializable eventId = getEventId(eventStoreAggregateId, version);
        return (Event) getCurrentSession().get(getSupportedStateEventType(), eventId);
    }

    protected abstract Class getSupportedStateEventType();

    protected abstract Serializable getEventId(EventStoreAggregateId eventStoreAggregateId, long version);

}

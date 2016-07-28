package org.dddml.wms.domain;

import java.util.*;
import java.util.function.Consumer;
import java.util.Date;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.*;

public abstract class AbstractUserApplicationService implements UserApplicationService
{

    private EventStore eventStore;

    protected EventStore getEventStore()
    {
        return eventStore;
    }

    private UserStateRepository stateRepository;

    protected UserStateRepository getStateRepository()
    {
        return stateRepository;
    }

    public AbstractUserApplicationService(EventStore eventStore, UserStateRepository stateRepository)
    {
        this.eventStore = eventStore;
        this.stateRepository = stateRepository;
    }

    public void when(UserCommand.CreateUser c) {
        update(c, ar -> ar.create(c));
    }

    public void when(UserCommand.MergePatchUser c) {
        update(c, ar -> ar.mergePatch(c));
    }

    public void when(UserCommand.DeleteUser c) {
        update(c, ar -> ar.delete(c));
    }

    public UserState get(String id) {
        UserState state = getStateRepository().get(id);

        if (state != null && state.isStateUnsaved()) { state = null; }

        return state;
    }

    public Iterable<UserState> getAll(Integer firstResult, Integer maxResults) {
        return getStateRepository().getAll(firstResult, maxResults);
    }

    public Iterable<UserState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().get(filter, orders, firstResult, maxResults);
    }

    //public Iterable<UserState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    public Iterable<UserState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateRepository().getByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
    }

    public long getCount(Iterable<Map.Entry<String, Object>> filter) {
        return getStateRepository().getCount(filter);
    }

    //public long getCount(Criterion filter);

    public UserStateEvent getStateEvent(String userId, long version) {
        throw new UnsupportedOperationException(); //todo
    }

    public UserAggregate getUserAggregate(UserState state)
    {
        return new AbstractUserAggregate.SimpleUserAggregate(state);
    }

    public EventStoreAggregateId toEventStoreAggregateId(String aggregateId)
    {
        return new EventStoreAggregateId.SimpleEventStoreAggregateId(aggregateId);
    }

    protected void update(UserCommand c, Consumer<UserAggregate> action)
    {
        String aggregateId = c.getUserId();
        UserState state = getStateRepository().get(aggregateId);
        UserAggregate aggregate = getUserAggregate(state);

        EventStoreAggregateId eventStoreAggregateId = toEventStoreAggregateId(aggregateId);

        boolean repeated = isRepeatedCommand(c, eventStoreAggregateId, state);
        if (repeated) { return; }

        aggregate.throwOnInvalidStateTransition(c);
        action.accept(aggregate);
        getEventStore().appendEvents(eventStoreAggregateId, c.getVersion(), // State version may be null!
            aggregate.getChanges(), (events) -> { getStateRepository().save(state); });
        
    }

    protected boolean isRepeatedCommand(UserCommand command, EventStoreAggregateId eventStoreAggregateId, UserState state)
    {
        boolean repeated = false;
        if (command.getVersion() == null) { command.setVersion(UserState.VERSION_NULL); }
        if (state.getVersion() != null && state.getVersion() > command.getVersion())
        {
            Event lastEvent = getEventStore().findLastEvent(UserStateEvent.class, eventStoreAggregateId, command.getVersion());
            if (lastEvent != null && lastEvent instanceof AbstractStateEvent && command.getCommandId().equals(((AbstractStateEvent) lastEvent).getCommandId()))
            {
                repeated = true;
            }
        }
        return repeated;
    }

    public static class SimpleUserApplicationService extends AbstractUserApplicationService 
    {
        public SimpleUserApplicationService(EventStore eventStore, UserStateRepository stateRepository)
        {
            super(eventStore, stateRepository);
        }

    }

}

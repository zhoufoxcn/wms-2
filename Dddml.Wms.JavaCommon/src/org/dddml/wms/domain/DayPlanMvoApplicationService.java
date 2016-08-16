package org.dddml.wms.domain;

import java.util.Map;
import java.util.List;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.Command;

public interface DayPlanMvoApplicationService
{
    void when(DayPlanMvoCommand.CreateDayPlanMvo c);

    void when(DayPlanMvoCommand.MergePatchDayPlanMvo c);

    void when(DayPlanMvoCommand.DeleteDayPlanMvo c);

    DayPlanMvoState get(DayPlanId id);

    Iterable<DayPlanMvoState> getAll(Integer firstResult, Integer maxResults);

    Iterable<DayPlanMvoState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<DayPlanMvoState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<DayPlanMvoState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults);

    long getCount(Iterable<Map.Entry<String, Object>> filter);

    long getCount(Criterion filter);

    DayPlanMvoStateEvent getStateEvent(DayPlanId dayPlanId, long version);

}


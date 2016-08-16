package org.dddml.wms.domain.hibernate;

import java.util.*;
import java.util.Date;
import org.hibernate.Session;
import org.hibernate.Criteria;
import org.hibernate.criterion.Order;
import org.hibernate.criterion.Criterion;
import org.hibernate.criterion.Projections;
import org.hibernate.SessionFactory;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.*;
import org.springframework.transaction.annotation.Transactional;

public class HibernatePersonStateRepository implements PersonStateRepository
{
    private SessionFactory sessionFactory;

    public SessionFactory getSessionFactory() { return this.sessionFactory; }

    public void setSessionFactory(SessionFactory sessionFactory) { this.sessionFactory = sessionFactory; }

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }
    
    @Transactional(readOnly = true)
    public PersonState get(PersonalName id)
    {
        PersonState state = (PersonState)getCurrentSession().get(AbstractPersonState.SimplePersonState.class, id);
        if (state == null) {
            state = new AbstractPersonState.SimplePersonState();
            state.setPersonalName(id);
        }
        return state;
    }

    @Transactional(readOnly = true)
    public Iterable<PersonState> getAll(Integer firstResult, Integer maxResults)
    {
        Criteria criteria = getCurrentSession().createCriteria(AbstractPersonState.SimplePersonState.class);
        if (firstResult != null) { criteria.setFirstResult(firstResult); }
        if (maxResults != null) { criteria.setMaxResults(maxResults); }
         addNotDeletedRestriction(criteria);
        return criteria.list();
    }

    public void save(PersonState state)
    {
        if(state.getVersion() == null) {
            getCurrentSession().save(state);
        }else {
            getCurrentSession().update(state);
        }

        if (state instanceof Saveable)
        {
            Saveable saveable = (Saveable) state;
            saveable.save();
        }
    }

    @Transactional(readOnly = true)
    public Iterable<PersonState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults)
    {
        Criteria criteria = getCurrentSession().createCriteria(PersonState.class);

        HibernateUtils.criteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
        addNotDeletedRestriction(criteria);
        return criteria.list();
    }

    @Transactional(readOnly = true)
    public Iterable<PersonState> get(org.dddml.support.criterion.Criterion filter, List<String> orders, Integer firstResult, Integer maxResults)
    {
        Criteria criteria = getCurrentSession().createCriteria(PersonState.class);

        HibernateUtils.criteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
        addNotDeletedRestriction(criteria);
        return criteria.list();
    }

    @Transactional(readOnly = true)
    public PersonState getFirst(Iterable<Map.Entry<String, Object>> filter, List<String> orders)
    {
        List<PersonState> list = (List<PersonState>)get(filter, orders, 0, 1);
        if (list == null || list.size() <= 0)
        {
            return null;
        }
        return list.get(0);
    }

    @Transactional(readOnly = true)
    public PersonState getFirst(Map.Entry<String, Object> keyValue, List<String> orders)
    {
        List<Map.Entry<String, Object>> filter = new ArrayList<>();
        filter.add(keyValue);
        return getFirst(filter, orders);
    }

    @Transactional(readOnly = true)
    public Iterable<PersonState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults)
    {
        Map.Entry<String, Object> keyValue = new java.util.AbstractMap.SimpleEntry<String, Object> (propertyName, propertyValue);
        List<Map.Entry<String, Object>> filter = new ArrayList<Map.Entry<String, Object>>();
        filter.add(keyValue);
        return get(filter, orders, firstResult, maxResults);
    }

    @Transactional(readOnly = true)
    public long getCount(Iterable<Map.Entry<String, Object>> filter)
    {
        Criteria criteria = getCurrentSession().createCriteria(PersonState.class);
        criteria.setProjection(Projections.rowCount());
        if (filter != null) {
            HibernateUtils.criteriaAddFilter(criteria, filter);
        }
        addNotDeletedRestriction(criteria);
        return (long)criteria.uniqueResult();
    }

    @Transactional(readOnly = true)
    public long getCount(org.dddml.support.criterion.Criterion filter)
    {
        Criteria criteria = getCurrentSession().createCriteria(PersonState.class);
        criteria.setProjection(Projections.rowCount());
        if (filter != null)
        {
            org.hibernate.criterion.Criterion hc = CriterionUtils.toHibernateCriterion(filter);
            criteria.add(hc);
        }
        addNotDeletedRestriction(criteria);
        return (long)criteria.uniqueResult();
    }

    @Transactional(readOnly = true)
    public YearPlanState getYearPlan(PersonalName personalName, Integer year)
    {
        YearPlanId entityId = new YearPlanId(personalName, year);
        return (YearPlanState) getCurrentSession().get(AbstractYearPlanState.SimpleYearPlanState.class, entityId);
    }

    @Transactional(readOnly = true)
    public MonthPlanState getMonthPlan(PersonalName personalName, Integer year, Integer month)
    {
        MonthPlanId entityId = new MonthPlanId(personalName, year, month);
        return (MonthPlanState) getCurrentSession().get(AbstractMonthPlanState.SimpleMonthPlanState.class, entityId);
    }

    @Transactional(readOnly = true)
    public DayPlanState getDayPlan(PersonalName personalName, Integer year, Integer month, Integer day)
    {
        DayPlanId entityId = new DayPlanId(personalName, year, month, day);
        return (DayPlanState) getCurrentSession().get(AbstractDayPlanState.SimpleDayPlanState.class, entityId);
    }


    protected static void addNotDeletedRestriction(Criteria criteria)
    {
        criteria.add(org.hibernate.criterion.Restrictions.eq("deleted", false));
    }

}


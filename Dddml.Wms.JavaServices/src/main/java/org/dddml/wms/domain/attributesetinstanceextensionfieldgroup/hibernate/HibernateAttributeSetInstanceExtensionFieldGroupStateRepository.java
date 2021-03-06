package org.dddml.wms.domain.attributesetinstanceextensionfieldgroup.hibernate;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.hibernate.Session;
import org.hibernate.Criteria;
import org.hibernate.criterion.Order;
import org.hibernate.criterion.Criterion;
import org.hibernate.criterion.Projections;
import org.hibernate.SessionFactory;
import org.dddml.wms.domain.attributesetinstanceextensionfieldgroup.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.specialization.hibernate.*;
import org.springframework.transaction.annotation.Transactional;

public class HibernateAttributeSetInstanceExtensionFieldGroupStateRepository implements AttributeSetInstanceExtensionFieldGroupStateRepository
{
    private SessionFactory sessionFactory;

    public SessionFactory getSessionFactory() { return this.sessionFactory; }

    public void setSessionFactory(SessionFactory sessionFactory) { this.sessionFactory = sessionFactory; }

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }
    
    private static final Set<String> readOnlyPropertyPascalCaseNames = new HashSet<String>(Arrays.asList("Id", "FieldType", "FieldLength", "FieldCount", "NameFormat", "Description", "Fields", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted"));
    
    private ReadOnlyProxyGenerator readOnlyProxyGenerator;
    
    public ReadOnlyProxyGenerator getReadOnlyProxyGenerator() {
        return readOnlyProxyGenerator;
    }

    public void setReadOnlyProxyGenerator(ReadOnlyProxyGenerator readOnlyProxyGenerator) {
        this.readOnlyProxyGenerator = readOnlyProxyGenerator;
    }

    @Transactional(readOnly = true)
    public AttributeSetInstanceExtensionFieldGroupState get(String id, boolean nullAllowed)
    {
        AttributeSetInstanceExtensionFieldGroupState state = (AttributeSetInstanceExtensionFieldGroupState)getCurrentSession().get(AbstractAttributeSetInstanceExtensionFieldGroupState.SimpleAttributeSetInstanceExtensionFieldGroupState.class, id);
        if (!nullAllowed && state == null) {
            state = new AbstractAttributeSetInstanceExtensionFieldGroupState.SimpleAttributeSetInstanceExtensionFieldGroupState();
            state.setId(id);
        }
        if (getReadOnlyProxyGenerator() != null && state != null) {
            return (AttributeSetInstanceExtensionFieldGroupState) getReadOnlyProxyGenerator().createProxy(state, new Class[]{AttributeSetInstanceExtensionFieldGroupState.class, Saveable.class}, "getStateReadOnly", readOnlyPropertyPascalCaseNames);
        }
        return state;
    }

    public void save(AttributeSetInstanceExtensionFieldGroupState state)
    {
        AttributeSetInstanceExtensionFieldGroupState s = state;
        if (getReadOnlyProxyGenerator() != null) {
            s = (AttributeSetInstanceExtensionFieldGroupState) getReadOnlyProxyGenerator().getTarget(state);
        }
        if(s.getVersion() == null) {
            getCurrentSession().save(s);
        }else {
            getCurrentSession().update(s);
        }

        if (s instanceof Saveable)
        {
            Saveable saveable = (Saveable) s;
            saveable.save();
        }
    }

    //protected static void addNotDeletedRestriction(Criteria criteria) {
    //    criteria.add(org.hibernate.criterion.Restrictions.eq("deleted", false));
    //}

}


package org.dddml.wms.domain.hibernate;

import java.util.Date;
import org.hibernate.*;
import org.hibernate.criterion.*;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public class HibernateUserRoleStateDao implements UserRoleStateDao
{
    public SessionFactory sessionFactory;

    protected Session getCurrentSession() {
        return this.sessionFactory.getCurrentSession();
    }

    //[Transaction(ReadOnly = true)]
    @Override
    public UserRoleState get(UserRoleId id)
    {
        UserRoleState state = (UserRoleState) getCurrentSession().get(AbstractUserRoleState.SimpleUserRoleState.class, id);
        if (state == null)
        {
            state = new AbstractUserRoleState.SimpleUserRoleState();
            state.setUserRoleId(id);
        }
        return state;
    }

    @Override
    public void save(UserRoleState state)
    {
        getCurrentSession().saveOrUpdate(state);
        if (state instanceof Saveable)
        {
            Saveable saveable = (Saveable) state;
            saveable.save();
        }
    }

    //[Transaction(ReadOnly = true)]
    @Override
    public Iterable<UserRoleState> findByUserId(String userId)
    {
        Criteria criteria = getCurrentSession().createCriteria(AbstractUserRoleState.SimpleUserRoleState.class);
        Junction partIdCondition = Restrictions.conjunction()
            .add(Restrictions.eq("userRoleId.userId", userId))
            ;
        return criteria.add(partIdCondition).list();
    }

    @Override
    public void delete(UserRoleState state)
    {
        if (state instanceof Saveable)
        {
            Saveable saveable = (Saveable) state;
            saveable.save();
        }
        getCurrentSession().delete(state);
    }

}

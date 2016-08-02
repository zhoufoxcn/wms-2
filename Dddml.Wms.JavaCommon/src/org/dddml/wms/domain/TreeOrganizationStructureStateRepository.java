// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

package org.dddml.wms.domain;

import java.util.*;
import java.util.Date;
import org.dddml.support.criterion.Criterion;
import org.dddml.wms.specialization.*;

public interface TreeOrganizationStructureStateRepository extends OrganizationStructureStateRepository
{
    Iterable<OrganizationStructureState> getOrganizationTreeRoots(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<OrganizationStructureState> getOrganizationTreeChildren(String parentId, Criterion filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<OrganizationStructureState> getOrganizationTreeRoots(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

    Iterable<OrganizationStructureState> getOrganizationTreeChildren(String parentId, Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults);

}


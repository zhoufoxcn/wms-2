package org.dddml.wms.restful.resource;

import java.util.*;
import javax.servlet.http.*;
import javax.validation.constraints.*;
import javax.ws.rs.*;
import javax.ws.rs.core.*;

import org.dddml.support.criterion.*;
import org.dddml.wms.domain.attributeset.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.attributeusemvo.*;
import org.dddml.wms.domain.meta.*;

import com.alibaba.fastjson.*;
import org.apache.cxf.jaxrs.ext.PATCH;
import org.springframework.beans.factory.annotation.Autowired;
import org.dddml.support.criterion.TypeConverter;

@Path("AttributeUseMvos")
@Produces(MediaType.APPLICATION_JSON)
public class AttributeUseMvoResource {


    @Autowired
    private AttributeUseMvoApplicationService attributeUseMvoApplicationService;


    @GET
    public AttributeUseMvoStateDto[] getAll(@Context HttpServletRequest request,
                                   @QueryParam("sort") String sort,
                                   @QueryParam("fields") String fields,
                                   @QueryParam("firstResult") @DefaultValue("0") Integer firstResult,
                                   @QueryParam("maxResults") @DefaultValue("2147483647") Integer maxResults,
                                   @QueryParam("filter") String filter) {
        if (firstResult < 0) { firstResult = 0; }
        if (maxResults == null || maxResults < 1) { maxResults = Integer.MAX_VALUE; }
        try {

            Iterable<AttributeUseMvoState> states = null; 
            if (!StringHelper.isNullOrEmpty(filter)) {
                states = attributeUseMvoApplicationService.get(
                        CriterionDto.toSubclass(
                                JSON.parseObject(filter, CriterionDto.class),
                                getCriterionTypeConverter(), getPropertyTypeResolver()),
                        AttributeUseMvoResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            } else {
                states = attributeUseMvoApplicationService.get(
                        AttributeUseMvoResourceUtils.getQueryFilterMap(request.getParameterMap()),
                        AttributeUseMvoResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            }

            AttributeUseMvoStateDto.DtoConverter dtoConverter = new AttributeUseMvoStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toAttributeUseMvoStateDtoArray(states);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GET
    @Path("{id}")
    public AttributeUseMvoStateDto get(@PathParam("id") String id, @QueryParam("fields") String fields) {
        try {
            AttributeSetAttributeUseId idObj = AttributeUseMvoResourceUtils.parseIdString(id);
            AttributeUseMvoState state = attributeUseMvoApplicationService.get(idObj);
            if (state == null) { return null; }

            AttributeUseMvoStateDto.DtoConverter dtoConverter = new AttributeUseMvoStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toAttributeUseMvoStateDto(state);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @Path("_count")
    @GET
    public long getCount(@Context HttpServletRequest request,
                         @QueryParam("filter") String filter) {
        try {
            long count = 0;
            if (!StringHelper.isNullOrEmpty(filter)) {
                count = attributeUseMvoApplicationService.getCount(CriterionDto.toSubclass(JSONObject.parseObject(filter, CriterionDto.class),
                        getCriterionTypeConverter(), getPropertyTypeResolver()));
            } else {
                count = attributeUseMvoApplicationService.getCount(AttributeUseMvoResourceUtils.getQueryFilterMap(request.getParameterMap()));
            }
            return count;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PUT
    @Path("/{id}")
    public void put(@PathParam("id") String id, CreateOrMergePatchAttributeUseMvoDto.CreateAttributeUseMvoDto value) {
        try {

            AttributeUseMvoCommand.CreateAttributeUseMvo cmd = value.toCreateAttributeUseMvo();
            AttributeUseMvoResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            attributeUseMvoApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PATCH
    @Path("/{id}")
    public void patch(@PathParam("id") String id, CreateOrMergePatchAttributeUseMvoDto.MergePatchAttributeUseMvoDto value) {
        try {

            AttributeUseMvoCommand.MergePatchAttributeUseMvo cmd = value.toMergePatchAttributeUseMvo();
            AttributeUseMvoResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            attributeUseMvoApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @DELETE
    @Path("/{id}")
    public void delete(@PathParam("id") String id,
                       @NotNull @QueryParam("commandId") String commandId,
                       @NotNull @QueryParam("version") @Min(value = -1) Long version,
                       @QueryParam("requesterId") String requesterId) {
        try {

            AttributeUseMvoCommand.DeleteAttributeUseMvo deleteCmd = new AbstractAttributeUseMvoCommand.SimpleDeleteAttributeUseMvo();

            deleteCmd.setCommandId(commandId);
            deleteCmd.setRequesterId(requesterId);
            deleteCmd.setAttributeSetVersion(version);
            AttributeUseMvoResourceUtils.setNullIdOrThrowOnInconsistentIds(id, deleteCmd);
            attributeUseMvoApplicationService.when(deleteCmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @Path("_metadata/filteringFields")
    @GET
    public List<PropertyMetadataDto> getMetadataFilteringFields() {
        try {

            List<PropertyMetadataDto> filtering = new ArrayList<>();
            AttributeUseMvoFilteringProperties.propertyTypeMap.forEach((key, value) -> {
                filtering.add(new PropertyMetadataDto(key, value, true));
            });
            return filtering;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @Path("{id}/_stateEvents/{version}")
    @GET
    public AttributeUseMvoStateEventDto getStateEvent(@PathParam("id") String id, @PathParam("version") long version) {
        try {

            AttributeSetAttributeUseId idObj = AttributeUseMvoResourceUtils.parseIdString(id);
            AttributeUseMvoStateEventDtoConverter dtoConverter = getAttributeUseMvoStateEventDtoConverter();
            return dtoConverter.toAttributeUseMvoStateEventDto((AbstractAttributeUseMvoStateEvent) attributeUseMvoApplicationService.getStateEvent(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @Path("{id}/_historyStates/{version}")
    @GET
    public AttributeUseMvoStateDto getHistoryState(@PathParam("id") String id, @PathParam("version") long version, @QueryParam("fields") String fields) {
        try {

            AttributeSetAttributeUseId idObj = AttributeUseMvoResourceUtils.parseIdString(id);
            AttributeUseMvoStateDto.DtoConverter dtoConverter = new AttributeUseMvoStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toAttributeUseMvoStateDto(attributeUseMvoApplicationService.getHistoryState(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    protected  AttributeUseMvoStateEventDtoConverter getAttributeUseMvoStateEventDtoConverter() {
        return new AttributeUseMvoStateEventDtoConverter();
    }

    protected String getQueryOrderSeparator() {
        return ",";
    }

    protected TypeConverter getCriterionTypeConverter() {
        return new DefaultTypeConverter();
    }

    protected PropertyTypeResolver getPropertyTypeResolver() {
        return new AttributeUseMvoPropertyTypeResolver();
    }

    // ////////////////////////////////

    private class AttributeUseMvoPropertyTypeResolver implements PropertyTypeResolver {
        @Override
        public Class resolveTypeByPropertyName(String propertyName) {
            return AttributeUseMvoResourceUtils.getFilterPropertyType(propertyName);
        }
    }

 
    public static class AttributeUseMvoResourceUtils {

        public static List<String> getQueryOrders(String str, String separator) {
            List<String> orders = new ArrayList<>();
            if (StringHelper.isNullOrEmpty(str)) {
                return orders;
            }
            String[] splits = str.split(separator);
            for (String item : splits) {
                if (!StringHelper.isNullOrEmpty(item)) {
                    orders.add(item);
                }
            }
            return orders;
        }

        public static void setNullIdOrThrowOnInconsistentIds(String id, AttributeUseMvoCommand value) {
            AttributeSetAttributeUseId idObj = parseIdString(id);
            if (value.getAttributeSetAttributeUseId() == null) {
                value.setAttributeSetAttributeUseId(idObj);
            } else if (!value.getAttributeSetAttributeUseId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, value.getAttributeSetAttributeUseId());
            }
        }
    

        public static AttributeSetAttributeUseId parseIdString(String idString) {
            AttributeSetAttributeUseIdFlattenedDtoFormatter formatter = new AttributeSetAttributeUseIdFlattenedDtoFormatter();
            AttributeSetAttributeUseIdFlattenedDto idDto = formatter.parse(idString);
            return idDto.toAttributeSetAttributeUseId();
        }


        public static String getFilterPropertyName(String fieldName) {
            if ("sort".equalsIgnoreCase(fieldName)
                    || "firstResult".equalsIgnoreCase(fieldName)
                    || "maxResults".equalsIgnoreCase(fieldName)
                    || "fields".equalsIgnoreCase(fieldName)) {
                return null;
            }
            if (AttributeUseMvoFilteringProperties.propertyTypeMap.containsKey(fieldName)) {
                return fieldName;
            }
            return null;
        }

        public static Class getFilterPropertyType(String propertyName) {
            if (AttributeUseMvoFilteringProperties.propertyTypeMap.containsKey(propertyName)) {
                String propertyType = AttributeUseMvoFilteringProperties.propertyTypeMap.get(propertyName);
                if (!StringHelper.isNullOrEmpty(propertyType)) {
                    if (ReflectUtils.CLASS_MAP.containsKey(propertyType)) {
                        return ReflectUtils.CLASS_MAP.get(propertyType);
                    }
                }
            }
            return String.class;
        }

        public static Iterable<Map.Entry<String, Object>> getQueryFilterMap(Map<String, String[]> queryNameValuePairs) {
            Map<String, Object> filter = new HashMap<>();
            queryNameValuePairs.forEach((key, values) -> {
                if (values.length > 0) {
                    String pName = getFilterPropertyName(key);
                    if (!StringHelper.isNullOrEmpty(pName)) {
                        Class pClass = getFilterPropertyType(pName);
                        filter.put(pName, ApplicationContext.current.getTypeConverter().convertFromString(pClass, values[0]));
                    }
                }
            });
            return filter.entrySet();
        }

        public static AttributeUseMvoStateDto[] toAttributeUseMvoStateDtoArray(Iterable<AttributeSetAttributeUseId> ids) {
            List<AttributeUseMvoStateDto> states = new ArrayList<>();
            ids.forEach(id -> {
                AttributeUseMvoStateDto dto = new AttributeUseMvoStateDto();
                dto.setAttributeSetAttributeUseId(new AttributeSetAttributeUseIdDtoWrapper(id));
                states.add(dto);
            });
            return states.toArray(new AttributeUseMvoStateDto[0]);
        }

    }

}


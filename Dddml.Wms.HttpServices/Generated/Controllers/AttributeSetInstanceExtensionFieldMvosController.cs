﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldMvo;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;
using Dddml.Wms.Domain.Metadata;
using Dddml.Wms.HttpServices.Filters;
using System.Linq;
using System.Net;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;

namespace Dddml.Wms.HttpServices.ApiControllers
{

    [RoutePrefix("api/AttributeSetInstanceExtensionFieldMvos")][Authorize]
    public partial class AttributeSetInstanceExtensionFieldMvosController : ApiController
    {

        IAttributeSetInstanceExtensionFieldMvoApplicationService _attributeSetInstanceExtensionFieldMvoApplicationService = ApplicationContext.Current["AttributeSetInstanceExtensionFieldMvoApplicationService"] as IAttributeSetInstanceExtensionFieldMvoApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IAttributeSetInstanceExtensionFieldMvoStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _attributeSetInstanceExtensionFieldMvoApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver())
                    , AttributeSetInstanceExtensionFieldMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _attributeSetInstanceExtensionFieldMvoApplicationService.Get(AttributeSetInstanceExtensionFieldMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , AttributeSetInstanceExtensionFieldMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IAttributeSetInstanceExtensionFieldMvoStateDto>();
            foreach (var s in states)
            {
                var dto = s is AttributeSetInstanceExtensionFieldMvoStateDtoWrapper ? (AttributeSetInstanceExtensionFieldMvoStateDtoWrapper)s : new AttributeSetInstanceExtensionFieldMvoStateDtoWrapper(s);
                if (String.IsNullOrWhiteSpace(fields))
                {
                    dto.AllFieldsReturned = true;
                }
                else
                {
                    dto.ReturnedFieldsString = fields;
                }
                stateDtos.Add(dto);
            }
            return stateDtos;
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IAttributeSetInstanceExtensionFieldMvoStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = AttributeSetInstanceExtensionFieldMvosControllerUtils.ParseIdString(id);
            var state = _attributeSetInstanceExtensionFieldMvoApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new AttributeSetInstanceExtensionFieldMvoStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }


        [Route("_count")]
        [HttpGet]
        public long GetCount(string filter = null)
        {
          try
          {
            long count = 0;
            if (!String.IsNullOrWhiteSpace(filter))
            {
                count = _attributeSetInstanceExtensionFieldMvoApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver()));
            }
            else 
            {
                count = _attributeSetInstanceExtensionFieldMvoApplicationService.GetCount(AttributeSetInstanceExtensionFieldMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateAttributeSetInstanceExtensionFieldMvoDto value)
        {
          try {
            AttributeSetInstanceExtensionFieldMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeSetInstanceExtensionFieldMvoApplicationService.When(value as ICreateAttributeSetInstanceExtensionFieldMvo);
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchAttributeSetInstanceExtensionFieldMvoDto value)
        {
          try {
            AttributeSetInstanceExtensionFieldMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeSetInstanceExtensionFieldMvoApplicationService.When(value as IMergePatchAttributeSetInstanceExtensionFieldMvo);
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeleteAttributeSetInstanceExtensionFieldMvoDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.AttrSetInstEFGroupVersion = (long)Convert.ChangeType(version, typeof(long));
            AttributeSetInstanceExtensionFieldMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeSetInstanceExtensionFieldMvoApplicationService.When(value as IDeleteAttributeSetInstanceExtensionFieldMvo);
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in AttributeSetInstanceExtensionFieldMvoMetadata.Instance.Properties)
            {
                if (p.IsFilteringProperty)
                {
                    var pdto = new PropertyMetadataDto(p.Name, p.TypeName, p.IsFilteringProperty,
                       !String.IsNullOrWhiteSpace(p.SourceChainingName) ? p.SourceChainingName :
                       (!String.IsNullOrWhiteSpace(p.DerivedFrom) ? p.DerivedFrom : p.Name));
                    filtering.Add(pdto);
                }
            }
            return filtering;
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public AttributeSetInstanceExtensionFieldMvoStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = AttributeSetInstanceExtensionFieldMvosControllerUtils.ParseIdString(id);
            var conv = new AttributeSetInstanceExtensionFieldMvoStateEventDtoConverter();
            var se = _attributeSetInstanceExtensionFieldMvoApplicationService.GetStateEvent(idObj, version);
            return se == null ? null : conv.ToAttributeSetInstanceExtensionFieldMvoStateEventDto(se);
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IAttributeSetInstanceExtensionFieldMvoStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = AttributeSetInstanceExtensionFieldMvosControllerUtils.ParseIdString(id);
            var state = _attributeSetInstanceExtensionFieldMvoApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new AttributeSetInstanceExtensionFieldMvoStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = AttributeSetInstanceExtensionFieldMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }


		// /////////////////////////////////////////////////

        protected virtual string QueryOrderSeparator
        {
            get { return ","; }
        }

        // ////////////////////////////////

        private class ApiControllerTypeConverter : Dddml.Support.Criterion.ITypeConverter
        {
            public T ConvertFromString<T>(string text)
            {
                return (T)ApplicationContext.Current.TypeConverter.ConvertFromString(typeof(T), text);
            }

            public object ConvertFromString(Type type, string text)
            {
                return ApplicationContext.Current.TypeConverter.ConvertFromString(type, text);
            }

            public string ConvertToString<T>(T value)
            {
                return ApplicationContext.Current.TypeConverter.ConvertToString(typeof(T), value);
            }

            public string ConvertToString(object value)
            {
                return ApplicationContext.Current.TypeConverter.ConvertToString(value.GetType(), value);
            }

            public string[] ConvertToStringArray(object[] values)
            {
                throw new NotSupportedException();
            }
        }

        private class PropertyTypeResolver : IPropertyTypeResolver
        {

            public Type ResolveTypeByPropertyName(string propertyName)
            {
                return AttributeSetInstanceExtensionFieldMvosControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class AttributeSetInstanceExtensionFieldMvosControllerUtils
    {

        public static HttpResponseMessage GetErrorHttpResponseMessage(Exception ex)
        {
            var errorName = ex.GetType().Name;
            var errorMessage = ex.Message;
            if (ex is DomainError)
            {
                DomainError de = ex as DomainError;
                errorName = de.Name;
                errorMessage = de.Message;
            }
            else
            {
                //改进??
                errorMessage = String.IsNullOrWhiteSpace(ex.Message) ? String.Empty : ex.Message.Substring(0, (ex.Message.Length > 140) ? 140 : ex.Message.Length);
            }
            dynamic content = new JObject();
            content.ErrorName = errorName;
            content.ErrorMessage = errorMessage;
            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new ObjectContent<JObject>(content as JObject, new JsonMediaTypeFormatter()),
                ReasonPhrase = "Server Error"
            };
            return response;
        }

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldMvoDto value)
        {
            var idObj = ParseIdString(id.IsNormalized() ? id : id.Normalize());
            if (value.AttributeSetInstanceExtensionFieldId == null)
            {
                value.AttributeSetInstanceExtensionFieldId = new AttributeSetInstanceExtensionFieldIdDtoWrapper(idObj);
            }
            else if (!((ICreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldMvo)value).AttributeSetInstanceExtensionFieldId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.AttributeSetInstanceExtensionFieldId);
            }
        }

        public static AttributeSetInstanceExtensionFieldId ParseIdString(string idString)
        {
            var formatter = new AttributeSetInstanceExtensionFieldIdFlattenedDtoFormatter();
            var idDto = formatter.Parse(idString);
            var rId = idDto.ToAttributeSetInstanceExtensionFieldId();
            return rId;
        }

        public static string GetFilterPropertyName(string fieldName)
        {
            if (String.Equals(fieldName, "sort", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "firstResult", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "maxResults", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "fields", StringComparison.InvariantCultureIgnoreCase))
            {
                return null;
            }
            if (AttributeSetInstanceExtensionFieldMvoMetadata.Instance.PropertyMetadataDictionary.ContainsKey(fieldName))
            {
                var p = AttributeSetInstanceExtensionFieldMvoMetadata.Instance.PropertyMetadataDictionary[fieldName];
                if (p.IsFilteringProperty)
                {
                    var propertyName = fieldName;
                    if (p.IsDerived)
                    {
                        propertyName = p.DerivedFrom;
                    }
                    return propertyName;
                }
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (AttributeSetInstanceExtensionFieldMvoMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return AttributeSetInstanceExtensionFieldMvoMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
            }
            return typeof(string);
        }

        public static IDictionary<string, object> GetQueryFilterDictionary(IEnumerable<KeyValuePair<string, string>> queryNameValuePairs)
        {
            var filter = new Dictionary<string, object>();
            foreach (var p in queryNameValuePairs)
            {
                var pName = GetFilterPropertyName(p.Key);
                if (!String.IsNullOrWhiteSpace(pName))
                {
                    Type type = GetFilterPropertyType(pName);
                    var pValue = ApplicationContext.Current.TypeConverter.ConvertFromString(type, p.Value);
                    filter.Add(pName, pValue);
                }
            }
            return filter;
        }

        public static IList<string> GetQueryOrders(string str, string separator)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                return new string[0];
            }
            var arr = str.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
            var orders = new List<string>();
            foreach (var a in arr)
            {
                orders.Add(a.Trim());
            }
            return orders;
        }

        public static IEnumerable<IAttributeSetInstanceExtensionFieldMvoStateDto> ToAttributeSetInstanceExtensionFieldMvoStateDtoCollection(IEnumerable<AttributeSetInstanceExtensionFieldId> ids)
        {
            var states = new List<IAttributeSetInstanceExtensionFieldMvoStateDto>();
            foreach (var id in ids)
            {
                var dto = new AttributeSetInstanceExtensionFieldMvoStateDtoWrapper();
                dto.AttributeSetInstanceExtensionFieldId = new AttributeSetInstanceExtensionFieldIdDtoWrapper(id);
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IAttributeSetInstanceExtensionFieldMvoState> ToAttributeSetInstanceExtensionFieldMvoStateCollection(IEnumerable<AttributeSetInstanceExtensionFieldId> ids)
        {
            var states = new List<AttributeSetInstanceExtensionFieldMvoState>();
            foreach (var id in ids)
            {
                var s = new AttributeSetInstanceExtensionFieldMvoState();
                s.AttributeSetInstanceExtensionFieldId = id;
                states.Add(s);
            }
            return states;
        }

    }

}


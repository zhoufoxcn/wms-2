﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ComponentModel;
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;
using Dddml.Wms.Domain.Metadata;


namespace Dddml.Wms.HttpServices.ApiControllers
{

    public partial class AttributeSetsController : ApiController
    {


        IAttributeSetApplicationService _attributeSetApplicationService = ApplicationContext.Current["AttributeSetApplicationService"] as IAttributeSetApplicationService;

        [HttpGet]
        public IEnumerable<AttributeSetStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var states = _attributeSetApplicationService.Get(GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                , GetQueryOrders(sort), firstResult, maxResults);
            var stateDtos = new List<AttributeSetStateDto>();
            foreach (var s in states)
            {
                var dto = new AttributeSetStateDto((AttributeSetState)s);
                if (!String.IsNullOrWhiteSpace(fields))
                {
                    dto.ReturnedFieldsString = fields;
                }
                stateDtos.Add(dto);
            }
            return stateDtos;
        }

        [HttpGet]
        public AttributeSetStateDto Get(string id, string fields = null)
        {
            var idObj = id;
            var state = (AttributeSetState)_attributeSetApplicationService.Get(idObj);
            var stateDto = new AttributeSetStateDto(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
        }

        [HttpPut]
        public void Put(string id, [FromBody]CreateAttributeSetDto value)
        {
            SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeSetApplicationService.When(value.ToCommand() as ICreateAttributeSet);
        }

        [HttpPatch]
        public void Patch(string id, [FromBody]MergePatchAttributeSetDto value)
        {
            SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeSetApplicationService.When(value.ToCommand() as IMergePatchAttributeSet);
        }

        [HttpDelete]
        public void Delete(string id, string commandId, string requesterId = default(string))
        {
            var value = new DeleteAttributeSetDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeSetApplicationService.When(value.ToCommand() as IDeleteAttributeSet);
        }

		// /////////////////////////////////////////////////

        protected static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteAttributeSetDto value)
        {
            var idObj = id;
            if (value.AttributeSetId == null)
            {
                value.AttributeSetId = idObj;
            }
            else if (!(value as IAttributeSetStateProperties).AttributeSetId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.AttributeSetId);
            }
        }


        protected virtual string GetFilterPropertyName(string fieldName)
        {
            if (String.Equals(fieldName, "sort", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "firstResult", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "maxResults", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "fields", StringComparison.InvariantCultureIgnoreCase))
            {
                return null;
            }
            if (AttributeSetMetadata.Instance.PropertyMetadataDictionary.ContainsKey(fieldName))
            {
                var p = AttributeSetMetadata.Instance.PropertyMetadataDictionary[fieldName];
                if (!p.IsCollectionProperty && !p.IsTransient && p.IsBasicType)
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

        protected virtual Type GetFilterPropertyType(string propertyName)
        {
            if (AttributeSetMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return AttributeSetMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
            }
            return typeof(string);
        }

        private IDictionary<string, object> GetQueryFilterDictionary(IEnumerable<KeyValuePair<string, string>> queryNameValuePairs)
        {
            var filter = new Dictionary<string, object>();
            foreach (var p in queryNameValuePairs)
            {
                var pName = GetFilterPropertyName(p.Key);
                if (!String.IsNullOrWhiteSpace(pName))
                {
                    Type type = GetFilterPropertyType(pName);
                    var converter = TypeDescriptor.GetConverter(type);
                    var pValue = converter.ConvertFromString(p.Value);
                    filter.Add(pName, pValue);
                }
            }
            return filter;
        }

        private IList<string> GetQueryOrders(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                return new string[0];
            }
            var arr = str.Split(new string[] { QueryOrderSeparator }, StringSplitOptions.RemoveEmptyEntries);
            var orders = new List<string>();
            foreach (var a in arr)
            {
                orders.Add(a.Trim());
            }
            return orders;
        }

        protected virtual string QueryOrderSeparator
        {
            get { return ","; }
        }


    }




}


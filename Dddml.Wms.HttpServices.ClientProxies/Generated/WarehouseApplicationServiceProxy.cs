﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;
using System.Text;
using System.ComponentModel;
using RAML.Api.Core;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;
using Dddml.Wms.Specialization.HttpServices.ClientProxies;


namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class WarehouseApplicationServiceProxy : IWarehouseApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public WarehouseApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public WarehouseApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public WarehouseApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateWarehouseDto c)
        {
            var idObj = (c as ICreateWarehouse).WarehouseId;
            var uriParameters = new WarehouseUriParameters();
            uriParameters.Id = idObj;

            var req = new WarehousePutRequest(uriParameters, (CreateWarehouseDto)c);
                
            var resp = await _ramlClient.Warehouse.Put(req);
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateWarehouseDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchWarehouseDto c)
        {
            var idObj = (c as IMergePatchWarehouse).WarehouseId;
            var uriParameters = new WarehouseUriParameters();
            uriParameters.Id = idObj;

            var req = new WarehousePatchRequest(uriParameters, (MergePatchWarehouseDto)c);
            var resp = await _ramlClient.Warehouse.Patch(req);
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchWarehouseDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteWarehouseDto c)
        {
            var idObj = (c as IDeleteWarehouse).WarehouseId;
            var uriParameters = new WarehouseUriParameters();
            uriParameters.Id = idObj;

            var q = new WarehouseDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new WarehouseDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.Warehouse.Delete(req);
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteWarehouseDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IWarehouseApplicationService.When(ICreateWarehouse c)
        {
            this.When((CreateWarehouseDto)c);
        }

        void IWarehouseApplicationService.When(IMergePatchWarehouse c)
        {
            this.When((MergePatchWarehouseDto)c);
        }

        void IWarehouseApplicationService.When(IDeleteWarehouse c)
        {
            this.When((DeleteWarehouseDto)c);
        }

        public async Task<IWarehouseState> GetAsync(string warehouseId)
        {
            IWarehouseState state = null;
            var idObj = warehouseId;
            var uriParameters = new WarehouseUriParameters();
            uriParameters.Id = idObj;

            var req = new WarehouseGetRequest(uriParameters);

            var resp = await _ramlClient.Warehouse.Get(req);
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IWarehouseState Get(string warehouseId)
        {
            return GetAsync(warehouseId).GetAwaiter().GetResult();
        }


        public IEnumerable<IWarehouseState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IWarehouseState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IWarehouseState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IWarehouseState> states = null;
			var q = new WarehousesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = WarehouseProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = WarehouseProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = WarehouseProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new WarehousesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Warehouses.Get(req);
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IWarehouseState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IWarehouseState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IWarehouseState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IWarehouseState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IWarehouseState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IWarehouseState> states = null;
			var q = new WarehousesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = WarehouseProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = WarehouseProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = WarehouseProxyUtils.GetFilterQueryValueString(filter);
            var req = new WarehousesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Warehouses.Get(req);
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IWarehouseState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new WarehousesCountGetQuery();
            q.FilterTag = WarehouseProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new WarehousesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.WarehousesCount.Get(req);
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new WarehousesCountGetQuery();
            q.Filter = WarehouseProxyUtils.GetFilterQueryValueString(filter);
            var req = new WarehousesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.WarehousesCount.Get(req);
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IWarehouseStateEvent> GetStateEventAsync(string warehouseId, long version)
        {
            var idObj = warehouseId;
            var uriParameters = new WarehouseStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new WarehouseStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.WarehouseStateEvent.Get(req);
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IWarehouseStateEvent GetStateEvent(string warehouseId, long version)
        {
            return GetStateEventAsync(warehouseId, version).GetAwaiter().GetResult();
        }


        public async Task<IWarehouseState> GetHistoryStateAsync(string warehouseId, long version)
        {
            var idObj = warehouseId;
            var uriParameters = new WarehouseHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new WarehouseHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.WarehouseHistoryState.Get(req);
            WarehouseProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public virtual IWarehouseState GetHistoryState(string warehouseId, long version)
        {
            return GetHistoryStateAsync(warehouseId, version).GetAwaiter().GetResult();
        }


        protected virtual string QueryFieldValueSeparator
        {
            get { return ","; }
        }

        protected virtual string QueryOrderSeparator
        {
            get { return ","; }
        }

    }


    public partial class WarehouseApplicationServiceProxyFactory : ProxyFactoryBase, IWarehouseApplicationServiceFactory
    {

        public WarehouseApplicationServiceProxyFactory() : base()
        {}

        public WarehouseApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IWarehouseApplicationService WarehouseApplicationService
        {
            get
            {
                return new WarehouseApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateWarehouse NewCreateWarehouse()
        {
            return new CreateWarehouseDto();
        }

        public IMergePatchWarehouse NewMergePatchWarehouse()
        {
            return new MergePatchWarehouseDto();
        }

        public IDeleteWarehouse NewDeleteWarehouse()
        {
            return new DeleteWarehouseDto();
        }
    }

    public static class WarehouseProxyUtils
    {

        private class ProxyTypeConverter : Dddml.Support.Criterion.ITypeConverter
        {
            public T ConvertFromString<T>(string text)
            {
                throw new NotSupportedException();
            }

            public object ConvertFromString(Type type, string text)
            {
                throw new NotSupportedException();
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
                var list = new List<string>();
                foreach (var o in values)
                {
                    list.Add(ConvertToString(o));
                }
                return list.ToArray();
            }
        }


        public static string GetFilterQueryValueString(ICriterion filter)
        {
            if (filter == null) { return null; }
            return WebUtility.UrlEncode(JObject.FromObject(new CriterionDto(filter, new ProxyTypeConverter())).ToString());
        }

        public static string GetFilterTagQueryValueString(IEnumerable<KeyValuePair<string, object>> filter)
        {
            if (filter == null) { return null; }
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.Ticks);
            foreach (var p in filter)
            {
                var k = p.Key;
                var v = p.Value;
                sb.Append("&");
                sb.Append(k);
                sb.Append("=");
                if (v != null)
                {
                    string valStr = ApplicationContext.Current.TypeConverter.ConvertToString(v.GetType(), v);
                    sb.Append(WebUtility.UrlEncode(valStr));
                }

            }
            return sb.ToString();
        }

        public static string GetReturnedFieldsQueryValueString(IList<string> fields, string separator)
        {
            if (fields == null) { return null; }
            StringBuilder sb = new StringBuilder();
            foreach (var f in fields)
            {
                sb.Append(WebUtility.UrlEncode(f));
                sb.Append(separator);
            }
            return sb.ToString();
        }

        public static string GetOrdersQueryValueString(IList<string> orders)
        {
            if (orders == null) { return null; }
            StringBuilder sb = new StringBuilder();
            foreach (var ord in orders)
            {
                sb.Append(WebUtility.UrlEncode(ord));
                sb.Append(",");
            }
            return sb.ToString();
        }

        public static void ThrowOnHttpResponseError(ApiResponse resp)
        {
            var httpResponseMessage = new HttpResponseMessage()
            {
                StatusCode = resp.StatusCode,
                Content = resp.RawContent,
                ReasonPhrase = resp.ReasonPhrase
            };
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return;
            }
            try
            {
                if (resp.StatusCode == HttpStatusCode.InternalServerError)
                {
                    IEnumerable<string> headerValues = new List<string>();
                    if (resp.RawContent != null && resp.RawContent.Headers != null)
                        resp.RawContent.Headers.TryGetValues("Content-Type", out headerValues);
                    if (headerValues.Any(hv => hv.ToLowerInvariant().Contains("json")))
                    {
                        JObject jObj = JObject.Parse(httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                        var errorName = jObj.GetValue("ErrorName").ToObject<string>();
                        var errorMessage = jObj.GetValue("ErrorMessage").ToObject<string>();
                        throw DomainError.Named(errorName, errorMessage);
                    }
                }
                throw new HttpResponseException(httpResponseMessage);
            }
            catch
            {
                throw new HttpResponseException(httpResponseMessage);
            }
        }

        public static IEnumerable<string> ToIdCollection(IEnumerable<IWarehouseState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.WarehouseId);
            }
            return ids;
        }

    }

}


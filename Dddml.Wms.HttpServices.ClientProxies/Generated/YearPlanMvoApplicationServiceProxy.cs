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

    public partial class YearPlanMvoApplicationServiceProxy : IYearPlanMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public YearPlanMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public YearPlanMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public YearPlanMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateYearPlanMvoDto c)
        {
            var idObj = YearPlanMvoProxyUtils.ToIdString((c as ICreateYearPlanMvo).YearPlanId);
            var uriParameters = new YearPlanMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new YearPlanMvoPutRequest(uriParameters, (CreateYearPlanMvoDto)c);
                
            var resp = await _ramlClient.YearPlanMvo.Put(req);
            YearPlanMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateYearPlanMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchYearPlanMvoDto c)
        {
            var idObj = YearPlanMvoProxyUtils.ToIdString((c as IMergePatchYearPlanMvo).YearPlanId);
            var uriParameters = new YearPlanMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new YearPlanMvoPatchRequest(uriParameters, (MergePatchYearPlanMvoDto)c);
            var resp = await _ramlClient.YearPlanMvo.Patch(req);
            YearPlanMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchYearPlanMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteYearPlanMvoDto c)
        {
            var idObj = YearPlanMvoProxyUtils.ToIdString((c as IDeleteYearPlanMvo).YearPlanId);
            var uriParameters = new YearPlanMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new YearPlanMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new YearPlanMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.YearPlanMvo.Delete(req);
            YearPlanMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteYearPlanMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IYearPlanMvoApplicationService.When(ICreateYearPlanMvo c)
        {
            this.When((CreateYearPlanMvoDto)c);
        }

        void IYearPlanMvoApplicationService.When(IMergePatchYearPlanMvo c)
        {
            this.When((MergePatchYearPlanMvoDto)c);
        }

        void IYearPlanMvoApplicationService.When(IDeleteYearPlanMvo c)
        {
            this.When((DeleteYearPlanMvoDto)c);
        }

        public async Task<IYearPlanMvoState> GetAsync(YearPlanId yearPlanId)
        {
            IYearPlanMvoState state = null;
            var idObj = YearPlanMvoProxyUtils.ToIdString(yearPlanId);
            var uriParameters = new YearPlanMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new YearPlanMvoGetRequest(uriParameters);

            var resp = await _ramlClient.YearPlanMvo.Get(req);
            YearPlanMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IYearPlanMvoState Get(YearPlanId yearPlanId)
        {
            return GetAsync(yearPlanId).GetAwaiter().GetResult();
        }


        public IEnumerable<IYearPlanMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IYearPlanMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IYearPlanMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IYearPlanMvoState> states = null;
			var q = new YearPlanMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = YearPlanMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = YearPlanMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = YearPlanMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new YearPlanMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.YearPlanMvos.Get(req);
            YearPlanMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IYearPlanMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IYearPlanMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IYearPlanMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IYearPlanMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IYearPlanMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IYearPlanMvoState> states = null;
			var q = new YearPlanMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = YearPlanMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = YearPlanMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = YearPlanMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new YearPlanMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.YearPlanMvos.Get(req);
            YearPlanMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IYearPlanMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new YearPlanMvosCountGetQuery();
            q.FilterTag = YearPlanMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new YearPlanMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.YearPlanMvosCount.Get(req);
            YearPlanMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new YearPlanMvosCountGetQuery();
            q.Filter = YearPlanMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new YearPlanMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.YearPlanMvosCount.Get(req);
            YearPlanMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IYearPlanMvoStateEvent> GetStateEventAsync(YearPlanId yearPlanId, long version)
        {
            var idObj = YearPlanMvoProxyUtils.ToIdString(yearPlanId);
            var uriParameters = new YearPlanMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new YearPlanMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.YearPlanMvoStateEvent.Get(req);
            YearPlanMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IYearPlanMvoStateEvent GetStateEvent(YearPlanId yearPlanId, long version)
        {
            return GetStateEventAsync(yearPlanId, version).GetAwaiter().GetResult();
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


    public partial class YearPlanMvoApplicationServiceProxyFactory : ProxyFactoryBase, IYearPlanMvoApplicationServiceFactory
    {

        public YearPlanMvoApplicationServiceProxyFactory() : base()
        {}

        public YearPlanMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IYearPlanMvoApplicationService YearPlanMvoApplicationService
        {
            get
            {
                return new YearPlanMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateYearPlanMvo NewCreateYearPlanMvo()
        {
            return new CreateYearPlanMvoDto();
        }

        public IMergePatchYearPlanMvo NewMergePatchYearPlanMvo()
        {
            return new MergePatchYearPlanMvoDto();
        }

        public IDeleteYearPlanMvo NewDeleteYearPlanMvo()
        {
            return new DeleteYearPlanMvoDto();
        }
    }

    public static class YearPlanMvoProxyUtils
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

        public static string ToIdString(YearPlanId id)
        {
            var formatter = new YearPlanIdFlattenedDtoFormatter();
            var idDto = new YearPlanIdFlattenedDto(id);
            var idStr = formatter.ToString(idDto);
            return idStr;
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

        public static IEnumerable<YearPlanId> ToIdCollection(IEnumerable<IYearPlanMvoState> states)
        {
            var ids = new List<YearPlanId>();
            foreach (var s in states)
            {
                ids.Add(s.YearPlanId);
            }
            return ids;
        }

    }

}


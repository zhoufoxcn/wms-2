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

    public partial class UserClaimMvoApplicationServiceProxy : IUserClaimMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public UserClaimMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public UserClaimMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public UserClaimMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateUserClaimMvoDto c)
        {
            var idObj = UserClaimMvoProxyUtils.ToIdString((c as ICreateUserClaimMvo).UserClaimId);
            var uriParameters = new UserClaimMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new UserClaimMvoPutRequest(uriParameters, (CreateUserClaimMvoDto)c);
                
            var resp = await _ramlClient.UserClaimMvo.Put(req);
            UserClaimMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateUserClaimMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchUserClaimMvoDto c)
        {
            var idObj = UserClaimMvoProxyUtils.ToIdString((c as IMergePatchUserClaimMvo).UserClaimId);
            var uriParameters = new UserClaimMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new UserClaimMvoPatchRequest(uriParameters, (MergePatchUserClaimMvoDto)c);
            var resp = await _ramlClient.UserClaimMvo.Patch(req);
            UserClaimMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchUserClaimMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteUserClaimMvoDto c)
        {
            var idObj = UserClaimMvoProxyUtils.ToIdString((c as IDeleteUserClaimMvo).UserClaimId);
            var uriParameters = new UserClaimMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new UserClaimMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new UserClaimMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.UserClaimMvo.Delete(req);
            UserClaimMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteUserClaimMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IUserClaimMvoApplicationService.When(ICreateUserClaimMvo c)
        {
            this.When((CreateUserClaimMvoDto)c);
        }

        void IUserClaimMvoApplicationService.When(IMergePatchUserClaimMvo c)
        {
            this.When((MergePatchUserClaimMvoDto)c);
        }

        void IUserClaimMvoApplicationService.When(IDeleteUserClaimMvo c)
        {
            this.When((DeleteUserClaimMvoDto)c);
        }

        public async Task<IUserClaimMvoState> GetAsync(UserClaimId userClaimId)
        {
            IUserClaimMvoState state = null;
            var idObj = UserClaimMvoProxyUtils.ToIdString(userClaimId);
            var uriParameters = new UserClaimMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new UserClaimMvoGetRequest(uriParameters);

            var resp = await _ramlClient.UserClaimMvo.Get(req);
            UserClaimMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IUserClaimMvoState Get(UserClaimId userClaimId)
        {
            return GetAsync(userClaimId).GetAwaiter().GetResult();
        }


        public IEnumerable<IUserClaimMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IUserClaimMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IUserClaimMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IUserClaimMvoState> states = null;
			var q = new UserClaimMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = UserClaimMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = UserClaimMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = UserClaimMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new UserClaimMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UserClaimMvos.Get(req);
            UserClaimMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IUserClaimMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IUserClaimMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IUserClaimMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IUserClaimMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IUserClaimMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IUserClaimMvoState> states = null;
			var q = new UserClaimMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = UserClaimMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = UserClaimMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = UserClaimMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new UserClaimMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UserClaimMvos.Get(req);
            UserClaimMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public IEnumerable<IUserClaimMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new UserClaimMvosCountGetQuery();
            q.FilterTag = UserClaimMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new UserClaimMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UserClaimMvosCount.Get(req);
            UserClaimMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new UserClaimMvosCountGetQuery();
            q.Filter = UserClaimMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new UserClaimMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UserClaimMvosCount.Get(req);
            UserClaimMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(await resp.RawContent.ReadAsStringAsync());
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IUserClaimMvoStateEvent> GetStateEventAsync(UserClaimId userClaimId, long version)
        {
            var idObj = UserClaimMvoProxyUtils.ToIdString(userClaimId);
            var uriParameters = new UserClaimMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new UserClaimMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.UserClaimMvoStateEvent.Get(req);
            UserClaimMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IUserClaimMvoStateEvent GetStateEvent(UserClaimId userClaimId, long version)
        {
            return GetStateEventAsync(userClaimId, version).GetAwaiter().GetResult();
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


    public partial class UserClaimMvoApplicationServiceProxyFactory : ProxyFactoryBase, IUserClaimMvoApplicationServiceFactory
    {

        public UserClaimMvoApplicationServiceProxyFactory() : base()
        {}

        public UserClaimMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IUserClaimMvoApplicationService UserClaimMvoApplicationService
        {
            get
            {
                return new UserClaimMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateUserClaimMvo NewCreateUserClaimMvo()
        {
            return new CreateUserClaimMvoDto();
        }

        public IMergePatchUserClaimMvo NewMergePatchUserClaimMvo()
        {
            return new MergePatchUserClaimMvoDto();
        }

        public IDeleteUserClaimMvo NewDeleteUserClaimMvo()
        {
            return new DeleteUserClaimMvoDto();
        }
    }

    public static class UserClaimMvoProxyUtils
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

        public static string ToIdString(UserClaimId id)
        {
            var formatter = new UserClaimIdFlattenedDtoFormatter();
            var idDto = new UserClaimIdFlattenedDto(id);
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

        public static IEnumerable<UserClaimId> ToIdCollection(IEnumerable<IUserClaimMvoState> states)
        {
            var ids = new List<UserClaimId>();
            foreach (var s in states)
            {
                ids.Add(s.UserClaimId);
            }
            return ids;
        }

    }

}

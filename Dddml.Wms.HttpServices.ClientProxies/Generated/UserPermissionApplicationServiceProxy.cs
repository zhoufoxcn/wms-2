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
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;
using System.Text;
using System.ComponentModel;
using RAML.Api.Core;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;


namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class UserPermissionApplicationServiceProxy : IUserPermissionApplicationService
    {


        private DddmlWmsRamlClient _ramlClient;

        public UserPermissionApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public UserPermissionApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public void When(CreateUserPermissionDto c)
        {
            var idObj = UserPermissionProxyUtils.ToIdString((c as ICreateUserPermission).Id);
            var uriParameters = new UserPermissionUriParameters();
            uriParameters.Id = idObj;

            var req = new UserPermissionPutRequest(uriParameters, (CreateUserPermissionDto)c);
                
            var resp = _ramlClient.UserPermission.Put(req).GetAwaiter().GetResult();
            UserPermissionProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchUserPermissionDto c)
        {
            var idObj = UserPermissionProxyUtils.ToIdString((c as IMergePatchUserPermission).Id);
            var uriParameters = new UserPermissionUriParameters();
            uriParameters.Id = idObj;

            var req = new UserPermissionPatchRequest(uriParameters, (MergePatchUserPermissionDto)c);
            var resp = _ramlClient.UserPermission.Patch(req).GetAwaiter().GetResult();
            UserPermissionProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteUserPermissionDto c)
        {
            //Action act = async () =>
            //{
            var idObj = UserPermissionProxyUtils.ToIdString((c as IDeleteUserPermission).Id);
            var uriParameters = new UserPermissionUriParameters();
            uriParameters.Id = idObj;

            var q = new UserPermissionDeleteQuery();
            q.CommandId = c.CommandId;
                
            var req = new UserPermissionDeleteRequest(uriParameters);
            req.Query = q;

            var resp = _ramlClient.UserPermission.Delete(req).GetAwaiter().GetResult();
            UserPermissionProxyUtils.ThrowOnHttpResponseError(resp);
            //};
            //act();
        }
		
        void IUserPermissionApplicationService.When(ICreateUserPermission c)
        {
            this.When((CreateUserPermissionDto)c);
        }

        void IUserPermissionApplicationService.When(IMergePatchUserPermission c)
        {
            this.When((MergePatchUserPermissionDto)c);
        }

        void IUserPermissionApplicationService.When(IDeleteUserPermission c)
        {
            this.When((DeleteUserPermissionDto)c);
        }

        public IUserPermissionState Get(UserPermissionId id)
        {
            IUserPermissionState state = null;
            var idObj = UserPermissionProxyUtils.ToIdString(id);
            var uriParameters = new UserPermissionUriParameters();
            uriParameters.Id = idObj;

            var req = new UserPermissionGetRequest(uriParameters);

            var resp = _ramlClient.UserPermission.Get(req).GetAwaiter().GetResult();
            UserPermissionProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IEnumerable<IUserPermissionState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IUserPermissionState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IUserPermissionState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IUserPermissionState> states = null;
			var q = new UserPermissionsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = UserPermissionProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = UserPermissionProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = UserPermissionProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new UserPermissionsGetRequest();
            req.Query = q;
            var resp = _ramlClient.UserPermissions.Get(req).GetAwaiter().GetResult();
            UserPermissionProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }


        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IUserPermissionState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IUserPermissionState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IUserPermissionState> states = null;
			var q = new UserPermissionsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = UserPermissionProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = UserPermissionProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = UserPermissionProxyUtils.GetFilterQueryValueString(filter);
            var req = new UserPermissionsGetRequest();
            req.Query = q;
            var resp = _ramlClient.UserPermissions.Get(req).GetAwaiter().GetResult();
            UserPermissionProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new UserPermissionsCountGetQuery();
            q.FilterTag = UserPermissionProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new UserPermissionsCountGetRequest();
            req.Query = q;
            var resp = _ramlClient.UserPermissionsCount.Get(req).GetAwaiter().GetResult();
            UserPermissionProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(resp.RawContent.ReadAsStringAsync().GetAwaiter().GetResult());
		}

        public virtual long GetCount(ICriterion filter)
		{
			var q = new UserPermissionsCountGetQuery();
            q.Filter = UserPermissionProxyUtils.GetFilterQueryValueString(filter);
            var req = new UserPermissionsCountGetRequest();
            req.Query = q;
            var resp = _ramlClient.UserPermissionsCount.Get(req).GetAwaiter().GetResult();
            UserPermissionProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(resp.RawContent.ReadAsStringAsync().GetAwaiter().GetResult());
		}

        public IUserPermissionStateEvent GetStateEvent(UserPermissionId id, long version)
        {
            var idObj = UserPermissionProxyUtils.ToIdString(id);
            var uriParameters = new UserPermissionStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new UserPermissionStateEventGetRequest(uriParameters);
            var resp = _ramlClient.UserPermissionStateEvent.Get(req).GetAwaiter().GetResult();
            UserPermissionProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
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


    public partial class UserPermissionApplicationServiceProxyFactory : IUserPermissionApplicationServiceFactory
    {

        private string _endpointUrl;

        public UserPermissionApplicationServiceProxyFactory(string endpointUrl)
        {
            this._endpointUrl = endpointUrl;
        }

        public IUserPermissionApplicationService UserPermissionApplicationService
        {
            get
            {
                return new UserPermissionApplicationServiceProxy(_endpointUrl);
            }
        }

        public ICreateUserPermission NewCreateUserPermission()
        {
            return new CreateUserPermissionDto();
        }

        public IMergePatchUserPermission NewMergePatchUserPermission()
        {
            return new MergePatchUserPermissionDto();
        }

        public IDeleteUserPermission NewDeleteUserPermission()
        {
            return new DeleteUserPermissionDto();
        }
    }

    public static class UserPermissionProxyUtils
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
                throw new NotSupportedException();
            }
        }

        public static string ToIdString(UserPermissionId id)
        {
            var formatter = new UserPermissionIdFlattenedDtoFormatter();
            var idDto = new UserPermissionIdFlattenedDto(id);
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

        public static IEnumerable<UserPermissionId> ToIdCollection(IEnumerable<IUserPermissionState> states)
        {
            var ids = new List<UserPermissionId>();
            foreach (var s in states)
            {
                ids.Add(s.Id);
            }
            return ids;
        }

    }

}


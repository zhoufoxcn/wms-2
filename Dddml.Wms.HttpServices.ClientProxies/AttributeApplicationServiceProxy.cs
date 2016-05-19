﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;

namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class AttributeApplicationServiceProxy : IAttributeApplicationService
    {


        private DddmlWmsRamlClient _ramlClient;

        public AttributeApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public AttributeApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public void When(CreateAttributeDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as ICreateAttribute).AttributeId);
            var uriParameters = new AttributeUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributePutRequest(uriParameters, (CreateAttributeDto)c);
                
            var resp = _ramlClient.Attribute.Put(req).GetAwaiter().GetResult();;
            //};
            //act();
        }

        public void When(MergePatchAttributeDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IMergePatchAttribute).AttributeId);
            var uriParameters = new AttributeUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributePatchRequest(uriParameters, (MergePatchAttributeDto)c);
            var resp = _ramlClient.Attribute.Patch(req).GetAwaiter().GetResult();;
            //};
            //act();
        }

        public void When(DeleteAttributeDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IDeleteAttribute).AttributeId);
            var uriParameters = new AttributeUriParameters();
            uriParameters.Id = idObj;

            var q = new AttributeDeleteQuery();
            q.CommandId = c.CommandId;
                
            var req = new AttributeDeleteRequest(uriParameters);
            req.Query = q;

            var resp = _ramlClient.Attribute.Delete(req).GetAwaiter().GetResult();;
            //};
            //act();
        }
		
        void IAttributeApplicationService.When(ICreateAttribute c)
        {
            this.When((CreateAttributeDto)c);
        }

        void IAttributeApplicationService.When(IMergePatchAttribute c)
        {
            this.When((MergePatchAttributeDto)c);
        }

        void IAttributeApplicationService.When(IDeleteAttribute c)
        {
            this.When((DeleteAttributeDto)c);
        }

        public IAttributeState Get(string attributeId)
        {
            IAttributeState state = null;
            //Action act = async () =>
            //{
            var idObj = (attributeId);
            var uriParameters = new AttributeUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeGetRequest(uriParameters);

            var resp = _ramlClient.Attribute.Get(req).GetAwaiter().GetResult();
            state = resp.Content;
            //};
            //act();
            return state;
        }

        public IEnumerable<IAttributeState> GetAll(int firstResult, int maxResults)
        {
            IEnumerable<IAttributeState> states = null;
            //Action act = async () =>
            //{
			var q = new AttributesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            var req = new AttributesGetRequest();
            req.Query = q;
            var resp = _ramlClient.Attributes.Get(req).GetAwaiter().GetResult();;
            states = resp.Content;
            //};
            //act();
            return states;
        }

        public IEnumerable<IAttributeState> Get(IDictionary<string, object> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {//////////////////// todo ///////////////////////////
            IEnumerable<IAttributeState> states = null;
            //Action act = async () =>
            //{
			var q = new AttributesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            var req = new AttributesGetRequest();
            req.Query = q;
            var resp = _ramlClient.Attributes.Get(req).GetAwaiter().GetResult();;
            states = resp.Content;
            //};
            //act();
            return states;
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }



    }


    public partial class AttributeApplicationServiceProxyFactory : IAttributeApplicationServiceFactory
    {

        private string _endpointUrl;

        public AttributeApplicationServiceProxyFactory(string endpointUrl)
        {
            this._endpointUrl = endpointUrl;
        }

        public IAttributeApplicationService AttributeApplicationService
        {
            get
            {
                return new AttributeApplicationServiceProxy(_endpointUrl);
            }
        }

        public ICreateAttribute NewCreateAttribute()
        {
            return new CreateAttributeDto();
        }

        public IMergePatchAttribute NewMergePatchAttribute()
        {
            return new MergePatchAttributeDto();
        }

        public IDeleteAttribute NewDeleteAttribute()
        {
            return new DeleteAttributeDto();
        }
    }


}


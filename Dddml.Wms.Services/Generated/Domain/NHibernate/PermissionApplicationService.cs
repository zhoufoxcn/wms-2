﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.NHibernate
{

	public class PermissionApplicationService : PermissionApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IPermissionStateRepository _stateRepository;

		protected override IPermissionStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IPermissionStateQueryRepository _stateQueryRepository;

		protected override IPermissionStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public PermissionApplicationService(IEventStore eventStore, IPermissionStateRepository stateRepository, IPermissionStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IPermissionAggregate GetPermissionAggregate(IPermissionState state)
		{
			return new PermissionAggregate(state);
		}

	}

}


﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

	public partial class UserClaimState : UserClaimStateProperties, IUserClaimState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

        private UserClaimId _userClaimId = new UserClaimId();

        public virtual UserClaimId UserClaimId 
        {
            get { return this._userClaimId; }
            set { this._userClaimId = value; }
        }

		UserClaimId IGlobalIdentity<UserClaimId>.GlobalId {
			get {
				return  this.UserClaimId;
			}
		}

        int ILocalIdentity<int>.LocalId
        {
            get
            {
                return this.ClaimId;
            }
        }


        public override string UserId {
			get {
				return this.UserClaimId.UserId;
			}
			set {
				this.UserClaimId.UserId = value;
			}
		}

        public override int ClaimId {
			get {
				return this.UserClaimId.ClaimId;
			}
			set {
				this.UserClaimId.ClaimId = value;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
			}
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IEntityVersioned<long>.EntityVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IUserClaimState.IsUnsaved
        {
            get { return this.Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public UserClaimState() : this(false)
        {
        }

        public UserClaimState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IUserClaimStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.ClaimType = e.ClaimType;

			this.ClaimValue = e.ClaimValue;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IUserClaimStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.ClaimType == null)
			{
				if (e.IsPropertyClaimTypeRemoved)
				{
					this.ClaimType = default(string);
				}
			}
			else
			{
				this.ClaimType = e.ClaimType;
			}

			if (e.ClaimValue == null)
			{
				if (e.IsPropertyClaimValueRemoved)
				{
					this.ClaimValue = default(string);
				}
			}
			else
			{
				this.ClaimValue = e.ClaimValue;
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IUserClaimStateRemoved e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IUserClaimStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("UserClaim|");

            var stateEntityIdUserId = (this as IGlobalIdentity<UserClaimId>).GlobalId.UserId;
            var eventEntityIdUserId = stateEvent.StateEventId.UserId;
            if (stateEntityIdUserId != eventEntityIdUserId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id UserId {0} in state but entity id UserId {1} in event", stateEntityIdUserId, eventEntityIdUserId);
            }
            id.Append(stateEntityIdUserId).Append(",");

            var stateEntityIdClaimId = (this as IGlobalIdentity<UserClaimId>).GlobalId.ClaimId;
            var eventEntityIdClaimId = stateEvent.StateEventId.ClaimId;
            if (stateEntityIdClaimId != eventEntityIdClaimId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id ClaimId {0} in state but entity id ClaimId {1} in event", stateEntityIdClaimId, eventEntityIdClaimId);
            }
            id.Append(stateEntityIdClaimId).Append(",");

            id.Append("]");

            if (ForReapplying) { return; }
            var stateVersion = this.Version;
            var eventVersion = stateEvent.Version;
            if (UserClaimState.VersionZero == eventVersion)
            {
                eventVersion = stateEvent.Version = stateVersion;
            }
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}


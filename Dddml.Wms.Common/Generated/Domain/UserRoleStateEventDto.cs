﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public abstract class UserRoleStateEventDtoBase : IStateEventDto, IUserRoleStateCreated, IUserRoleStateMergePatched, IUserRoleStateRemoved
	{

        private UserRoleStateEventIdDto _stateEventId;

		protected internal virtual UserRoleStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new UserRoleStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string RoleId
        {
            get { return StateEventId.RoleId; }
            set { StateEventId.RoleId = value; }
        }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		UserRoleStateEventId IGlobalIdentity<UserRoleStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToUserRoleStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IUserRoleStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }

		public virtual long Version { get; set; }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IUserRoleStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}


        UserRoleStateEventId IUserRoleStateEvent.StateEventId
        {
            get { return this.StateEventId.ToUserRoleStateEventId(); }
        }

        protected UserRoleStateEventDtoBase()
        {
        }

        protected UserRoleStateEventDtoBase(UserRoleStateEventIdDto stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class UserRoleStateCreatedOrMergePatchedOrRemovedDto : UserRoleStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class UserRoleStateCreatedDto : UserRoleStateCreatedOrMergePatchedOrRemovedDto
	{
		public UserRoleStateCreatedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class UserRoleStateMergePatchedDto : UserRoleStateCreatedOrMergePatchedOrRemovedDto
	{
		public UserRoleStateMergePatchedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class UserRoleStateRemovedDto : UserRoleStateCreatedOrMergePatchedOrRemovedDto
	{
		public UserRoleStateRemovedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }

	}


    public partial class UserRoleStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IUserRoleStateCreated>, IEnumerable<IUserRoleStateMergePatched>, IEnumerable<IUserRoleStateRemoved>
    {
        private List<UserRoleStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<UserRoleStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual UserRoleStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<UserRoleStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserRoleStateCreated> IEnumerable<IUserRoleStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserRoleStateMergePatched> IEnumerable<IUserRoleStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserRoleStateRemoved> IEnumerable<IUserRoleStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddUserRoleEvent(IUserRoleStateCreated e)
        {
            _innerStateEvents.Add((UserRoleStateCreatedDto)e);
        }

        public void AddUserRoleEvent(IUserRoleStateEvent e)
        {
            _innerStateEvents.Add((UserRoleStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddUserRoleEvent(IUserRoleStateRemoved e)
        {
            _innerStateEvents.Add((UserRoleStateRemovedDto)e);
        }

    }


}


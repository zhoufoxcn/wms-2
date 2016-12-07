﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

    public class UserPermissionStates : IUserPermissionStates
    {
        
		protected IUserPermissionStateDao UserPermissionStateDao
		{
			get
			{
				return ApplicationContext.Current["UserPermissionStateDao"] as IUserPermissionStateDao;
			}
		}

		private Dictionary<UserPermissionId, IUserPermissionState> _loadedUserPermissionStates = new Dictionary<UserPermissionId, IUserPermissionState>();

		private Dictionary<UserPermissionId, IUserPermissionState> _removedUserPermissionStates = new Dictionary<UserPermissionId, IUserPermissionState>();

		protected virtual IEnumerable<IUserPermissionState> LoadedUserPermissionStates {
			get {
				return this._loadedUserPermissionStates.Values;
			}
		}

        private IUserState _userState;

        private IEnumerable<IUserPermissionState> InnerEnumeralbe
        {
            get
            {
                if (!ForReapplying)
                {
                    return UserPermissionStateDao.FindByUserId(_userState.UserId);
                }
                else
                {
                    return _loadedUserPermissionStates.Values.Where(s => !(_removedUserPermissionStates.ContainsKey(s.GlobalId) && s.Deleted));
                }
            }
        }

        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public UserPermissionStates(IUserState outerState)
        {
            this._userState = outerState;
            this._forReapplying = outerState.ForReapplying;
        }

        public IEnumerator<IUserPermissionState> GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        public virtual void Remove(IUserPermissionState state)
        {
            this._removedUserPermissionStates.Add(state.GlobalId, state);
        }

        public virtual IUserPermissionState Get(string permissionId)
		{
			return Get(permissionId, false);
		}

        public virtual IUserPermissionState Get(string permissionId, bool forCreation)
        {
            UserPermissionId globalId = new UserPermissionId(_userState.UserId, permissionId);
            if (_loadedUserPermissionStates.ContainsKey(globalId)) {
                return _loadedUserPermissionStates[globalId];
            }
            if (forCreation || ForReapplying)
            {
                var state = new UserPermissionState(ForReapplying);
                state.UserPermissionId = globalId;
                _loadedUserPermissionStates.Add(globalId, state);
                return state;
            }
            else
            {
                var state = UserPermissionStateDao.Get(globalId);
                _loadedUserPermissionStates.Add(globalId, state);
                return state;
            }
        }

        public virtual void AddToSave(IUserPermissionState state)
        {
            this._loadedUserPermissionStates[state.GlobalId] = state;
        }

		#region Saveable Implements

		public virtual void Save ()
		{
			foreach (IUserPermissionState s in this.LoadedUserPermissionStates) {
                UserPermissionStateDao.Save(s);
			}
            foreach(IUserPermissionState s in this._removedUserPermissionStates.Values)
            {
                UserPermissionStateDao.Delete(s);
            }
		}

		#endregion


    }



}



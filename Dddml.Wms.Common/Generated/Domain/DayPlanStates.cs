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

    public class DayPlanStates : IDayPlanStates
    {
        
		protected IDayPlanStateDao DayPlanStateDao
		{
			get
			{
				return ApplicationContext.Current["DayPlanStateDao"] as IDayPlanStateDao;
			}
		}

		private Dictionary<DayPlanId, IDayPlanState> _loadedDayPlanStates = new Dictionary<DayPlanId, IDayPlanState>();

        private List<IDayPlanState> _removedDayPlanStates = new List<IDayPlanState>();

		protected virtual IEnumerable<IDayPlanState> LoadedDayPlanStates {
			get {
				return this._loadedDayPlanStates.Values;
			}
		}

        private IMonthPlanState _monthPlanState;

        private IEnumerable<IDayPlanState> _innerEnumerable;

        private IEnumerable<IDayPlanState> InnerEnumeralbe
        {
            get
            {
                if (_innerEnumerable == null)
                {
                    _innerEnumerable = DayPlanStateDao.FindByPersonalNameAndYearAndMonth((_monthPlanState as IGlobalIdentity<MonthPlanId>).GlobalId.PersonalName, (_monthPlanState as IGlobalIdentity<MonthPlanId>).GlobalId.Year, (_monthPlanState as IGlobalIdentity<MonthPlanId>).GlobalId.Month);
                }
                return _innerEnumerable;
            }
        }

        public DayPlanStates(IMonthPlanState outerState)
        {
            this._monthPlanState = outerState;
        }

        public IEnumerator<IDayPlanState> GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        public virtual void Remove(IDayPlanState state)
        {
            this._removedDayPlanStates.Add(state);
        }

        public virtual IDayPlanState Get(int day)
		{
			DayPlanId globalId = new DayPlanId((_monthPlanState as IGlobalIdentity<MonthPlanId>).GlobalId.PersonalName, (_monthPlanState as IGlobalIdentity<MonthPlanId>).GlobalId.Year, (_monthPlanState as IGlobalIdentity<MonthPlanId>).GlobalId.Month, day);
            if (_loadedDayPlanStates.ContainsKey(globalId)) {
                return _loadedDayPlanStates[globalId];
            }
            var state = DayPlanStateDao.Get(globalId);
			_loadedDayPlanStates.Add (globalId, state);
			return state;
		}

        public virtual void AddToSave(IDayPlanState state)
        {
            this._loadedDayPlanStates[state.GlobalId] = state;
        }

		#region Saveable Implements

		public virtual void Save ()
		{
			foreach (IDayPlanState s in this.LoadedDayPlanStates) {
                DayPlanStateDao.Save(s);
			}
            foreach(IDayPlanState s in this._removedDayPlanStates)
            {
                DayPlanStateDao.Delete(s);
            }
		}

		#endregion


    }



}



﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

    public class AttributeValueStates : IAttributeValueStates
    {
        
		private Dictionary<AttributeValueId, IAttributeValueState> _loadedAttributeValueStates = new Dictionary<AttributeValueId, IAttributeValueState>();

        private List<IAttributeValueState> _removedAttributeValueStates = new List<IAttributeValueState>();

		protected virtual IEnumerable<IAttributeValueState> LoadedAttributeValueStates {
			get {
				return this._loadedAttributeValueStates.Values;
			}
		}

        private IAttributeState _attributeState;

        private IEnumerable<IAttributeValueState> _innerEnumerable;

        private IEnumerable<IAttributeValueState> InnerEnumeralbe
        {
            get
            {
                if (_innerEnumerable == null)
                {
                    _innerEnumerable = (ApplicationContext.Current["AttributeValueStateDao"] as IAttributeValueStateDao).FindByAttributeId(_attributeState.AttributeId);
                }
                return _innerEnumerable;
            }
        }

        public AttributeValueStates(IAttributeState outerState)
        {
            this._attributeState = outerState;
        }

        public IEnumerator<IAttributeValueState> GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        public virtual void Remove(IAttributeValueState state)
        {
            this._removedAttributeValueStates.Add(state);
        }

        public virtual IAttributeValueState Get(string value)
		{
			AttributeValueId globalId = new AttributeValueId(_attributeState.AttributeId, value);
            if (_loadedAttributeValueStates.ContainsKey(globalId)) {
                return _loadedAttributeValueStates[globalId];
            }
            var state = (ApplicationContext.Current["AttributeValueStateDao"] as IAttributeValueStateDao).Get(globalId);
			_loadedAttributeValueStates.Add (globalId, state);
			return state;
		}

		#region Saveable Implements

		public virtual void Save ()
		{
			foreach (IAttributeValueState s in this.LoadedAttributeValueStates) {
                (ApplicationContext.Current["AttributeValueStateDao"] as IAttributeValueStateDao).Save(s);
			}
            foreach(IAttributeValueState s in this._removedAttributeValueStates)
            {
                (ApplicationContext.Current["AttributeValueStateDao"] as IAttributeValueStateDao).Delete(s);
            }
		}

		#endregion


    }



}


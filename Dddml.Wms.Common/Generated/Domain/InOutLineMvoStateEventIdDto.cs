﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{

	public class InOutLineMvoStateEventIdDto
	{

        private InOutLineMvoStateEventId _value = new InOutLineMvoStateEventId();

		public InOutLineMvoStateEventIdDto()
		{
		}

		public InOutLineMvoStateEventIdDto(InOutLineMvoStateEventId val)
		{
			this._value = val;
		}

        public InOutLineMvoStateEventId ToInOutLineMvoStateEventId()
        {
            return this._value;
        }

		public virtual InOutLineIdDto InOutLineId { 
			get { return new InOutLineIdDto(_value.InOutLineId); } 
			set { _value.InOutLineId = value.ToInOutLineId(); } 
		}

		public virtual long InOutVersion { 
			get { return _value.InOutVersion; } 
			set { _value.InOutVersion = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InOutLineMvoStateEventIdDto other = obj as InOutLineMvoStateEventIdDto;
			if (other == null) {
				return false;
			}

            return _value.Equals(other._value);

		}

		public override int GetHashCode ()
		{
			return _value.GetHashCode();
		}

	}

}



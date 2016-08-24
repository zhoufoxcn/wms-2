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

	public class YearPlanStateEventIdDto
	{

        private YearPlanStateEventId _value = new YearPlanStateEventId();

		public YearPlanStateEventIdDto()
		{
		}

		public YearPlanStateEventIdDto(YearPlanStateEventId val)
		{
			this._value = val;
		}

        public YearPlanStateEventId ToYearPlanStateEventId()
        {
            return this._value;
        }

		public virtual PersonalNameDto PersonalName { 
			get { return new PersonalNameDto(_value.PersonalName); } 
			set { _value.PersonalName = value.ToPersonalName(); } 
		}

		public virtual int Year { 
			get { return _value.Year; } 
			set { _value.Year = value; } 
		}

		public virtual long PersonVersion { 
			get { return _value.PersonVersion; } 
			set { _value.PersonVersion = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			YearPlanStateEventIdDto other = obj as YearPlanStateEventIdDto;
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


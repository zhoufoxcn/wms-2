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

	public static partial class InOutLineMvoStateExtension
	{

        public static IInOutLineMvoCommand ToCreateOrMergePatchInOutLineMvo(this InOutLineMvoState state)
        {
            return state.ToCreateOrMergePatchInOutLineMvo<CreateInOutLineMvo, MergePatchInOutLineMvo>();
        }

        public static DeleteInOutLineMvo ToDeleteInOutLineMvo(this InOutLineMvoState state)
        {
            return state.ToDeleteInOutLineMvo<DeleteInOutLineMvo>();
        }

        public static MergePatchInOutLineMvo ToMergePatchInOutLineMvo(this InOutLineMvoState state)
        {
            return state.ToMergePatchInOutLineMvo<MergePatchInOutLineMvo>();
        }

        public static CreateInOutLineMvo ToCreateInOutLineMvo(this InOutLineMvoState state)
        {
            return state.ToCreateInOutLineMvo<CreateInOutLineMvo>();
        }
		

	}

}

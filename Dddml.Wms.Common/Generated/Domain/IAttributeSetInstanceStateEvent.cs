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
	public interface IAttributeSetInstanceStateEvent : IEvent, IStateEventDto, IGlobalIdentity<AttributeSetInstanceStateEventId>, ICreated<string>
	{
		AttributeSetInstanceStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string AttributeSetId { get; set; }

		string OrganizationId { get; set; }

		string ReferenceId { get; set; }

		string SerialNumber { get; set; }

		string Lot { get; set; }

		string Description { get; set; }

		string Hash { get; set; }

		bool? _F_B_0_ { get; set; }

		int? _F_I_0_ { get; set; }

		long? _F_L_0_ { get; set; }

		DateTime? _F_DT_0_ { get; set; }

		decimal? _F_N_0_ { get; set; }

		string _F_C5_0_ { get; set; }

		string _F_C10_0_ { get; set; }

		string _F_C20_0_ { get; set; }

		string _F_C50_0_ { get; set; }

		string _F_C100_0_ { get; set; }

		string _F_C200_0_ { get; set; }

		string _F_C500_0_ { get; set; }

		string _F_C1000_0_ { get; set; }

		bool? _F_B_1_ { get; set; }

		int? _F_I_1_ { get; set; }

		long? _F_L_1_ { get; set; }

		DateTime? _F_DT_1_ { get; set; }

		decimal? _F_N_1_ { get; set; }

		string _F_C5_1_ { get; set; }

		string _F_C10_1_ { get; set; }

		string _F_C20_1_ { get; set; }

		string _F_C50_1_ { get; set; }

		string _F_C100_1_ { get; set; }

		string _F_C200_1_ { get; set; }

		string _F_C500_1_ { get; set; }

		string _F_C1000_1_ { get; set; }

		bool? _F_B_2_ { get; set; }

		int? _F_I_2_ { get; set; }

		long? _F_L_2_ { get; set; }

		DateTime? _F_DT_2_ { get; set; }

		decimal? _F_N_2_ { get; set; }

		string _F_C5_2_ { get; set; }

		string _F_C10_2_ { get; set; }

		string _F_C20_2_ { get; set; }

		string _F_C50_2_ { get; set; }

		string _F_C100_2_ { get; set; }

		string _F_C200_2_ { get; set; }

		string _F_C500_2_ { get; set; }

		string _F_C1000_2_ { get; set; }

		bool? _F_B_3_ { get; set; }

		int? _F_I_3_ { get; set; }

		long? _F_L_3_ { get; set; }

		DateTime? _F_DT_3_ { get; set; }

		decimal? _F_N_3_ { get; set; }

		string _F_C5_3_ { get; set; }

		string _F_C10_3_ { get; set; }

		string _F_C20_3_ { get; set; }

		string _F_C50_3_ { get; set; }

		string _F_C100_3_ { get; set; }

		string _F_C200_3_ { get; set; }

		string _F_C500_3_ { get; set; }

		string _F_C1000_3_ { get; set; }

		bool? _F_B_4_ { get; set; }

		int? _F_I_4_ { get; set; }

		long? _F_L_4_ { get; set; }

		DateTime? _F_DT_4_ { get; set; }

		decimal? _F_N_4_ { get; set; }

		string _F_C5_4_ { get; set; }

		string _F_C10_4_ { get; set; }

		string _F_C20_4_ { get; set; }

		string _F_C50_4_ { get; set; }

		string _F_C100_4_ { get; set; }

		string _F_C200_4_ { get; set; }

		string _F_C500_4_ { get; set; }

		string _F_C1000_4_ { get; set; }

		bool? _F_B_5_ { get; set; }

		int? _F_I_5_ { get; set; }

		long? _F_L_5_ { get; set; }

		DateTime? _F_DT_5_ { get; set; }

		decimal? _F_N_5_ { get; set; }

		string _F_C5_5_ { get; set; }

		string _F_C10_5_ { get; set; }

		string _F_C20_5_ { get; set; }

		string _F_C50_5_ { get; set; }

		string _F_C100_5_ { get; set; }

		string _F_C200_5_ { get; set; }

		string _F_C500_5_ { get; set; }

		bool? _F_B_6_ { get; set; }

		int? _F_I_6_ { get; set; }

		long? _F_L_6_ { get; set; }

		DateTime? _F_DT_6_ { get; set; }

		decimal? _F_N_6_ { get; set; }

		string _F_C5_6_ { get; set; }

		string _F_C10_6_ { get; set; }

		string _F_C20_6_ { get; set; }

		string _F_C50_6_ { get; set; }

		string _F_C100_6_ { get; set; }

		string _F_C200_6_ { get; set; }

		string _F_C500_6_ { get; set; }

		bool? _F_B_7_ { get; set; }

		int? _F_I_7_ { get; set; }

		long? _F_L_7_ { get; set; }

		DateTime? _F_DT_7_ { get; set; }

		decimal? _F_N_7_ { get; set; }

		string _F_C5_7_ { get; set; }

		string _F_C10_7_ { get; set; }

		string _F_C20_7_ { get; set; }

		string _F_C50_7_ { get; set; }

		string _F_C100_7_ { get; set; }

		string _F_C200_7_ { get; set; }

		string _F_C500_7_ { get; set; }

		bool? _F_B_8_ { get; set; }

		int? _F_I_8_ { get; set; }

		long? _F_L_8_ { get; set; }

		DateTime? _F_DT_8_ { get; set; }

		decimal? _F_N_8_ { get; set; }

		string _F_C5_8_ { get; set; }

		string _F_C10_8_ { get; set; }

		string _F_C20_8_ { get; set; }

		string _F_C50_8_ { get; set; }

		string _F_C100_8_ { get; set; }

		string _F_C200_8_ { get; set; }

		string _F_C500_8_ { get; set; }

		bool? _F_B_9_ { get; set; }

		int? _F_I_9_ { get; set; }

		long? _F_L_9_ { get; set; }

		DateTime? _F_DT_9_ { get; set; }

		decimal? _F_N_9_ { get; set; }

		string _F_C5_9_ { get; set; }

		string _F_C10_9_ { get; set; }

		string _F_C20_9_ { get; set; }

		string _F_C50_9_ { get; set; }

		string _F_C100_9_ { get; set; }

		string _F_C200_9_ { get; set; }

		string _F_C500_9_ { get; set; }

		bool? _F_B_10_ { get; set; }

		int? _F_I_10_ { get; set; }

		long? _F_L_10_ { get; set; }

		DateTime? _F_DT_10_ { get; set; }

		decimal? _F_N_10_ { get; set; }

		string _F_C5_10_ { get; set; }

		string _F_C10_10_ { get; set; }

		string _F_C20_10_ { get; set; }

		string _F_C50_10_ { get; set; }

		string _F_C100_10_ { get; set; }

		string _F_C200_10_ { get; set; }

		bool? _F_B_11_ { get; set; }

		int? _F_I_11_ { get; set; }

		long? _F_L_11_ { get; set; }

		DateTime? _F_DT_11_ { get; set; }

		decimal? _F_N_11_ { get; set; }

		string _F_C5_11_ { get; set; }

		string _F_C10_11_ { get; set; }

		string _F_C20_11_ { get; set; }

		string _F_C50_11_ { get; set; }

		string _F_C100_11_ { get; set; }

		string _F_C200_11_ { get; set; }

		bool? _F_B_12_ { get; set; }

		int? _F_I_12_ { get; set; }

		long? _F_L_12_ { get; set; }

		DateTime? _F_DT_12_ { get; set; }

		decimal? _F_N_12_ { get; set; }

		string _F_C5_12_ { get; set; }

		string _F_C10_12_ { get; set; }

		string _F_C20_12_ { get; set; }

		string _F_C50_12_ { get; set; }

		string _F_C100_12_ { get; set; }

		string _F_C200_12_ { get; set; }

		bool? _F_B_13_ { get; set; }

		int? _F_I_13_ { get; set; }

		long? _F_L_13_ { get; set; }

		DateTime? _F_DT_13_ { get; set; }

		decimal? _F_N_13_ { get; set; }

		string _F_C5_13_ { get; set; }

		string _F_C10_13_ { get; set; }

		string _F_C20_13_ { get; set; }

		string _F_C50_13_ { get; set; }

		string _F_C100_13_ { get; set; }

		string _F_C200_13_ { get; set; }

		bool? _F_B_14_ { get; set; }

		int? _F_I_14_ { get; set; }

		long? _F_L_14_ { get; set; }

		DateTime? _F_DT_14_ { get; set; }

		decimal? _F_N_14_ { get; set; }

		string _F_C5_14_ { get; set; }

		string _F_C10_14_ { get; set; }

		string _F_C20_14_ { get; set; }

		string _F_C50_14_ { get; set; }

		string _F_C100_14_ { get; set; }

		string _F_C200_14_ { get; set; }

		bool? _F_B_15_ { get; set; }

		int? _F_I_15_ { get; set; }

		long? _F_L_15_ { get; set; }

		DateTime? _F_DT_15_ { get; set; }

		decimal? _F_N_15_ { get; set; }

		string _F_C5_15_ { get; set; }

		string _F_C10_15_ { get; set; }

		string _F_C20_15_ { get; set; }

		string _F_C50_15_ { get; set; }

		string _F_C100_15_ { get; set; }

		string _F_C200_15_ { get; set; }

		bool? _F_B_16_ { get; set; }

		int? _F_I_16_ { get; set; }

		long? _F_L_16_ { get; set; }

		DateTime? _F_DT_16_ { get; set; }

		decimal? _F_N_16_ { get; set; }

		string _F_C5_16_ { get; set; }

		string _F_C10_16_ { get; set; }

		string _F_C20_16_ { get; set; }

		string _F_C50_16_ { get; set; }

		string _F_C100_16_ { get; set; }

		string _F_C200_16_ { get; set; }

		bool? _F_B_17_ { get; set; }

		int? _F_I_17_ { get; set; }

		long? _F_L_17_ { get; set; }

		DateTime? _F_DT_17_ { get; set; }

		decimal? _F_N_17_ { get; set; }

		string _F_C5_17_ { get; set; }

		string _F_C10_17_ { get; set; }

		string _F_C20_17_ { get; set; }

		string _F_C50_17_ { get; set; }

		string _F_C100_17_ { get; set; }

		string _F_C200_17_ { get; set; }

		bool? _F_B_18_ { get; set; }

		int? _F_I_18_ { get; set; }

		long? _F_L_18_ { get; set; }

		DateTime? _F_DT_18_ { get; set; }

		decimal? _F_N_18_ { get; set; }

		string _F_C5_18_ { get; set; }

		string _F_C10_18_ { get; set; }

		string _F_C20_18_ { get; set; }

		string _F_C50_18_ { get; set; }

		string _F_C100_18_ { get; set; }

		string _F_C200_18_ { get; set; }

		bool? _F_B_19_ { get; set; }

		int? _F_I_19_ { get; set; }

		long? _F_L_19_ { get; set; }

		DateTime? _F_DT_19_ { get; set; }

		decimal? _F_N_19_ { get; set; }

		string _F_C5_19_ { get; set; }

		string _F_C10_19_ { get; set; }

		string _F_C20_19_ { get; set; }

		string _F_C50_19_ { get; set; }

		string _F_C100_19_ { get; set; }

		string _F_C200_19_ { get; set; }

		bool? _F_B_20_ { get; set; }

		int? _F_I_20_ { get; set; }

		long? _F_L_20_ { get; set; }

		decimal? _F_N_20_ { get; set; }

		string _F_C5_20_ { get; set; }

		string _F_C10_20_ { get; set; }

		string _F_C20_20_ { get; set; }

		string _F_C50_20_ { get; set; }

		bool? _F_B_21_ { get; set; }

		int? _F_I_21_ { get; set; }

		long? _F_L_21_ { get; set; }

		decimal? _F_N_21_ { get; set; }

		string _F_C5_21_ { get; set; }

		string _F_C10_21_ { get; set; }

		string _F_C20_21_ { get; set; }

		string _F_C50_21_ { get; set; }

		bool? _F_B_22_ { get; set; }

		int? _F_I_22_ { get; set; }

		long? _F_L_22_ { get; set; }

		decimal? _F_N_22_ { get; set; }

		string _F_C5_22_ { get; set; }

		string _F_C10_22_ { get; set; }

		string _F_C20_22_ { get; set; }

		string _F_C50_22_ { get; set; }

		bool? _F_B_23_ { get; set; }

		int? _F_I_23_ { get; set; }

		long? _F_L_23_ { get; set; }

		decimal? _F_N_23_ { get; set; }

		string _F_C5_23_ { get; set; }

		string _F_C10_23_ { get; set; }

		string _F_C20_23_ { get; set; }

		string _F_C50_23_ { get; set; }

		bool? _F_B_24_ { get; set; }

		int? _F_I_24_ { get; set; }

		long? _F_L_24_ { get; set; }

		decimal? _F_N_24_ { get; set; }

		string _F_C5_24_ { get; set; }

		string _F_C10_24_ { get; set; }

		string _F_C20_24_ { get; set; }

		string _F_C50_24_ { get; set; }

		bool? _F_B_25_ { get; set; }

		int? _F_I_25_ { get; set; }

		long? _F_L_25_ { get; set; }

		decimal? _F_N_25_ { get; set; }

		string _F_C5_25_ { get; set; }

		string _F_C10_25_ { get; set; }

		string _F_C20_25_ { get; set; }

		string _F_C50_25_ { get; set; }

		bool? _F_B_26_ { get; set; }

		int? _F_I_26_ { get; set; }

		long? _F_L_26_ { get; set; }

		decimal? _F_N_26_ { get; set; }

		string _F_C5_26_ { get; set; }

		string _F_C10_26_ { get; set; }

		string _F_C20_26_ { get; set; }

		string _F_C50_26_ { get; set; }

		bool? _F_B_27_ { get; set; }

		int? _F_I_27_ { get; set; }

		long? _F_L_27_ { get; set; }

		decimal? _F_N_27_ { get; set; }

		string _F_C5_27_ { get; set; }

		string _F_C10_27_ { get; set; }

		string _F_C20_27_ { get; set; }

		string _F_C50_27_ { get; set; }

		bool? _F_B_28_ { get; set; }

		int? _F_I_28_ { get; set; }

		long? _F_L_28_ { get; set; }

		decimal? _F_N_28_ { get; set; }

		string _F_C5_28_ { get; set; }

		string _F_C10_28_ { get; set; }

		string _F_C20_28_ { get; set; }

		string _F_C50_28_ { get; set; }

		bool? _F_B_29_ { get; set; }

		int? _F_I_29_ { get; set; }

		long? _F_L_29_ { get; set; }

		decimal? _F_N_29_ { get; set; }

		string _F_C5_29_ { get; set; }

		string _F_C10_29_ { get; set; }

		string _F_C20_29_ { get; set; }

		string _F_C50_29_ { get; set; }

		bool? _F_B_30_ { get; set; }

		int? _F_I_30_ { get; set; }

		decimal? _F_N_30_ { get; set; }

		string _F_C5_30_ { get; set; }

		string _F_C10_30_ { get; set; }

		string _F_C20_30_ { get; set; }

		string _F_C50_30_ { get; set; }

		bool? _F_B_31_ { get; set; }

		int? _F_I_31_ { get; set; }

		decimal? _F_N_31_ { get; set; }

		string _F_C5_31_ { get; set; }

		string _F_C10_31_ { get; set; }

		string _F_C20_31_ { get; set; }

		string _F_C50_31_ { get; set; }

		bool? _F_B_32_ { get; set; }

		int? _F_I_32_ { get; set; }

		decimal? _F_N_32_ { get; set; }

		string _F_C5_32_ { get; set; }

		string _F_C10_32_ { get; set; }

		string _F_C20_32_ { get; set; }

		string _F_C50_32_ { get; set; }

		bool? _F_B_33_ { get; set; }

		int? _F_I_33_ { get; set; }

		decimal? _F_N_33_ { get; set; }

		string _F_C5_33_ { get; set; }

		string _F_C10_33_ { get; set; }

		string _F_C20_33_ { get; set; }

		string _F_C50_33_ { get; set; }

		bool? _F_B_34_ { get; set; }

		int? _F_I_34_ { get; set; }

		decimal? _F_N_34_ { get; set; }

		string _F_C5_34_ { get; set; }

		string _F_C10_34_ { get; set; }

		string _F_C20_34_ { get; set; }

		string _F_C50_34_ { get; set; }

		bool? _F_B_35_ { get; set; }

		int? _F_I_35_ { get; set; }

		decimal? _F_N_35_ { get; set; }

		string _F_C5_35_ { get; set; }

		string _F_C10_35_ { get; set; }

		string _F_C20_35_ { get; set; }

		string _F_C50_35_ { get; set; }

		bool? _F_B_36_ { get; set; }

		int? _F_I_36_ { get; set; }

		decimal? _F_N_36_ { get; set; }

		string _F_C5_36_ { get; set; }

		string _F_C10_36_ { get; set; }

		string _F_C20_36_ { get; set; }

		string _F_C50_36_ { get; set; }

		bool? _F_B_37_ { get; set; }

		int? _F_I_37_ { get; set; }

		decimal? _F_N_37_ { get; set; }

		string _F_C5_37_ { get; set; }

		string _F_C10_37_ { get; set; }

		string _F_C20_37_ { get; set; }

		string _F_C50_37_ { get; set; }

		bool? _F_B_38_ { get; set; }

		int? _F_I_38_ { get; set; }

		decimal? _F_N_38_ { get; set; }

		string _F_C5_38_ { get; set; }

		string _F_C10_38_ { get; set; }

		string _F_C20_38_ { get; set; }

		string _F_C50_38_ { get; set; }

		bool? _F_B_39_ { get; set; }

		int? _F_I_39_ { get; set; }

		decimal? _F_N_39_ { get; set; }

		string _F_C5_39_ { get; set; }

		string _F_C10_39_ { get; set; }

		string _F_C20_39_ { get; set; }

		string _F_C50_39_ { get; set; }

		bool? _F_B_40_ { get; set; }

		int? _F_I_40_ { get; set; }

		decimal? _F_N_40_ { get; set; }

		string _F_C5_40_ { get; set; }

		string _F_C10_40_ { get; set; }

		string _F_C20_40_ { get; set; }

		string _F_C50_40_ { get; set; }

		bool? _F_B_41_ { get; set; }

		int? _F_I_41_ { get; set; }

		decimal? _F_N_41_ { get; set; }

		string _F_C5_41_ { get; set; }

		string _F_C10_41_ { get; set; }

		string _F_C20_41_ { get; set; }

		string _F_C50_41_ { get; set; }

		bool? _F_B_42_ { get; set; }

		int? _F_I_42_ { get; set; }

		decimal? _F_N_42_ { get; set; }

		string _F_C5_42_ { get; set; }

		string _F_C10_42_ { get; set; }

		string _F_C20_42_ { get; set; }

		string _F_C50_42_ { get; set; }

		bool? _F_B_43_ { get; set; }

		int? _F_I_43_ { get; set; }

		decimal? _F_N_43_ { get; set; }

		string _F_C5_43_ { get; set; }

		string _F_C10_43_ { get; set; }

		string _F_C20_43_ { get; set; }

		string _F_C50_43_ { get; set; }

		bool? _F_B_44_ { get; set; }

		int? _F_I_44_ { get; set; }

		decimal? _F_N_44_ { get; set; }

		string _F_C5_44_ { get; set; }

		string _F_C10_44_ { get; set; }

		string _F_C20_44_ { get; set; }

		string _F_C50_44_ { get; set; }

		bool? _F_B_45_ { get; set; }

		int? _F_I_45_ { get; set; }

		decimal? _F_N_45_ { get; set; }

		string _F_C5_45_ { get; set; }

		string _F_C10_45_ { get; set; }

		string _F_C20_45_ { get; set; }

		string _F_C50_45_ { get; set; }

		bool? _F_B_46_ { get; set; }

		int? _F_I_46_ { get; set; }

		decimal? _F_N_46_ { get; set; }

		string _F_C5_46_ { get; set; }

		string _F_C10_46_ { get; set; }

		string _F_C20_46_ { get; set; }

		string _F_C50_46_ { get; set; }

		bool? _F_B_47_ { get; set; }

		int? _F_I_47_ { get; set; }

		decimal? _F_N_47_ { get; set; }

		string _F_C5_47_ { get; set; }

		string _F_C10_47_ { get; set; }

		string _F_C20_47_ { get; set; }

		string _F_C50_47_ { get; set; }

		bool? _F_B_48_ { get; set; }

		int? _F_I_48_ { get; set; }

		decimal? _F_N_48_ { get; set; }

		string _F_C5_48_ { get; set; }

		string _F_C10_48_ { get; set; }

		string _F_C20_48_ { get; set; }

		string _F_C50_48_ { get; set; }

		bool? _F_B_49_ { get; set; }

		int? _F_I_49_ { get; set; }

		decimal? _F_N_49_ { get; set; }

		string _F_C5_49_ { get; set; }

		string _F_C10_49_ { get; set; }

		string _F_C20_49_ { get; set; }

		string _F_C50_49_ { get; set; }

		bool? Active { get; set; }

	}

	public interface IAttributeSetInstanceStateCreated : IAttributeSetInstanceStateEvent//, IAttributeSetInstanceStateProperties
	{
	
	}


	public interface IAttributeSetInstanceStateMergePatched : IAttributeSetInstanceStateEvent//, IAttributeSetInstanceStateProperties
	{
		bool IsPropertyAttributeSetIdRemoved { get; set; }

		bool IsPropertyOrganizationIdRemoved { get; set; }

		bool IsPropertyReferenceIdRemoved { get; set; }

		bool IsPropertySerialNumberRemoved { get; set; }

		bool IsPropertyLotRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyHashRemoved { get; set; }

		bool IsProperty_F_B_0_Removed { get; set; }

		bool IsProperty_F_I_0_Removed { get; set; }

		bool IsProperty_F_L_0_Removed { get; set; }

		bool IsProperty_F_DT_0_Removed { get; set; }

		bool IsProperty_F_N_0_Removed { get; set; }

		bool IsProperty_F_C5_0_Removed { get; set; }

		bool IsProperty_F_C10_0_Removed { get; set; }

		bool IsProperty_F_C20_0_Removed { get; set; }

		bool IsProperty_F_C50_0_Removed { get; set; }

		bool IsProperty_F_C100_0_Removed { get; set; }

		bool IsProperty_F_C200_0_Removed { get; set; }

		bool IsProperty_F_C500_0_Removed { get; set; }

		bool IsProperty_F_C1000_0_Removed { get; set; }

		bool IsProperty_F_B_1_Removed { get; set; }

		bool IsProperty_F_I_1_Removed { get; set; }

		bool IsProperty_F_L_1_Removed { get; set; }

		bool IsProperty_F_DT_1_Removed { get; set; }

		bool IsProperty_F_N_1_Removed { get; set; }

		bool IsProperty_F_C5_1_Removed { get; set; }

		bool IsProperty_F_C10_1_Removed { get; set; }

		bool IsProperty_F_C20_1_Removed { get; set; }

		bool IsProperty_F_C50_1_Removed { get; set; }

		bool IsProperty_F_C100_1_Removed { get; set; }

		bool IsProperty_F_C200_1_Removed { get; set; }

		bool IsProperty_F_C500_1_Removed { get; set; }

		bool IsProperty_F_C1000_1_Removed { get; set; }

		bool IsProperty_F_B_2_Removed { get; set; }

		bool IsProperty_F_I_2_Removed { get; set; }

		bool IsProperty_F_L_2_Removed { get; set; }

		bool IsProperty_F_DT_2_Removed { get; set; }

		bool IsProperty_F_N_2_Removed { get; set; }

		bool IsProperty_F_C5_2_Removed { get; set; }

		bool IsProperty_F_C10_2_Removed { get; set; }

		bool IsProperty_F_C20_2_Removed { get; set; }

		bool IsProperty_F_C50_2_Removed { get; set; }

		bool IsProperty_F_C100_2_Removed { get; set; }

		bool IsProperty_F_C200_2_Removed { get; set; }

		bool IsProperty_F_C500_2_Removed { get; set; }

		bool IsProperty_F_C1000_2_Removed { get; set; }

		bool IsProperty_F_B_3_Removed { get; set; }

		bool IsProperty_F_I_3_Removed { get; set; }

		bool IsProperty_F_L_3_Removed { get; set; }

		bool IsProperty_F_DT_3_Removed { get; set; }

		bool IsProperty_F_N_3_Removed { get; set; }

		bool IsProperty_F_C5_3_Removed { get; set; }

		bool IsProperty_F_C10_3_Removed { get; set; }

		bool IsProperty_F_C20_3_Removed { get; set; }

		bool IsProperty_F_C50_3_Removed { get; set; }

		bool IsProperty_F_C100_3_Removed { get; set; }

		bool IsProperty_F_C200_3_Removed { get; set; }

		bool IsProperty_F_C500_3_Removed { get; set; }

		bool IsProperty_F_C1000_3_Removed { get; set; }

		bool IsProperty_F_B_4_Removed { get; set; }

		bool IsProperty_F_I_4_Removed { get; set; }

		bool IsProperty_F_L_4_Removed { get; set; }

		bool IsProperty_F_DT_4_Removed { get; set; }

		bool IsProperty_F_N_4_Removed { get; set; }

		bool IsProperty_F_C5_4_Removed { get; set; }

		bool IsProperty_F_C10_4_Removed { get; set; }

		bool IsProperty_F_C20_4_Removed { get; set; }

		bool IsProperty_F_C50_4_Removed { get; set; }

		bool IsProperty_F_C100_4_Removed { get; set; }

		bool IsProperty_F_C200_4_Removed { get; set; }

		bool IsProperty_F_C500_4_Removed { get; set; }

		bool IsProperty_F_C1000_4_Removed { get; set; }

		bool IsProperty_F_B_5_Removed { get; set; }

		bool IsProperty_F_I_5_Removed { get; set; }

		bool IsProperty_F_L_5_Removed { get; set; }

		bool IsProperty_F_DT_5_Removed { get; set; }

		bool IsProperty_F_N_5_Removed { get; set; }

		bool IsProperty_F_C5_5_Removed { get; set; }

		bool IsProperty_F_C10_5_Removed { get; set; }

		bool IsProperty_F_C20_5_Removed { get; set; }

		bool IsProperty_F_C50_5_Removed { get; set; }

		bool IsProperty_F_C100_5_Removed { get; set; }

		bool IsProperty_F_C200_5_Removed { get; set; }

		bool IsProperty_F_C500_5_Removed { get; set; }

		bool IsProperty_F_B_6_Removed { get; set; }

		bool IsProperty_F_I_6_Removed { get; set; }

		bool IsProperty_F_L_6_Removed { get; set; }

		bool IsProperty_F_DT_6_Removed { get; set; }

		bool IsProperty_F_N_6_Removed { get; set; }

		bool IsProperty_F_C5_6_Removed { get; set; }

		bool IsProperty_F_C10_6_Removed { get; set; }

		bool IsProperty_F_C20_6_Removed { get; set; }

		bool IsProperty_F_C50_6_Removed { get; set; }

		bool IsProperty_F_C100_6_Removed { get; set; }

		bool IsProperty_F_C200_6_Removed { get; set; }

		bool IsProperty_F_C500_6_Removed { get; set; }

		bool IsProperty_F_B_7_Removed { get; set; }

		bool IsProperty_F_I_7_Removed { get; set; }

		bool IsProperty_F_L_7_Removed { get; set; }

		bool IsProperty_F_DT_7_Removed { get; set; }

		bool IsProperty_F_N_7_Removed { get; set; }

		bool IsProperty_F_C5_7_Removed { get; set; }

		bool IsProperty_F_C10_7_Removed { get; set; }

		bool IsProperty_F_C20_7_Removed { get; set; }

		bool IsProperty_F_C50_7_Removed { get; set; }

		bool IsProperty_F_C100_7_Removed { get; set; }

		bool IsProperty_F_C200_7_Removed { get; set; }

		bool IsProperty_F_C500_7_Removed { get; set; }

		bool IsProperty_F_B_8_Removed { get; set; }

		bool IsProperty_F_I_8_Removed { get; set; }

		bool IsProperty_F_L_8_Removed { get; set; }

		bool IsProperty_F_DT_8_Removed { get; set; }

		bool IsProperty_F_N_8_Removed { get; set; }

		bool IsProperty_F_C5_8_Removed { get; set; }

		bool IsProperty_F_C10_8_Removed { get; set; }

		bool IsProperty_F_C20_8_Removed { get; set; }

		bool IsProperty_F_C50_8_Removed { get; set; }

		bool IsProperty_F_C100_8_Removed { get; set; }

		bool IsProperty_F_C200_8_Removed { get; set; }

		bool IsProperty_F_C500_8_Removed { get; set; }

		bool IsProperty_F_B_9_Removed { get; set; }

		bool IsProperty_F_I_9_Removed { get; set; }

		bool IsProperty_F_L_9_Removed { get; set; }

		bool IsProperty_F_DT_9_Removed { get; set; }

		bool IsProperty_F_N_9_Removed { get; set; }

		bool IsProperty_F_C5_9_Removed { get; set; }

		bool IsProperty_F_C10_9_Removed { get; set; }

		bool IsProperty_F_C20_9_Removed { get; set; }

		bool IsProperty_F_C50_9_Removed { get; set; }

		bool IsProperty_F_C100_9_Removed { get; set; }

		bool IsProperty_F_C200_9_Removed { get; set; }

		bool IsProperty_F_C500_9_Removed { get; set; }

		bool IsProperty_F_B_10_Removed { get; set; }

		bool IsProperty_F_I_10_Removed { get; set; }

		bool IsProperty_F_L_10_Removed { get; set; }

		bool IsProperty_F_DT_10_Removed { get; set; }

		bool IsProperty_F_N_10_Removed { get; set; }

		bool IsProperty_F_C5_10_Removed { get; set; }

		bool IsProperty_F_C10_10_Removed { get; set; }

		bool IsProperty_F_C20_10_Removed { get; set; }

		bool IsProperty_F_C50_10_Removed { get; set; }

		bool IsProperty_F_C100_10_Removed { get; set; }

		bool IsProperty_F_C200_10_Removed { get; set; }

		bool IsProperty_F_B_11_Removed { get; set; }

		bool IsProperty_F_I_11_Removed { get; set; }

		bool IsProperty_F_L_11_Removed { get; set; }

		bool IsProperty_F_DT_11_Removed { get; set; }

		bool IsProperty_F_N_11_Removed { get; set; }

		bool IsProperty_F_C5_11_Removed { get; set; }

		bool IsProperty_F_C10_11_Removed { get; set; }

		bool IsProperty_F_C20_11_Removed { get; set; }

		bool IsProperty_F_C50_11_Removed { get; set; }

		bool IsProperty_F_C100_11_Removed { get; set; }

		bool IsProperty_F_C200_11_Removed { get; set; }

		bool IsProperty_F_B_12_Removed { get; set; }

		bool IsProperty_F_I_12_Removed { get; set; }

		bool IsProperty_F_L_12_Removed { get; set; }

		bool IsProperty_F_DT_12_Removed { get; set; }

		bool IsProperty_F_N_12_Removed { get; set; }

		bool IsProperty_F_C5_12_Removed { get; set; }

		bool IsProperty_F_C10_12_Removed { get; set; }

		bool IsProperty_F_C20_12_Removed { get; set; }

		bool IsProperty_F_C50_12_Removed { get; set; }

		bool IsProperty_F_C100_12_Removed { get; set; }

		bool IsProperty_F_C200_12_Removed { get; set; }

		bool IsProperty_F_B_13_Removed { get; set; }

		bool IsProperty_F_I_13_Removed { get; set; }

		bool IsProperty_F_L_13_Removed { get; set; }

		bool IsProperty_F_DT_13_Removed { get; set; }

		bool IsProperty_F_N_13_Removed { get; set; }

		bool IsProperty_F_C5_13_Removed { get; set; }

		bool IsProperty_F_C10_13_Removed { get; set; }

		bool IsProperty_F_C20_13_Removed { get; set; }

		bool IsProperty_F_C50_13_Removed { get; set; }

		bool IsProperty_F_C100_13_Removed { get; set; }

		bool IsProperty_F_C200_13_Removed { get; set; }

		bool IsProperty_F_B_14_Removed { get; set; }

		bool IsProperty_F_I_14_Removed { get; set; }

		bool IsProperty_F_L_14_Removed { get; set; }

		bool IsProperty_F_DT_14_Removed { get; set; }

		bool IsProperty_F_N_14_Removed { get; set; }

		bool IsProperty_F_C5_14_Removed { get; set; }

		bool IsProperty_F_C10_14_Removed { get; set; }

		bool IsProperty_F_C20_14_Removed { get; set; }

		bool IsProperty_F_C50_14_Removed { get; set; }

		bool IsProperty_F_C100_14_Removed { get; set; }

		bool IsProperty_F_C200_14_Removed { get; set; }

		bool IsProperty_F_B_15_Removed { get; set; }

		bool IsProperty_F_I_15_Removed { get; set; }

		bool IsProperty_F_L_15_Removed { get; set; }

		bool IsProperty_F_DT_15_Removed { get; set; }

		bool IsProperty_F_N_15_Removed { get; set; }

		bool IsProperty_F_C5_15_Removed { get; set; }

		bool IsProperty_F_C10_15_Removed { get; set; }

		bool IsProperty_F_C20_15_Removed { get; set; }

		bool IsProperty_F_C50_15_Removed { get; set; }

		bool IsProperty_F_C100_15_Removed { get; set; }

		bool IsProperty_F_C200_15_Removed { get; set; }

		bool IsProperty_F_B_16_Removed { get; set; }

		bool IsProperty_F_I_16_Removed { get; set; }

		bool IsProperty_F_L_16_Removed { get; set; }

		bool IsProperty_F_DT_16_Removed { get; set; }

		bool IsProperty_F_N_16_Removed { get; set; }

		bool IsProperty_F_C5_16_Removed { get; set; }

		bool IsProperty_F_C10_16_Removed { get; set; }

		bool IsProperty_F_C20_16_Removed { get; set; }

		bool IsProperty_F_C50_16_Removed { get; set; }

		bool IsProperty_F_C100_16_Removed { get; set; }

		bool IsProperty_F_C200_16_Removed { get; set; }

		bool IsProperty_F_B_17_Removed { get; set; }

		bool IsProperty_F_I_17_Removed { get; set; }

		bool IsProperty_F_L_17_Removed { get; set; }

		bool IsProperty_F_DT_17_Removed { get; set; }

		bool IsProperty_F_N_17_Removed { get; set; }

		bool IsProperty_F_C5_17_Removed { get; set; }

		bool IsProperty_F_C10_17_Removed { get; set; }

		bool IsProperty_F_C20_17_Removed { get; set; }

		bool IsProperty_F_C50_17_Removed { get; set; }

		bool IsProperty_F_C100_17_Removed { get; set; }

		bool IsProperty_F_C200_17_Removed { get; set; }

		bool IsProperty_F_B_18_Removed { get; set; }

		bool IsProperty_F_I_18_Removed { get; set; }

		bool IsProperty_F_L_18_Removed { get; set; }

		bool IsProperty_F_DT_18_Removed { get; set; }

		bool IsProperty_F_N_18_Removed { get; set; }

		bool IsProperty_F_C5_18_Removed { get; set; }

		bool IsProperty_F_C10_18_Removed { get; set; }

		bool IsProperty_F_C20_18_Removed { get; set; }

		bool IsProperty_F_C50_18_Removed { get; set; }

		bool IsProperty_F_C100_18_Removed { get; set; }

		bool IsProperty_F_C200_18_Removed { get; set; }

		bool IsProperty_F_B_19_Removed { get; set; }

		bool IsProperty_F_I_19_Removed { get; set; }

		bool IsProperty_F_L_19_Removed { get; set; }

		bool IsProperty_F_DT_19_Removed { get; set; }

		bool IsProperty_F_N_19_Removed { get; set; }

		bool IsProperty_F_C5_19_Removed { get; set; }

		bool IsProperty_F_C10_19_Removed { get; set; }

		bool IsProperty_F_C20_19_Removed { get; set; }

		bool IsProperty_F_C50_19_Removed { get; set; }

		bool IsProperty_F_C100_19_Removed { get; set; }

		bool IsProperty_F_C200_19_Removed { get; set; }

		bool IsProperty_F_B_20_Removed { get; set; }

		bool IsProperty_F_I_20_Removed { get; set; }

		bool IsProperty_F_L_20_Removed { get; set; }

		bool IsProperty_F_N_20_Removed { get; set; }

		bool IsProperty_F_C5_20_Removed { get; set; }

		bool IsProperty_F_C10_20_Removed { get; set; }

		bool IsProperty_F_C20_20_Removed { get; set; }

		bool IsProperty_F_C50_20_Removed { get; set; }

		bool IsProperty_F_B_21_Removed { get; set; }

		bool IsProperty_F_I_21_Removed { get; set; }

		bool IsProperty_F_L_21_Removed { get; set; }

		bool IsProperty_F_N_21_Removed { get; set; }

		bool IsProperty_F_C5_21_Removed { get; set; }

		bool IsProperty_F_C10_21_Removed { get; set; }

		bool IsProperty_F_C20_21_Removed { get; set; }

		bool IsProperty_F_C50_21_Removed { get; set; }

		bool IsProperty_F_B_22_Removed { get; set; }

		bool IsProperty_F_I_22_Removed { get; set; }

		bool IsProperty_F_L_22_Removed { get; set; }

		bool IsProperty_F_N_22_Removed { get; set; }

		bool IsProperty_F_C5_22_Removed { get; set; }

		bool IsProperty_F_C10_22_Removed { get; set; }

		bool IsProperty_F_C20_22_Removed { get; set; }

		bool IsProperty_F_C50_22_Removed { get; set; }

		bool IsProperty_F_B_23_Removed { get; set; }

		bool IsProperty_F_I_23_Removed { get; set; }

		bool IsProperty_F_L_23_Removed { get; set; }

		bool IsProperty_F_N_23_Removed { get; set; }

		bool IsProperty_F_C5_23_Removed { get; set; }

		bool IsProperty_F_C10_23_Removed { get; set; }

		bool IsProperty_F_C20_23_Removed { get; set; }

		bool IsProperty_F_C50_23_Removed { get; set; }

		bool IsProperty_F_B_24_Removed { get; set; }

		bool IsProperty_F_I_24_Removed { get; set; }

		bool IsProperty_F_L_24_Removed { get; set; }

		bool IsProperty_F_N_24_Removed { get; set; }

		bool IsProperty_F_C5_24_Removed { get; set; }

		bool IsProperty_F_C10_24_Removed { get; set; }

		bool IsProperty_F_C20_24_Removed { get; set; }

		bool IsProperty_F_C50_24_Removed { get; set; }

		bool IsProperty_F_B_25_Removed { get; set; }

		bool IsProperty_F_I_25_Removed { get; set; }

		bool IsProperty_F_L_25_Removed { get; set; }

		bool IsProperty_F_N_25_Removed { get; set; }

		bool IsProperty_F_C5_25_Removed { get; set; }

		bool IsProperty_F_C10_25_Removed { get; set; }

		bool IsProperty_F_C20_25_Removed { get; set; }

		bool IsProperty_F_C50_25_Removed { get; set; }

		bool IsProperty_F_B_26_Removed { get; set; }

		bool IsProperty_F_I_26_Removed { get; set; }

		bool IsProperty_F_L_26_Removed { get; set; }

		bool IsProperty_F_N_26_Removed { get; set; }

		bool IsProperty_F_C5_26_Removed { get; set; }

		bool IsProperty_F_C10_26_Removed { get; set; }

		bool IsProperty_F_C20_26_Removed { get; set; }

		bool IsProperty_F_C50_26_Removed { get; set; }

		bool IsProperty_F_B_27_Removed { get; set; }

		bool IsProperty_F_I_27_Removed { get; set; }

		bool IsProperty_F_L_27_Removed { get; set; }

		bool IsProperty_F_N_27_Removed { get; set; }

		bool IsProperty_F_C5_27_Removed { get; set; }

		bool IsProperty_F_C10_27_Removed { get; set; }

		bool IsProperty_F_C20_27_Removed { get; set; }

		bool IsProperty_F_C50_27_Removed { get; set; }

		bool IsProperty_F_B_28_Removed { get; set; }

		bool IsProperty_F_I_28_Removed { get; set; }

		bool IsProperty_F_L_28_Removed { get; set; }

		bool IsProperty_F_N_28_Removed { get; set; }

		bool IsProperty_F_C5_28_Removed { get; set; }

		bool IsProperty_F_C10_28_Removed { get; set; }

		bool IsProperty_F_C20_28_Removed { get; set; }

		bool IsProperty_F_C50_28_Removed { get; set; }

		bool IsProperty_F_B_29_Removed { get; set; }

		bool IsProperty_F_I_29_Removed { get; set; }

		bool IsProperty_F_L_29_Removed { get; set; }

		bool IsProperty_F_N_29_Removed { get; set; }

		bool IsProperty_F_C5_29_Removed { get; set; }

		bool IsProperty_F_C10_29_Removed { get; set; }

		bool IsProperty_F_C20_29_Removed { get; set; }

		bool IsProperty_F_C50_29_Removed { get; set; }

		bool IsProperty_F_B_30_Removed { get; set; }

		bool IsProperty_F_I_30_Removed { get; set; }

		bool IsProperty_F_N_30_Removed { get; set; }

		bool IsProperty_F_C5_30_Removed { get; set; }

		bool IsProperty_F_C10_30_Removed { get; set; }

		bool IsProperty_F_C20_30_Removed { get; set; }

		bool IsProperty_F_C50_30_Removed { get; set; }

		bool IsProperty_F_B_31_Removed { get; set; }

		bool IsProperty_F_I_31_Removed { get; set; }

		bool IsProperty_F_N_31_Removed { get; set; }

		bool IsProperty_F_C5_31_Removed { get; set; }

		bool IsProperty_F_C10_31_Removed { get; set; }

		bool IsProperty_F_C20_31_Removed { get; set; }

		bool IsProperty_F_C50_31_Removed { get; set; }

		bool IsProperty_F_B_32_Removed { get; set; }

		bool IsProperty_F_I_32_Removed { get; set; }

		bool IsProperty_F_N_32_Removed { get; set; }

		bool IsProperty_F_C5_32_Removed { get; set; }

		bool IsProperty_F_C10_32_Removed { get; set; }

		bool IsProperty_F_C20_32_Removed { get; set; }

		bool IsProperty_F_C50_32_Removed { get; set; }

		bool IsProperty_F_B_33_Removed { get; set; }

		bool IsProperty_F_I_33_Removed { get; set; }

		bool IsProperty_F_N_33_Removed { get; set; }

		bool IsProperty_F_C5_33_Removed { get; set; }

		bool IsProperty_F_C10_33_Removed { get; set; }

		bool IsProperty_F_C20_33_Removed { get; set; }

		bool IsProperty_F_C50_33_Removed { get; set; }

		bool IsProperty_F_B_34_Removed { get; set; }

		bool IsProperty_F_I_34_Removed { get; set; }

		bool IsProperty_F_N_34_Removed { get; set; }

		bool IsProperty_F_C5_34_Removed { get; set; }

		bool IsProperty_F_C10_34_Removed { get; set; }

		bool IsProperty_F_C20_34_Removed { get; set; }

		bool IsProperty_F_C50_34_Removed { get; set; }

		bool IsProperty_F_B_35_Removed { get; set; }

		bool IsProperty_F_I_35_Removed { get; set; }

		bool IsProperty_F_N_35_Removed { get; set; }

		bool IsProperty_F_C5_35_Removed { get; set; }

		bool IsProperty_F_C10_35_Removed { get; set; }

		bool IsProperty_F_C20_35_Removed { get; set; }

		bool IsProperty_F_C50_35_Removed { get; set; }

		bool IsProperty_F_B_36_Removed { get; set; }

		bool IsProperty_F_I_36_Removed { get; set; }

		bool IsProperty_F_N_36_Removed { get; set; }

		bool IsProperty_F_C5_36_Removed { get; set; }

		bool IsProperty_F_C10_36_Removed { get; set; }

		bool IsProperty_F_C20_36_Removed { get; set; }

		bool IsProperty_F_C50_36_Removed { get; set; }

		bool IsProperty_F_B_37_Removed { get; set; }

		bool IsProperty_F_I_37_Removed { get; set; }

		bool IsProperty_F_N_37_Removed { get; set; }

		bool IsProperty_F_C5_37_Removed { get; set; }

		bool IsProperty_F_C10_37_Removed { get; set; }

		bool IsProperty_F_C20_37_Removed { get; set; }

		bool IsProperty_F_C50_37_Removed { get; set; }

		bool IsProperty_F_B_38_Removed { get; set; }

		bool IsProperty_F_I_38_Removed { get; set; }

		bool IsProperty_F_N_38_Removed { get; set; }

		bool IsProperty_F_C5_38_Removed { get; set; }

		bool IsProperty_F_C10_38_Removed { get; set; }

		bool IsProperty_F_C20_38_Removed { get; set; }

		bool IsProperty_F_C50_38_Removed { get; set; }

		bool IsProperty_F_B_39_Removed { get; set; }

		bool IsProperty_F_I_39_Removed { get; set; }

		bool IsProperty_F_N_39_Removed { get; set; }

		bool IsProperty_F_C5_39_Removed { get; set; }

		bool IsProperty_F_C10_39_Removed { get; set; }

		bool IsProperty_F_C20_39_Removed { get; set; }

		bool IsProperty_F_C50_39_Removed { get; set; }

		bool IsProperty_F_B_40_Removed { get; set; }

		bool IsProperty_F_I_40_Removed { get; set; }

		bool IsProperty_F_N_40_Removed { get; set; }

		bool IsProperty_F_C5_40_Removed { get; set; }

		bool IsProperty_F_C10_40_Removed { get; set; }

		bool IsProperty_F_C20_40_Removed { get; set; }

		bool IsProperty_F_C50_40_Removed { get; set; }

		bool IsProperty_F_B_41_Removed { get; set; }

		bool IsProperty_F_I_41_Removed { get; set; }

		bool IsProperty_F_N_41_Removed { get; set; }

		bool IsProperty_F_C5_41_Removed { get; set; }

		bool IsProperty_F_C10_41_Removed { get; set; }

		bool IsProperty_F_C20_41_Removed { get; set; }

		bool IsProperty_F_C50_41_Removed { get; set; }

		bool IsProperty_F_B_42_Removed { get; set; }

		bool IsProperty_F_I_42_Removed { get; set; }

		bool IsProperty_F_N_42_Removed { get; set; }

		bool IsProperty_F_C5_42_Removed { get; set; }

		bool IsProperty_F_C10_42_Removed { get; set; }

		bool IsProperty_F_C20_42_Removed { get; set; }

		bool IsProperty_F_C50_42_Removed { get; set; }

		bool IsProperty_F_B_43_Removed { get; set; }

		bool IsProperty_F_I_43_Removed { get; set; }

		bool IsProperty_F_N_43_Removed { get; set; }

		bool IsProperty_F_C5_43_Removed { get; set; }

		bool IsProperty_F_C10_43_Removed { get; set; }

		bool IsProperty_F_C20_43_Removed { get; set; }

		bool IsProperty_F_C50_43_Removed { get; set; }

		bool IsProperty_F_B_44_Removed { get; set; }

		bool IsProperty_F_I_44_Removed { get; set; }

		bool IsProperty_F_N_44_Removed { get; set; }

		bool IsProperty_F_C5_44_Removed { get; set; }

		bool IsProperty_F_C10_44_Removed { get; set; }

		bool IsProperty_F_C20_44_Removed { get; set; }

		bool IsProperty_F_C50_44_Removed { get; set; }

		bool IsProperty_F_B_45_Removed { get; set; }

		bool IsProperty_F_I_45_Removed { get; set; }

		bool IsProperty_F_N_45_Removed { get; set; }

		bool IsProperty_F_C5_45_Removed { get; set; }

		bool IsProperty_F_C10_45_Removed { get; set; }

		bool IsProperty_F_C20_45_Removed { get; set; }

		bool IsProperty_F_C50_45_Removed { get; set; }

		bool IsProperty_F_B_46_Removed { get; set; }

		bool IsProperty_F_I_46_Removed { get; set; }

		bool IsProperty_F_N_46_Removed { get; set; }

		bool IsProperty_F_C5_46_Removed { get; set; }

		bool IsProperty_F_C10_46_Removed { get; set; }

		bool IsProperty_F_C20_46_Removed { get; set; }

		bool IsProperty_F_C50_46_Removed { get; set; }

		bool IsProperty_F_B_47_Removed { get; set; }

		bool IsProperty_F_I_47_Removed { get; set; }

		bool IsProperty_F_N_47_Removed { get; set; }

		bool IsProperty_F_C5_47_Removed { get; set; }

		bool IsProperty_F_C10_47_Removed { get; set; }

		bool IsProperty_F_C20_47_Removed { get; set; }

		bool IsProperty_F_C50_47_Removed { get; set; }

		bool IsProperty_F_B_48_Removed { get; set; }

		bool IsProperty_F_I_48_Removed { get; set; }

		bool IsProperty_F_N_48_Removed { get; set; }

		bool IsProperty_F_C5_48_Removed { get; set; }

		bool IsProperty_F_C10_48_Removed { get; set; }

		bool IsProperty_F_C20_48_Removed { get; set; }

		bool IsProperty_F_C50_48_Removed { get; set; }

		bool IsProperty_F_B_49_Removed { get; set; }

		bool IsProperty_F_I_49_Removed { get; set; }

		bool IsProperty_F_N_49_Removed { get; set; }

		bool IsProperty_F_C5_49_Removed { get; set; }

		bool IsProperty_F_C10_49_Removed { get; set; }

		bool IsProperty_F_C20_49_Removed { get; set; }

		bool IsProperty_F_C50_49_Removed { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IAttributeSetInstanceStateDeleted : IAttributeSetInstanceStateEvent
	{
	}


}


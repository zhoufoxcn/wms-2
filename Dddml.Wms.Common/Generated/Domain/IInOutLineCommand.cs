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
	public interface IInOutLineCommand : ICommand, ICommandDto
	{
		// Outer Id:

		string InOutDocumentNumber { get; set; }

		long LineNumber { get; set; }

	}


	public interface ICreateOrMergePatchOrRemoveInOutLine : IInOutLineCommand
	{

		string Description { get; set; }

		string LocatorId { get; set; }

		string ProductId { get; set; }

		string UomId { get; set; }

		decimal? MovementQuantity { get; set; }

		decimal? ConfirmedQuantity { get; set; }

		decimal? ScrappedQuantity { get; set; }

		decimal? TargetQuantity { get; set; }

		decimal? PickedQuantity { get; set; }

		bool? IsInvoiced { get; set; }

		string AttributeSetInstanceId { get; set; }

		bool? IsDescription { get; set; }

		bool? Processed { get; set; }

		decimal? QuantityEntered { get; set; }

		long? RmaLineNumber { get; set; }

		long? ReversalLineNumber { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateInOutLine : ICreateOrMergePatchOrRemoveInOutLine
	{
	}

	public interface IMergePatchInOutLine : ICreateOrMergePatchOrRemoveInOutLine
	{

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyLocatorIdRemoved { get; set; }

		bool IsPropertyProductIdRemoved { get; set; }

		bool IsPropertyUomIdRemoved { get; set; }

		bool IsPropertyMovementQuantityRemoved { get; set; }

		bool IsPropertyConfirmedQuantityRemoved { get; set; }

		bool IsPropertyScrappedQuantityRemoved { get; set; }

		bool IsPropertyTargetQuantityRemoved { get; set; }

		bool IsPropertyPickedQuantityRemoved { get; set; }

		bool IsPropertyIsInvoicedRemoved { get; set; }

		bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		bool IsPropertyIsDescriptionRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyQuantityEnteredRemoved { get; set; }

		bool IsPropertyRmaLineNumberRemoved { get; set; }

		bool IsPropertyReversalLineNumberRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IRemoveInOutLine : ICreateOrMergePatchOrRemoveInOutLine
	{
	}


}


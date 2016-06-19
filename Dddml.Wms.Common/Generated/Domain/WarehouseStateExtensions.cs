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

	public static partial class WarehouseStateExtensions
	{

        public static IWarehouseCommand ToCreateOrMergePatchWarehouse(this WarehouseState state)
        {
            bool bUnsaved = ((IWarehouseState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateWarehouse();
            }
            else 
            {
                return state.ToMergePatchWarehouse();
            }
        }

        public static DeleteWarehouse ToDeleteWarehouse(this WarehouseState state)
        {
            var cmd = new DeleteWarehouse();
            cmd.WarehouseId = state.WarehouseId;
            cmd.Version = state.Version;

            return cmd;
        }

        public static MergePatchWarehouse ToMergePatchWarehouse(this WarehouseState state)
        {
            var cmd = new MergePatchWarehouse();

            cmd.Version = state.Version;

            cmd.WarehouseId = state.WarehouseId;
            cmd.Name = state.Name;
            cmd.Description = state.Description;
            cmd.IsInTransit = state.IsInTransit;
            cmd.Active = state.Active;
            
            if (state.Name == null) { cmd.IsPropertyNameRemoved = true; }
            if (state.Description == null) { cmd.IsPropertyDescriptionRemoved = true; }
            return cmd;
        }

        public static CreateWarehouse ToCreateWarehouse(this WarehouseState state)
        {
            var cmd = new CreateWarehouse();

            cmd.Version = state.Version;

            cmd.WarehouseId = state.WarehouseId;
            cmd.Name = state.Name;
            cmd.Description = state.Description;
            cmd.IsInTransit = state.IsInTransit;
            cmd.Active = state.Active;
            return cmd;
        }
		

	}

}


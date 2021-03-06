﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldUtils.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using Dddml.Wms.Specialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;

namespace Dddml.Wms.Support
{
    public static class AttributeSetInstanceExtensionFieldUtils
    {

        public static CreateAttributeSetInstanceExtensionFieldGroup[] CreateAttributeSetInstanceExtensionFieldGroups()
        {
            var groups = new CreateAttributeSetInstanceExtensionFieldGroup[]{
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_B_",
                    FieldType = typeof(bool).Name,
                    FieldLength = null,
                    FieldCount = 50,
                    NameFormat = "_F_B_{0}_",
                    Active = true
                },
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_I_",
                    FieldType = typeof(int).Name,
                    FieldLength = null,
                    FieldCount = 50,
                    NameFormat = "_F_I_{0}_",
                    Active = true
                },
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_L_",
                    FieldType = typeof(long).Name,
                    FieldLength = null,
                    FieldCount = 30,
                    NameFormat = "_F_L_{0}_",
                    Active = true
                },
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_DT_",
                    FieldType = typeof(DateTime).Name,
                    FieldLength = null,
                    FieldCount = 20,
                    NameFormat = "_F_DT_{0}_",
                    Active = true
                },
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_N_",
                    FieldType = typeof(decimal).Name,
                    FieldLength = null,
                    FieldCount = 50,
                    NameFormat = "_F_N_{0}_",
                    Active = true
                },
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_C5_",
                    FieldType = typeof(string).Name,
                    FieldLength = 5,
                    FieldCount = 50,
                    NameFormat = "_F_C5_{0}_",
                    Active = true
                },
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_C10_",
                    FieldType = typeof(string).Name,
                    FieldLength = 10,
                    FieldCount = 50,
                    NameFormat = "_F_C10_{0}_",
                    Active = true
                },
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_C20_",
                    FieldType = typeof(string).Name,
                    FieldLength = 20,
                    FieldCount = 50,
                    NameFormat = "_F_C20_{0}_",
                    Active = true
                },
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_C50_",
                    FieldType = typeof(string).Name,
                    FieldLength = 50,
                    FieldCount = 50,
                    NameFormat = "_F_C50_{0}_",
                    Active = true
                },
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_C100_",
                    FieldType = typeof(string).Name,
                    FieldLength = 100,
                    FieldCount = 20,
                    NameFormat = "_F_C100_{0}_",
                    Active = true
                },
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_C200_",
                    FieldType = typeof(string).Name,
                    FieldLength = 200,
                    FieldCount = 20,
                    NameFormat = "_F_C200_{0}_",
                    Active = true
                },
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_C500_",
                    FieldType = typeof(string).Name,
                    FieldLength = 500,
                    FieldCount = 10,
                    NameFormat = "_F_C500_{0}_",
                    Active = true
                },
                new CreateAttributeSetInstanceExtensionFieldGroup
                {
                    Id = "_F_C1000_",
                    FieldType = typeof(string).Name,
                    FieldLength = 1000,
                    FieldCount = 5,
                    NameFormat = "_F_C1000_{0}_",
                    Active = true
                },
            };

            foreach (var g in groups)
            {
                for (int i = 0; i < g.FieldCount; i++)
                {
                    var field = g.NewCreateAttributeSetInstanceExtensionField();
                    field.Index = i.ToString();
                    field.Name = String.Format(g.NameFormat, i);
                    field.Type = g.FieldType;
                    field.Length = g.FieldLength;
                    field.Active = true;
                    g.Fields.Add(field);
                }
            }

            return groups;

        }

    }
}



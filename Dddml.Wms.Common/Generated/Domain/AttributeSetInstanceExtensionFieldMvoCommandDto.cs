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

	public abstract class AttributeSetInstanceExtensionFieldMvoCommandDtoBase : ICommandDto, ICreateAttributeSetInstanceExtensionFieldMvo, IMergePatchAttributeSetInstanceExtensionFieldMvo, IDeleteAttributeSetInstanceExtensionFieldMvo
	{

		AttributeSetInstanceExtensionFieldId IAggregateCommand<AttributeSetInstanceExtensionFieldId, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldMvo)this).AttributeSetInstanceExtensionFieldId;
			}
		}


		long IAggregateCommand<AttributeSetInstanceExtensionFieldId, long>.AggregateVersion
		{
			get
			{
				return this.AttrSetInstEFGroupVersion;
			}
		}

		public virtual long AttrSetInstEFGroupVersion { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual AttributeSetInstanceExtensionFieldIdDto AttributeSetInstanceExtensionFieldId { get; set; }

		public virtual string Name { get; set; }

		public virtual string Type { get; set; }

		public virtual int? Length { get; set; }

		public virtual string Alias { get; set; }

		public virtual string Description { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string AttrSetInstEFGroupFieldType { get; set; }

		public virtual int? AttrSetInstEFGroupFieldLength { get; set; }

		public virtual int? AttrSetInstEFGroupFieldCount { get; set; }

		public virtual string AttrSetInstEFGroupNameFormat { get; set; }

		public virtual string AttrSetInstEFGroupDescription { get; set; }

		public virtual string AttrSetInstEFGroupCreatedBy { get; set; }

		public virtual DateTime? AttrSetInstEFGroupCreatedAt { get; set; }

		public virtual string AttrSetInstEFGroupUpdatedBy { get; set; }

		public virtual DateTime? AttrSetInstEFGroupUpdatedAt { get; set; }

		public virtual bool? AttrSetInstEFGroupActive { get; set; }

		public virtual bool? AttrSetInstEFGroupDeleted { get; set; }


        AttributeSetInstanceExtensionFieldId ICreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldMvo.AttributeSetInstanceExtensionFieldId
        {
            get 
            {
                return this.AttributeSetInstanceExtensionFieldId.ToAttributeSetInstanceExtensionFieldId();
            }
            set 
            {
                this.AttributeSetInstanceExtensionFieldId = new AttributeSetInstanceExtensionFieldIdDto(value);
            }
        }

		public virtual bool? IsPropertyNameRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyNameRemoved
        {
            get
            {
                var b = this.IsPropertyNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyTypeRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyTypeRemoved
        {
            get
            {
                var b = this.IsPropertyTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyLengthRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyLengthRemoved
        {
            get
            {
                var b = this.IsPropertyLengthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyLengthRemoved = value;
            }
        }

		public virtual bool? IsPropertyAliasRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyAliasRemoved
        {
            get
            {
                var b = this.IsPropertyAliasRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAliasRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyVersionRemoved
        {
            get
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttrSetInstEFGroupFieldTypeRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyAttrSetInstEFGroupFieldTypeRemoved
        {
            get
            {
                var b = this.IsPropertyAttrSetInstEFGroupFieldTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttrSetInstEFGroupFieldTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttrSetInstEFGroupFieldLengthRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyAttrSetInstEFGroupFieldLengthRemoved
        {
            get
            {
                var b = this.IsPropertyAttrSetInstEFGroupFieldLengthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttrSetInstEFGroupFieldLengthRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttrSetInstEFGroupFieldCountRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyAttrSetInstEFGroupFieldCountRemoved
        {
            get
            {
                var b = this.IsPropertyAttrSetInstEFGroupFieldCountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttrSetInstEFGroupFieldCountRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttrSetInstEFGroupNameFormatRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyAttrSetInstEFGroupNameFormatRemoved
        {
            get
            {
                var b = this.IsPropertyAttrSetInstEFGroupNameFormatRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttrSetInstEFGroupNameFormatRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttrSetInstEFGroupDescriptionRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyAttrSetInstEFGroupDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyAttrSetInstEFGroupDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttrSetInstEFGroupDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttrSetInstEFGroupCreatedByRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyAttrSetInstEFGroupCreatedByRemoved
        {
            get
            {
                var b = this.IsPropertyAttrSetInstEFGroupCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttrSetInstEFGroupCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttrSetInstEFGroupCreatedAtRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyAttrSetInstEFGroupCreatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyAttrSetInstEFGroupCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttrSetInstEFGroupCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttrSetInstEFGroupUpdatedByRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyAttrSetInstEFGroupUpdatedByRemoved
        {
            get
            {
                var b = this.IsPropertyAttrSetInstEFGroupUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttrSetInstEFGroupUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttrSetInstEFGroupUpdatedAtRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyAttrSetInstEFGroupUpdatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyAttrSetInstEFGroupUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttrSetInstEFGroupUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttrSetInstEFGroupActiveRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyAttrSetInstEFGroupActiveRemoved
        {
            get
            {
                var b = this.IsPropertyAttrSetInstEFGroupActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttrSetInstEFGroupActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttrSetInstEFGroupDeletedRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldMvo.IsPropertyAttrSetInstEFGroupDeletedRemoved
        {
            get
            {
                var b = this.IsPropertyAttrSetInstEFGroupDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttrSetInstEFGroupDeletedRemoved = value;
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldMvoDto : AttributeSetInstanceExtensionFieldMvoCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateAttributeSetInstanceExtensionFieldMvoDto : CreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchAttributeSetInstanceExtensionFieldMvoDto : CreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteAttributeSetInstanceExtensionFieldMvoDto : CreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldMvoDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}





}


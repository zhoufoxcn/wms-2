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

	public abstract class AttributeSetInstanceCommandDtoBase : ICommandDto, ICreateAttributeSetInstance, IMergePatchAttributeSetInstance, IDeleteAttributeSetInstance
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return (this as IAttributeSetInstanceStateProperties).AttributeSetInstanceId;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

		public virtual string RequesterId { get; set; }//TODO RequesterId 应该是可以支持自定义名称

		public virtual string CommandId { get; set; }//TODO CommandId 太特殊了！！！应该可以支持自定义名称（即不一定要叫 CommandId）

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

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual string AttributeSetId { get; set; }

		public virtual string SerialNumber { get; set; }

		public virtual string Lot { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

        bool IAttributeSetInstanceStateProperties.Active
        {
            get 
            {
                var b = this.Active;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.Active = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetIdRemoved { get; set; }

        bool IMergePatchAttributeSetInstance.IsPropertyAttributeSetIdRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeSetIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeSetIdRemoved = value;
            }
        }

		public virtual bool? IsPropertySerialNumberRemoved { get; set; }

        bool IMergePatchAttributeSetInstance.IsPropertySerialNumberRemoved
        {
            get
            {
                var b = this.IsPropertySerialNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertySerialNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyLotRemoved { get; set; }

        bool IMergePatchAttributeSetInstance.IsPropertyLotRemoved
        {
            get
            {
                var b = this.IsPropertyLotRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyLotRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMergePatchAttributeSetInstance.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchAttributeSetInstance.IsPropertyActiveRemoved
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


        // //////////////////////////////////////////////

        private IAttributeSetInstanceCommand _innerCommand;

        public virtual ICommand ToCommand()
        {
            //if (this._innerCommand != null)
            //{
                //return this._innerCommand;
            //}
            var cmdType = GetCommandType();
            if (cmdType == CommandType.Create)
            {
                var cmd = ToCreateAttributeSetInstance();
                this._innerCommand = cmd;
            }
            else if (cmdType == CommandType.MergePatch)
            {
                var cmd = ToMergePatchAttributeSetInstance();
                this._innerCommand = cmd;
            }
            else if (cmdType == CommandType.Delete)
            {
                var cmd = ToDeleteAttributeSetInstance();
                this._innerCommand = cmd;
            }
            else
            {
                throw DomainError.Named("invalidCommandType", String.Format("Invalid command type: {0}", cmdType));
            }
            return this._innerCommand;
        }

        internal DeleteAttributeSetInstance ToDeleteAttributeSetInstance()
        {
            var cmd = new DeleteAttributeSetInstance();
            cmd.CommandId = this.CommandId;
            cmd.RequesterId = this.RequesterId;

            cmd.AttributeSetInstanceId = (this as IAttributeSetInstanceStateProperties).AttributeSetInstanceId;
            cmd.Version = this.Version;

            return cmd;
        }

        internal MergePatchAttributeSetInstance ToMergePatchAttributeSetInstance()
        {
            var cmd = new MergePatchAttributeSetInstance();
            cmd.CommandId = this.CommandId;
            cmd.RequesterId = this.RequesterId;

            cmd.Version = this.Version;

            cmd.AttributeSetInstanceId = (this as IAttributeSetInstanceStateProperties).AttributeSetInstanceId;
            cmd.AttributeSetId = (this as IAttributeSetInstanceStateProperties).AttributeSetId;
            cmd.SerialNumber = (this as IAttributeSetInstanceStateProperties).SerialNumber;
            cmd.Lot = (this as IAttributeSetInstanceStateProperties).Lot;
            cmd.Description = (this as IAttributeSetInstanceStateProperties).Description;
            cmd.Active = (this as IAttributeSetInstanceStateProperties).Active;
            
            cmd.IsPropertyAttributeSetIdRemoved = (this as IMergePatchAttributeSetInstance).IsPropertyAttributeSetIdRemoved;
            cmd.IsPropertySerialNumberRemoved = (this as IMergePatchAttributeSetInstance).IsPropertySerialNumberRemoved;
            cmd.IsPropertyLotRemoved = (this as IMergePatchAttributeSetInstance).IsPropertyLotRemoved;
            cmd.IsPropertyDescriptionRemoved = (this as IMergePatchAttributeSetInstance).IsPropertyDescriptionRemoved;
            cmd.IsPropertyActiveRemoved = (this as IMergePatchAttributeSetInstance).IsPropertyActiveRemoved;
            return cmd;
        }

        internal CreateAttributeSetInstance ToCreateAttributeSetInstance()
        {
            var cmd = new CreateAttributeSetInstance();
            cmd.CommandId = this.CommandId;
            cmd.RequesterId = this.RequesterId;

            cmd.Version = this.Version;

            cmd.AttributeSetInstanceId = (this as IAttributeSetInstanceStateProperties).AttributeSetInstanceId;
            cmd.AttributeSetId = (this as IAttributeSetInstanceStateProperties).AttributeSetId;
            cmd.SerialNumber = (this as IAttributeSetInstanceStateProperties).SerialNumber;
            cmd.Lot = (this as IAttributeSetInstanceStateProperties).Lot;
            cmd.Description = (this as IAttributeSetInstanceStateProperties).Description;
            cmd.Active = (this as IAttributeSetInstanceStateProperties).Active;
            return cmd;
        }

        // //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteAttributeSetInstanceDto : AttributeSetInstanceCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            //TODO (Command Type）的名称应该允许自定义
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateAttributeSetInstanceDto : CreateOrMergePatchOrDeleteAttributeSetInstanceDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				//base.CommandType = value; 
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchAttributeSetInstanceDto : CreateOrMergePatchOrDeleteAttributeSetInstanceDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				//base.CommandType = value; 
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteAttributeSetInstanceDto : CreateOrMergePatchOrDeleteAttributeSetInstanceDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				//base.CommandType = value; 
            }
        }

	}





}


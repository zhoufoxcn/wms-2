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

	public abstract class AttributeSetInstanceExtensionFieldCommandDtoBase : ICommandDto, ICreateAttributeSetInstanceExtensionField, IMergePatchAttributeSetInstanceExtensionField, IRemoveAttributeSetInstanceExtensionField
	{

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

		public virtual string Index { get; set; }

		public virtual string Name { get; set; }

		public virtual string Type { get; set; }

		public virtual int? Length { get; set; }

		public virtual string Alias { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string GroupId { get; set; }

		public virtual bool? IsPropertyNameRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionField.IsPropertyNameRemoved
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

        bool IMergePatchAttributeSetInstanceExtensionField.IsPropertyTypeRemoved
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

        bool IMergePatchAttributeSetInstanceExtensionField.IsPropertyLengthRemoved
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

        bool IMergePatchAttributeSetInstanceExtensionField.IsPropertyAliasRemoved
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

        bool IMergePatchAttributeSetInstanceExtensionField.IsPropertyDescriptionRemoved
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

        bool IMergePatchAttributeSetInstanceExtensionField.IsPropertyActiveRemoved
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

        private IAttributeSetInstanceExtensionFieldCommand _innerCommand;

        internal ICommand ToCommand()//public virtual
        {
            //if (this._innerCommand != null)
            //{
                //return this._innerCommand;
            //}
            var cmdType = GetCommandType();
            if (cmdType == CommandType.Create)
            {
                var cmd = ToCreateAttributeSetInstanceExtensionField();
                this._innerCommand = cmd;
            }
            else if (cmdType == CommandType.MergePatch)
            {
                var cmd = ToMergePatchAttributeSetInstanceExtensionField();
                this._innerCommand = cmd;
            }
            else if (cmdType == CommandType.Remove)
            {
                var cmd = ToRemoveAttributeSetInstanceExtensionField();
                this._innerCommand = cmd;
            }
            else
            {
                throw DomainError.Named("invalidCommandType", String.Format("Invalid command type: {0}", cmdType));
            }
            return this._innerCommand;
        }

        private RemoveAttributeSetInstanceExtensionField ToRemoveAttributeSetInstanceExtensionField()
        {
            var cmd = new RemoveAttributeSetInstanceExtensionField();
            cmd.CommandId = this.CommandId;
            cmd.RequesterId = this.RequesterId;

            cmd.Index = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Index;
            return cmd;
        }

        internal MergePatchAttributeSetInstanceExtensionField ToMergePatchAttributeSetInstanceExtensionField()
        {
            var cmd = new MergePatchAttributeSetInstanceExtensionField();
            cmd.CommandId = this.CommandId;
            cmd.RequesterId = this.RequesterId;

            cmd.Index = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Index;
            cmd.Name = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Name;
            cmd.Type = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Type;
            cmd.Length = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Length;
            cmd.Alias = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Alias;
            cmd.Description = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Description;
            cmd.Active = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Active;
            cmd.GroupId = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).GroupId;
            
            cmd.IsPropertyNameRemoved = (this as IMergePatchAttributeSetInstanceExtensionField).IsPropertyNameRemoved;
            cmd.IsPropertyTypeRemoved = (this as IMergePatchAttributeSetInstanceExtensionField).IsPropertyTypeRemoved;
            cmd.IsPropertyLengthRemoved = (this as IMergePatchAttributeSetInstanceExtensionField).IsPropertyLengthRemoved;
            cmd.IsPropertyAliasRemoved = (this as IMergePatchAttributeSetInstanceExtensionField).IsPropertyAliasRemoved;
            cmd.IsPropertyDescriptionRemoved = (this as IMergePatchAttributeSetInstanceExtensionField).IsPropertyDescriptionRemoved;
            cmd.IsPropertyActiveRemoved = (this as IMergePatchAttributeSetInstanceExtensionField).IsPropertyActiveRemoved;
            return cmd;
        }

        internal CreateAttributeSetInstanceExtensionField ToCreateAttributeSetInstanceExtensionField()
        {
            var cmd = new CreateAttributeSetInstanceExtensionField();
            cmd.CommandId = this.CommandId;
            cmd.RequesterId = this.RequesterId;

            cmd.Index = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Index;
            cmd.Name = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Name;
            cmd.Type = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Type;
            cmd.Length = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Length;
            cmd.Alias = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Alias;
            cmd.Description = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Description;
            cmd.Active = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).Active;
            cmd.GroupId = ((ICreateOrMergePatchOrRemoveAttributeSetInstanceExtensionField)this).GroupId;
            return cmd;
        }

        // //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto : AttributeSetInstanceExtensionFieldCommandDtoBase
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



	public class CreateAttributeSetInstanceExtensionFieldDto : CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto
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


	public class MergePatchAttributeSetInstanceExtensionFieldDto : CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto
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

	public class RemoveAttributeSetInstanceExtensionFieldDto : CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Remove;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}


    public partial class CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDtos : IAttributeSetInstanceExtensionFieldCommands, ICreateAttributeSetInstanceExtensionFieldCommands, IEnumerable<CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto>
    {
        private List<CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto> _innerCommands = new List<CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto>();

        public virtual CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto[] ToArray()
        {
            return _innerCommands.ToArray();
        }

        public virtual void Clear()
        {
            _innerCommands.Clear();
        }

        public virtual void AddRange(IEnumerable<CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto> cs)
        {
            _innerCommands.AddRange(cs);
        }

        void IAttributeSetInstanceExtensionFieldCommands.Add(IAttributeSetInstanceExtensionFieldCommand c)
        {
            _innerCommands.Add((CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto)c);
        }

        void IAttributeSetInstanceExtensionFieldCommands.Remove(IAttributeSetInstanceExtensionFieldCommand c)
        {
            _innerCommands.Remove((CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto)c);
        }


        IEnumerator<CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto> IEnumerable<CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        IEnumerator<IAttributeSetInstanceExtensionFieldCommand> IEnumerable<IAttributeSetInstanceExtensionFieldCommand>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        void ICreateAttributeSetInstanceExtensionFieldCommands.Add(ICreateAttributeSetInstanceExtensionField c)
        {
            _innerCommands.Add((CreateAttributeSetInstanceExtensionFieldDto)c);
        }

        void ICreateAttributeSetInstanceExtensionFieldCommands.Remove(ICreateAttributeSetInstanceExtensionField c)
        {
            _innerCommands.Remove((CreateAttributeSetInstanceExtensionFieldDto)c);
        }

        IEnumerator<ICreateAttributeSetInstanceExtensionField> IEnumerable<ICreateAttributeSetInstanceExtensionField>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }






}


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

	public abstract class AttributeValueCommandDtoBase : ICommandDto, ICreateAttributeValue, IMergePatchAttributeValue, IRemoveAttributeValue
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

		public virtual string Value { get; set; }

		public virtual string Name { get; set; }

		public virtual string Description { get; set; }

		public virtual string ReferenceId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string AttributeId { get; set; }

		public virtual bool? IsPropertyNameRemoved { get; set; }

        bool IMergePatchAttributeValue.IsPropertyNameRemoved
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

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMergePatchAttributeValue.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyReferenceIdRemoved { get; set; }

        bool IMergePatchAttributeValue.IsPropertyReferenceIdRemoved
        {
            get
            {
                var b = this.IsPropertyReferenceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyReferenceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchAttributeValue.IsPropertyActiveRemoved
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


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrRemoveAttributeValueDto : AttributeValueCommandDtoBase
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



	public class CreateAttributeValueDto : CreateOrMergePatchOrRemoveAttributeValueDto
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


	public class MergePatchAttributeValueDto : CreateOrMergePatchOrRemoveAttributeValueDto
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

	public class RemoveAttributeValueDto : CreateOrMergePatchOrRemoveAttributeValueDto
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


    public partial class CreateOrMergePatchOrRemoveAttributeValueDtos : IAttributeValueCommands, ICreateAttributeValueCommands, IEnumerable<CreateOrMergePatchOrRemoveAttributeValueDto>
    {
        private List<CreateOrMergePatchOrRemoveAttributeValueDto> _innerCommands = new List<CreateOrMergePatchOrRemoveAttributeValueDto>();

        public virtual CreateOrMergePatchOrRemoveAttributeValueDto[] ToArray()
        {
            return _innerCommands.ToArray();
        }

        public virtual void Clear()
        {
            _innerCommands.Clear();
        }

        public virtual void AddRange(IEnumerable<CreateOrMergePatchOrRemoveAttributeValueDto> cs)
        {
            _innerCommands.AddRange(cs);
        }

        void IAttributeValueCommands.Add(IAttributeValueCommand c)
        {
            _innerCommands.Add((CreateOrMergePatchOrRemoveAttributeValueDto)c);
        }

        void IAttributeValueCommands.Remove(IAttributeValueCommand c)
        {
            _innerCommands.Remove((CreateOrMergePatchOrRemoveAttributeValueDto)c);
        }


        IEnumerator<CreateOrMergePatchOrRemoveAttributeValueDto> IEnumerable<CreateOrMergePatchOrRemoveAttributeValueDto>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        IEnumerator<IAttributeValueCommand> IEnumerable<IAttributeValueCommand>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        void ICreateAttributeValueCommands.Add(ICreateAttributeValue c)
        {
            _innerCommands.Add((CreateAttributeValueDto)c);
        }

        void ICreateAttributeValueCommands.Remove(ICreateAttributeValue c)
        {
            _innerCommands.Remove((CreateAttributeValueDto)c);
        }

        IEnumerator<ICreateAttributeValue> IEnumerable<ICreateAttributeValue>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }






}


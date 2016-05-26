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

	public abstract class AttributeSetInstanceExtensionFieldGroupCommandBase : AttributeSetInstanceExtensionFieldGroupStateProperties, IAttributeSetInstanceExtensionFieldGroupCommand
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.Id;
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

	}

    public abstract class AttributeSetInstanceExtensionFieldGroupIdGeneratorBase : IIdGenerator<string, ICreateAttributeSetInstanceExtensionFieldGroup>
    {
        public abstract string GenerateId(ICreateAttributeSetInstanceExtensionFieldGroup command);

        public abstract string GetNextId();

        public virtual string GetOrGenerateId(ICreateAttributeSetInstanceExtensionFieldGroup command, out bool reused)
        {
            throw new NotSupportedException();
        }

    }

	public class CreateAttributeSetInstanceExtensionFieldGroup : AttributeSetInstanceExtensionFieldGroupCommandBase, ICreateAttributeSetInstanceExtensionFieldGroup
	{
		
		public CreateAttributeSetInstanceExtensionFieldGroup ()
		{
		}


        private CreateAttributeSetInstanceExtensionFieldCommands _fields = new CreateAttributeSetInstanceExtensionFieldCommands();

        public ICreateAttributeSetInstanceExtensionFieldCommands Fields
        {
            get
            {
                return this._fields;
            }
        }

        public CreateAttributeSetInstanceExtensionField NewCreateAttributeSetInstanceExtensionField()
        {
            var c = new CreateAttributeSetInstanceExtensionField();
            c.GroupId = this.Id;

            return c;
        }

        ICreateAttributeSetInstanceExtensionField ICreateAttributeSetInstanceExtensionFieldGroup.NewCreateAttributeSetInstanceExtensionField()
        {
            return this.NewCreateAttributeSetInstanceExtensionField();
        }



	}


	public class MergePatchAttributeSetInstanceExtensionFieldGroup :AttributeSetInstanceExtensionFieldGroupCommandBase, IMergePatchAttributeSetInstanceExtensionFieldGroup
	{

		public virtual bool IsPropertyFieldTypeRemoved { get; set; }

		public virtual bool IsPropertyFieldLengthRemoved { get; set; }

		public virtual bool IsPropertyFieldCountRemoved { get; set; }

		public virtual bool IsPropertyNameFormatRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchAttributeSetInstanceExtensionFieldGroup ()
		{
		}

        private AttributeSetInstanceExtensionFieldCommands _attributeSetInstanceExtensionFieldCommands = new AttributeSetInstanceExtensionFieldCommands();

        public IAttributeSetInstanceExtensionFieldCommands AttributeSetInstanceExtensionFieldCommands
        {
            get
            {
                return this._attributeSetInstanceExtensionFieldCommands;
            }
        }


        public CreateAttributeSetInstanceExtensionField NewCreateAttributeSetInstanceExtensionField()
        {
            var c = new CreateAttributeSetInstanceExtensionField();
            c.GroupId = this.Id;

            return c;
        }

        ICreateAttributeSetInstanceExtensionField IMergePatchAttributeSetInstanceExtensionFieldGroup.NewCreateAttributeSetInstanceExtensionField()
        {
            return this.NewCreateAttributeSetInstanceExtensionField();
        }

        public MergePatchAttributeSetInstanceExtensionField NewMergePatchAttributeSetInstanceExtensionField()
        {
            var c = new MergePatchAttributeSetInstanceExtensionField();
            c.GroupId = this.Id;

            return c;
        }

        IMergePatchAttributeSetInstanceExtensionField IMergePatchAttributeSetInstanceExtensionFieldGroup.NewMergePatchAttributeSetInstanceExtensionField()
        {
            return this.NewMergePatchAttributeSetInstanceExtensionField();
        }


        public RemoveAttributeSetInstanceExtensionField NewRemoveAttributeSetInstanceExtensionField()
        {
            var c = new RemoveAttributeSetInstanceExtensionField();
            c.GroupId = this.Id;

            return c;
        }

        IRemoveAttributeSetInstanceExtensionField IMergePatchAttributeSetInstanceExtensionFieldGroup.NewRemoveAttributeSetInstanceExtensionField()
        {
            return this.NewRemoveAttributeSetInstanceExtensionField();
        }



	}

	public class DeleteAttributeSetInstanceExtensionFieldGroup : AttributeSetInstanceExtensionFieldGroupCommandBase, IDeleteAttributeSetInstanceExtensionFieldGroup
	{
		public DeleteAttributeSetInstanceExtensionFieldGroup ()
		{
		}
	}


    public class CreateAttributeSetInstanceExtensionFieldCommands : ICreateAttributeSetInstanceExtensionFieldCommands
    {
        private List<ICreateAttributeSetInstanceExtensionField> _innerCommands = new List<ICreateAttributeSetInstanceExtensionField>();

        public void Add(ICreateAttributeSetInstanceExtensionField c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(ICreateAttributeSetInstanceExtensionField c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<ICreateAttributeSetInstanceExtensionField> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public class AttributeSetInstanceExtensionFieldCommands : IAttributeSetInstanceExtensionFieldCommands
    {
        private List<IAttributeSetInstanceExtensionFieldCommand> _innerCommands = new List<IAttributeSetInstanceExtensionFieldCommand>();

        public void Add(IAttributeSetInstanceExtensionFieldCommand c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(IAttributeSetInstanceExtensionFieldCommand c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<IAttributeSetInstanceExtensionFieldCommand> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }




}

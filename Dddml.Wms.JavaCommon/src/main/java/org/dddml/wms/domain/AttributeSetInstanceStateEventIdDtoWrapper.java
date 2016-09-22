package org.dddml.wms.domain;


public class AttributeSetInstanceStateEventIdDtoWrapper extends AttributeSetInstanceStateEventIdDto
{
	
    private AttributeSetInstanceStateEventId value;

    public AttributeSetInstanceStateEventIdDtoWrapper()
    {
        this(new AttributeSetInstanceStateEventId());
    }

    public AttributeSetInstanceStateEventIdDtoWrapper(AttributeSetInstanceStateEventId value)
    {
        this.value = value;
    }

    public AttributeSetInstanceStateEventId toAttributeSetInstanceStateEventId()
    {
        return this.value;
    }

    @Override
    public String getAttributeSetInstanceId()
    {
        return this.value.getAttributeSetInstanceId();
    }

    @Override
    public void setAttributeSetInstanceId(String attributeSetInstanceId)
    {
        this.value.setAttributeSetInstanceId(attributeSetInstanceId);
    }

    @Override
    public Long getVersion()
    {
        return this.value.getVersion();
    }

    @Override
    public void setVersion(Long version)
    {
        this.value.setVersion(version);
    }


    @Override
    public boolean equals(Object obj)
    {
        if (obj == this) {
            return true;
        }
        if (obj == null) {
            return false;
        }
        if (obj.getClass() == AttributeSetInstanceStateEventIdDto.class) {
            return super.equals(obj);
        }
        if (obj.getClass() != this.getClass()) {
            return false;
        }

        AttributeSetInstanceStateEventIdDtoWrapper other = (AttributeSetInstanceStateEventIdDtoWrapper)obj;
        return value.equals(other.value);
    }

    //@Override
    //public int hashCode()
    //{
    //    return value.hashCode();
    //}

}

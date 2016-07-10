﻿<?php

namespace Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Wms\Domain\AttributeSetInstanceExtensionFieldId;
use Wms\Domain\AttributeSetInstanceExtensionField;
use Wms\Domain\CommandTrait;

class CreateOrMergePatchAttributeSetInstanceExtensionFieldMvo extends AbstractAttributeSetInstanceExtensionFieldMvoCommand
{

    use AttributeSetInstanceExtensionFieldMvoIsPropertyRemovedTrait;

    /**
     * @Type("string")
     */
    private $name;

    /**
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * @var string $name
     */
    public function setName($name)
    {
        $this->name = $name;
    }

    /**
     * @Type("string")
     */
    private $type;

    /**
     * @return string
     */
    public function getType()
    {
        return $this->type;
    }

    /**
     * @var string $type
     */
    public function setType($type)
    {
        $this->type = $type;
    }

    /**
     * @Type("integer")
     */
    private $length;

    /**
     * @return integer
     */
    public function getLength()
    {
        return $this->length;
    }

    /**
     * @var integer $length
     */
    public function setLength($length)
    {
        $this->length = $length;
    }

    /**
     * @Type("string")
     */
    private $alias;

    /**
     * @return string
     */
    public function getAlias()
    {
        return $this->alias;
    }

    /**
     * @var string $alias
     */
    public function setAlias($alias)
    {
        $this->alias = $alias;
    }

    /**
     * @Type("string")
     */
    private $description;

    /**
     * @return string
     */
    public function getDescription()
    {
        return $this->description;
    }

    /**
     * @var string $description
     */
    public function setDescription($description)
    {
        $this->description = $description;
    }

    /**
     * @Type("integer")
     */
    private $version;

    /**
     * @return integer
     */
    public function getVersion()
    {
        return $this->version;
    }

    /**
     * @var integer $version
     */
    public function setVersion($version)
    {
        $this->version = $version;
    }

    /**
     * @Type("boolean")
     */
    private $active;

    /**
     * @return boolean
     */
    public function getActive()
    {
        return $this->active;
    }

    /**
     * @var boolean $active
     */
    public function setActive($active)
    {
        $this->active = $active;
    }

    /**
     * @Type("string")
     */
    private $attrSetInstEfGroupFieldType;

    /**
     * @return string
     */
    public function getAttrSetInstEfGroupFieldType()
    {
        return $this->attrSetInstEfGroupFieldType;
    }

    /**
     * @var string $attrSetInstEfGroupFieldType
     */
    public function setAttrSetInstEfGroupFieldType($attrSetInstEfGroupFieldType)
    {
        $this->attrSetInstEfGroupFieldType = $attrSetInstEfGroupFieldType;
    }

    /**
     * @Type("integer")
     */
    private $attrSetInstEfGroupFieldLength;

    /**
     * @return integer
     */
    public function getAttrSetInstEfGroupFieldLength()
    {
        return $this->attrSetInstEfGroupFieldLength;
    }

    /**
     * @var integer $attrSetInstEfGroupFieldLength
     */
    public function setAttrSetInstEfGroupFieldLength($attrSetInstEfGroupFieldLength)
    {
        $this->attrSetInstEfGroupFieldLength = $attrSetInstEfGroupFieldLength;
    }

    /**
     * @Type("integer")
     */
    private $attrSetInstEfGroupFieldCount;

    /**
     * @return integer
     */
    public function getAttrSetInstEfGroupFieldCount()
    {
        return $this->attrSetInstEfGroupFieldCount;
    }

    /**
     * @var integer $attrSetInstEfGroupFieldCount
     */
    public function setAttrSetInstEfGroupFieldCount($attrSetInstEfGroupFieldCount)
    {
        $this->attrSetInstEfGroupFieldCount = $attrSetInstEfGroupFieldCount;
    }

    /**
     * @Type("string")
     */
    private $attrSetInstEfGroupNameFormat;

    /**
     * @return string
     */
    public function getAttrSetInstEfGroupNameFormat()
    {
        return $this->attrSetInstEfGroupNameFormat;
    }

    /**
     * @var string $attrSetInstEfGroupNameFormat
     */
    public function setAttrSetInstEfGroupNameFormat($attrSetInstEfGroupNameFormat)
    {
        $this->attrSetInstEfGroupNameFormat = $attrSetInstEfGroupNameFormat;
    }

    /**
     * @Type("string")
     */
    private $attrSetInstEfGroupDescription;

    /**
     * @return string
     */
    public function getAttrSetInstEfGroupDescription()
    {
        return $this->attrSetInstEfGroupDescription;
    }

    /**
     * @var string $attrSetInstEfGroupDescription
     */
    public function setAttrSetInstEfGroupDescription($attrSetInstEfGroupDescription)
    {
        $this->attrSetInstEfGroupDescription = $attrSetInstEfGroupDescription;
    }

    /**
     * @Type("string")
     */
    private $attrSetInstEfGroupCreatedBy;

    /**
     * @return string
     */
    public function getAttrSetInstEfGroupCreatedBy()
    {
        return $this->attrSetInstEfGroupCreatedBy;
    }

    /**
     * @var string $attrSetInstEfGroupCreatedBy
     */
    public function setAttrSetInstEfGroupCreatedBy($attrSetInstEfGroupCreatedBy)
    {
        $this->attrSetInstEfGroupCreatedBy = $attrSetInstEfGroupCreatedBy;
    }

    /**
     * @Type("string")
     */
    private $attrSetInstEfGroupCreatedAt;

    /**
     * @return string
     */
    public function getAttrSetInstEfGroupCreatedAt()
    {
        return $this->attrSetInstEfGroupCreatedAt;
    }

    /**
     * @var string $attrSetInstEfGroupCreatedAt
     */
    public function setAttrSetInstEfGroupCreatedAt($attrSetInstEfGroupCreatedAt)
    {
        $this->attrSetInstEfGroupCreatedAt = $attrSetInstEfGroupCreatedAt;
    }

    /**
     * @Type("string")
     */
    private $attrSetInstEfGroupUpdatedBy;

    /**
     * @return string
     */
    public function getAttrSetInstEfGroupUpdatedBy()
    {
        return $this->attrSetInstEfGroupUpdatedBy;
    }

    /**
     * @var string $attrSetInstEfGroupUpdatedBy
     */
    public function setAttrSetInstEfGroupUpdatedBy($attrSetInstEfGroupUpdatedBy)
    {
        $this->attrSetInstEfGroupUpdatedBy = $attrSetInstEfGroupUpdatedBy;
    }

    /**
     * @Type("string")
     */
    private $attrSetInstEfGroupUpdatedAt;

    /**
     * @return string
     */
    public function getAttrSetInstEfGroupUpdatedAt()
    {
        return $this->attrSetInstEfGroupUpdatedAt;
    }

    /**
     * @var string $attrSetInstEfGroupUpdatedAt
     */
    public function setAttrSetInstEfGroupUpdatedAt($attrSetInstEfGroupUpdatedAt)
    {
        $this->attrSetInstEfGroupUpdatedAt = $attrSetInstEfGroupUpdatedAt;
    }

    /**
     * @Type("boolean")
     */
    private $attrSetInstEfGroupActive;

    /**
     * @return boolean
     */
    public function getAttrSetInstEfGroupActive()
    {
        return $this->attrSetInstEfGroupActive;
    }

    /**
     * @var boolean $attrSetInstEfGroupActive
     */
    public function setAttrSetInstEfGroupActive($attrSetInstEfGroupActive)
    {
        $this->attrSetInstEfGroupActive = $attrSetInstEfGroupActive;
    }

    /**
     * @Type("boolean")
     */
    private $attrSetInstEfGroupDeleted;

    /**
     * @return boolean
     */
    public function getAttrSetInstEfGroupDeleted()
    {
        return $this->attrSetInstEfGroupDeleted;
    }

    /**
     * @var boolean $attrSetInstEfGroupDeleted
     */
    public function setAttrSetInstEfGroupDeleted($attrSetInstEfGroupDeleted)
    {
        $this->attrSetInstEfGroupDeleted = $attrSetInstEfGroupDeleted;
    }


}


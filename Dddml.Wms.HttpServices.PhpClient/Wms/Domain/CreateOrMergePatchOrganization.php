﻿<?php

namespace Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Wms\Domain\CommandTrait;

class CreateOrMergePatchOrganization extends AbstractOrganizationCommand
{

    use OrganizationIsPropertyRemovedTrait;

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
     * @Type("boolean")
     */
    private $isSummary;

    /**
     * @return boolean
     */
    public function getIsSummary()
    {
        return $this->isSummary;
    }

    /**
     * @var boolean $isSummary
     */
    public function setIsSummary($isSummary)
    {
        $this->isSummary = $isSummary;
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


}


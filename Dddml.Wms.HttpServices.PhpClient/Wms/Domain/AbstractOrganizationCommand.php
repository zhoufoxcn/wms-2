﻿<?php

namespace Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Wms\Domain\CommandTrait;

class AbstractOrganizationCommand
{

    use CommandTrait;

    /**
     * @Type("string")
     */
    private $organizationId;

    /**
     * @return string
     */
    public function getOrganizationId()
    {
        return $this->organizationId;
    }

    /**
     * @param string $organizationId
     */
    public function setOrganizationId($organizationId)
    {
        $this->organizationId = $organizationId;
    }

    /**
     * @Type("long")
     */
    private $version;

    /**
     * @return long
     */
    public function getVersion()
    {
        return $this->version;
    }

    /**
     * @param long $version
     */
    public function setVersion($version)
    {
        $this->version = $version;
    }


}

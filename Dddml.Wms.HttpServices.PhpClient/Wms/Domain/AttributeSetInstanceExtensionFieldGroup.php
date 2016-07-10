﻿<?php

namespace Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Wms\Domain\AttributeSetInstanceExtensionField;

class AttributeSetInstanceExtensionFieldGroup
{

    use AttributeSetInstanceExtensionFieldGroupStatePropertiesTrait;

    /**
     * @Type("array<Wms\Domain\AttributeSetInstanceExtensionField>")
     * @var AttributeSetInstanceExtensionField[]
     */
    private $fields;

    /**
     * @return AttributeSetInstanceExtensionField[]
     */
    public function getFields()
    {
        return $this->fields;
    }	

    /**
     * @var AttributeSetInstanceExtensionField[] $fields
     */
    public function setFields($fields)
    {
        $this->fields = $fields;
    }


}


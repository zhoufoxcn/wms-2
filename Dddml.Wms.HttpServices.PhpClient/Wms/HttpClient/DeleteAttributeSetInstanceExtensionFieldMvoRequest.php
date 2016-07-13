﻿<?php

namespace Wms\HttpClient;

use Dddml\Command\CommandExecutor;
use Dddml\Command\CommandRequestInterface;
use Dddml\Routing\RouteTrait;
use Symfony\Component\Routing\Route;
use Wms\Domain\AttributeSetInstanceExtensionFieldId;
use Wms\Domain\AttributeSetInstanceExtensionField;

class DeleteAttributeSetInstanceExtensionFieldMvoRequest implements CommandRequestInterface
{
    use RouteTrait;

    public function __construct()
    {
        $this->route = new Route('AttributeSetInstanceExtensionFieldMvos/{id}');
    }

    public function getMethod()
    {
        return CommandExecutor::METHOD_DELETE;
    }

    /**
     * @return null
     */
    public function getBody()
    {
        return null;
    }

}

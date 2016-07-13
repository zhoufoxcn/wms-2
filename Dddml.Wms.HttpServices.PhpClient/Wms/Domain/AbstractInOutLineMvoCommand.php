﻿<?php

namespace Wms\Domain;

use JMS\Serializer\Annotation\Type;
use Wms\Domain\InOutLineId;
use NodaMoney\Money;
use Wms\Domain\InOutLine;
use Wms\Domain\CommandTrait;

class AbstractInOutLineMvoCommand
{

    use CommandTrait;

    /**
     * @Type("Wms\Domain\InOutLineId")
     */
    private $inOutLineId;

    /**
     * @return InOutLineId
     */
    public function getInOutLineId()
    {
        return $this->inOutLineId;
    }

    /**
     * @param InOutLineId $inOutLineId
     */
    public function setInOutLineId($inOutLineId)
    {
        $this->inOutLineId = $inOutLineId;
    }

    /**
     * @Type("long")
     */
    private $inOutVersion;

    /**
     * @return long
     */
    public function getInOutVersion()
    {
        return $this->inOutVersion;
    }

    /**
     * @param long $inOutVersion
     */
    public function setInOutVersion($inOutVersion)
    {
        $this->inOutVersion = $inOutVersion;
    }


}

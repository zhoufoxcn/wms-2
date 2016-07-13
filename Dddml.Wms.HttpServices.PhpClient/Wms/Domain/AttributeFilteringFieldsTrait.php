﻿<?php

namespace Wms\Domain;


trait AttributeFilteringFieldsTrait
{
    public function getFilteringFields()
    {
        return [
            'AttributeId' => 'string',
            'Name' => 'string',
            'OrganizationId' => 'string',
            'Description' => 'string',
            'IsMandatory' => 'boolean',
            'IsInstanceAttribute' => 'boolean',
            'AttributeValueType' => 'string',
            'AttributeValueLength' => 'integer',
            'IsList' => 'boolean',
            'FieldName' => 'string',
            'ReferenceId' => 'string',
            'Version' => 'long',
            'CreatedBy' => 'string',
            'CreatedAt' => '\DateTime',
            'UpdatedBy' => 'string',
            'UpdatedAt' => '\DateTime',
            'Active' => 'boolean',
            'Deleted' => 'boolean',
        ];
    }

}

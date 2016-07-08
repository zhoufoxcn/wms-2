﻿<?php

namespace Dddml\Wms\Domain;

use Dddml\BaseEntity;
use JMS\Serializer\Annotation\Type;
use Dddml\Wms\Domain\SkuId;
use Dddml\Wms\Domain\DocumentAction;
use Dddml\Wms\Domain\OrganizationStructureId;
use Dddml\Wms\Domain\RolePermissionId;
use Dddml\Wms\Domain\UserRole;
use Dddml\Wms\Domain\UserClaim;
use Dddml\Wms\Domain\UserPermission;
use Dddml\Wms\Domain\UserLogin;
use Dddml\Wms\Domain\LoginKey;
use Dddml\Wms\Domain\UserRoleId;
use Dddml\Wms\Domain\UserClaimId;
use Dddml\Wms\Domain\UserPermissionId;
use Dddml\Wms\Domain\UserLoginId;


class UserRoleMvo extends BaseEntity
{

    /**
     * @Type("_UNKNOWN_")
     */
    private $userRoleId;

    /**
     * @return _UNKNOWN_
     */
    public function getUserRoleId()
    {
        return $this->userRoleId;
    }

    /**
     * @var _UNKNOWN_ $userRoleId
     */
    public function setUserRoleId($userRoleId)
    {
        $this->userRoleId = $userRoleId;
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
    private $userUserName;

    /**
     * @return string
     */
    public function getUserUserName()
    {
        return $this->userUserName;
    }

    /**
     * @var string $userUserName
     */
    public function setUserUserName($userUserName)
    {
        $this->userUserName = $userUserName;
    }

    /**
     * @Type("integer")
     */
    private $userAccessFailedCount;

    /**
     * @return integer
     */
    public function getUserAccessFailedCount()
    {
        return $this->userAccessFailedCount;
    }

    /**
     * @var integer $userAccessFailedCount
     */
    public function setUserAccessFailedCount($userAccessFailedCount)
    {
        $this->userAccessFailedCount = $userAccessFailedCount;
    }

    /**
     * @Type("string")
     */
    private $userEmail;

    /**
     * @return string
     */
    public function getUserEmail()
    {
        return $this->userEmail;
    }

    /**
     * @var string $userEmail
     */
    public function setUserEmail($userEmail)
    {
        $this->userEmail = $userEmail;
    }

    /**
     * @Type("boolean")
     */
    private $userEmailConfirmed;

    /**
     * @return boolean
     */
    public function getUserEmailConfirmed()
    {
        return $this->userEmailConfirmed;
    }

    /**
     * @var boolean $userEmailConfirmed
     */
    public function setUserEmailConfirmed($userEmailConfirmed)
    {
        $this->userEmailConfirmed = $userEmailConfirmed;
    }

    /**
     * @Type("boolean")
     */
    private $userLockoutEnabled;

    /**
     * @return boolean
     */
    public function getUserLockoutEnabled()
    {
        return $this->userLockoutEnabled;
    }

    /**
     * @var boolean $userLockoutEnabled
     */
    public function setUserLockoutEnabled($userLockoutEnabled)
    {
        $this->userLockoutEnabled = $userLockoutEnabled;
    }

    /**
     * @Type("string")
     */
    private $userLockoutEndDateUtc;

    /**
     * @return string
     */
    public function getUserLockoutEndDateUtc()
    {
        return $this->userLockoutEndDateUtc;
    }

    /**
     * @var string $userLockoutEndDateUtc
     */
    public function setUserLockoutEndDateUtc($userLockoutEndDateUtc)
    {
        $this->userLockoutEndDateUtc = $userLockoutEndDateUtc;
    }

    /**
     * @Type("string")
     */
    private $userPasswordHash;

    /**
     * @return string
     */
    public function getUserPasswordHash()
    {
        return $this->userPasswordHash;
    }

    /**
     * @var string $userPasswordHash
     */
    public function setUserPasswordHash($userPasswordHash)
    {
        $this->userPasswordHash = $userPasswordHash;
    }

    /**
     * @Type("string")
     */
    private $userPhoneNumber;

    /**
     * @return string
     */
    public function getUserPhoneNumber()
    {
        return $this->userPhoneNumber;
    }

    /**
     * @var string $userPhoneNumber
     */
    public function setUserPhoneNumber($userPhoneNumber)
    {
        $this->userPhoneNumber = $userPhoneNumber;
    }

    /**
     * @Type("boolean")
     */
    private $userPhoneNumberConfirmed;

    /**
     * @return boolean
     */
    public function getUserPhoneNumberConfirmed()
    {
        return $this->userPhoneNumberConfirmed;
    }

    /**
     * @var boolean $userPhoneNumberConfirmed
     */
    public function setUserPhoneNumberConfirmed($userPhoneNumberConfirmed)
    {
        $this->userPhoneNumberConfirmed = $userPhoneNumberConfirmed;
    }

    /**
     * @Type("boolean")
     */
    private $userTwoFactorEnabled;

    /**
     * @return boolean
     */
    public function getUserTwoFactorEnabled()
    {
        return $this->userTwoFactorEnabled;
    }

    /**
     * @var boolean $userTwoFactorEnabled
     */
    public function setUserTwoFactorEnabled($userTwoFactorEnabled)
    {
        $this->userTwoFactorEnabled = $userTwoFactorEnabled;
    }

    /**
     * @Type("string")
     */
    private $userSecurityStamp;

    /**
     * @return string
     */
    public function getUserSecurityStamp()
    {
        return $this->userSecurityStamp;
    }

    /**
     * @var string $userSecurityStamp
     */
    public function setUserSecurityStamp($userSecurityStamp)
    {
        $this->userSecurityStamp = $userSecurityStamp;
    }

    /**
     * @Type("string")
     */
    private $userCreatedBy;

    /**
     * @return string
     */
    public function getUserCreatedBy()
    {
        return $this->userCreatedBy;
    }

    /**
     * @var string $userCreatedBy
     */
    public function setUserCreatedBy($userCreatedBy)
    {
        $this->userCreatedBy = $userCreatedBy;
    }

    /**
     * @Type("string")
     */
    private $userCreatedAt;

    /**
     * @return string
     */
    public function getUserCreatedAt()
    {
        return $this->userCreatedAt;
    }

    /**
     * @var string $userCreatedAt
     */
    public function setUserCreatedAt($userCreatedAt)
    {
        $this->userCreatedAt = $userCreatedAt;
    }

    /**
     * @Type("string")
     */
    private $userUpdatedBy;

    /**
     * @return string
     */
    public function getUserUpdatedBy()
    {
        return $this->userUpdatedBy;
    }

    /**
     * @var string $userUpdatedBy
     */
    public function setUserUpdatedBy($userUpdatedBy)
    {
        $this->userUpdatedBy = $userUpdatedBy;
    }

    /**
     * @Type("string")
     */
    private $userUpdatedAt;

    /**
     * @return string
     */
    public function getUserUpdatedAt()
    {
        return $this->userUpdatedAt;
    }

    /**
     * @var string $userUpdatedAt
     */
    public function setUserUpdatedAt($userUpdatedAt)
    {
        $this->userUpdatedAt = $userUpdatedAt;
    }

    /**
     * @Type("boolean")
     */
    private $userActive;

    /**
     * @return boolean
     */
    public function getUserActive()
    {
        return $this->userActive;
    }

    /**
     * @var boolean $userActive
     */
    public function setUserActive($userActive)
    {
        $this->userActive = $userActive;
    }

    /**
     * @Type("boolean")
     */
    private $userDeleted;

    /**
     * @return boolean
     */
    public function getUserDeleted()
    {
        return $this->userDeleted;
    }

    /**
     * @var boolean $userDeleted
     */
    public function setUserDeleted($userDeleted)
    {
        $this->userDeleted = $userDeleted;
    }

    /**
     * @Type("integer")
     */
    private $userVersion;

    /**
     * @return integer
     */
    public function getUserVersion()
    {
        return $this->userVersion;
    }

    /**
     * @var integer $userVersion
     */
    public function setUserVersion($userVersion)
    {
        $this->userVersion = $userVersion;
    }

    /**
     * @Type("string")
     */
    private $createdBy;

    /**
     * @return string
     */
    public function getCreatedBy()
    {
        return $this->createdBy;
    }

    /**
     * @var string $createdBy
     */
    public function setCreatedBy($createdBy)
    {
        $this->createdBy = $createdBy;
    }

    /**
     * @Type("string")
     */
    private $createdAt;

    /**
     * @return string
     */
    public function getCreatedAt()
    {
        return $this->createdAt;
    }

    /**
     * @var string $createdAt
     */
    public function setCreatedAt($createdAt)
    {
        $this->createdAt = $createdAt;
    }

    /**
     * @Type("string")
     */
    private $updatedBy;

    /**
     * @return string
     */
    public function getUpdatedBy()
    {
        return $this->updatedBy;
    }

    /**
     * @var string $updatedBy
     */
    public function setUpdatedBy($updatedBy)
    {
        $this->updatedBy = $updatedBy;
    }

    /**
     * @Type("string")
     */
    private $updatedAt;

    /**
     * @return string
     */
    public function getUpdatedAt()
    {
        return $this->updatedAt;
    }

    /**
     * @var string $updatedAt
     */
    public function setUpdatedAt($updatedAt)
    {
        $this->updatedAt = $updatedAt;
    }

}

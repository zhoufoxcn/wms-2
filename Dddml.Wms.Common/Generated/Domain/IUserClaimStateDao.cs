﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{
    public interface IUserClaimStateDao
    {

        IUserClaimState Get(UserClaimId id, bool nullAllowed);

        void Save (IUserClaimState state);

        IEnumerable<IUserClaimState> FindByUserId(string userId);

        void Delete(IUserClaimState state);

    }
}



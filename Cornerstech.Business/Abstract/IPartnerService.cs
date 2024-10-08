﻿using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.BusinessLayer.Abstract
{
    public interface IPartnerService : IGenericService<Partner>
    {
        int? GetPartnerIdByUserId(int userId);

    }
}

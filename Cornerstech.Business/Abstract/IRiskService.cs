﻿using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.BusinessLayer.Abstract
{
    public interface IRiskService : IGenericService<Risk>
    {
        double GetRiskValueByRiskName(string riskName);

    }
}

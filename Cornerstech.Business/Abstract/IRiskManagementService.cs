using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.BusinessLayer.Abstract
{
    public interface IRiskManagementService : IGenericService<RiskManagement>
    {
        double CalculateAverageScore();
    }
}

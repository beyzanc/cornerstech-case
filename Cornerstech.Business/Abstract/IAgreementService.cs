using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.BusinessLayer.Abstract
{
    public interface IAgreementService : IGenericService<Agreement>
    {
        Dictionary<string, int> GetAgreementStatusCounts();
        List<int> GetMonthlyAgreementCounts();
        Dictionary<string, int> GetIndustryAgreementCounts();
        int GetTotalAgreementCountInCurrentYear();

    }

}

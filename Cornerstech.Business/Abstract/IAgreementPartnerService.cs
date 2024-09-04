using Cornerstech.EntityLayer.Entities;

namespace Cornerstech.BusinessLayer.Abstract
{
    public interface IAgreementPartnerService : IGenericService<AgreementPartner>
    {
        int GetPartnerCountWithAgreements();
    }
}

﻿using Cornerstech.BusinessLayer.Abstract;
using Cornerstech.EntityLayer.Entities;
using Cornerstech.DataAccessLayer.Abstract;
using Cornerstech.DataAccessLayer.UnitOfWork.Abstract;

namespace Cornerstech.BusinessLayer.Concrete
{
    public class AgreementManager : IAgreementService
    {
        private readonly IAgreementDal _agreementDal;
        private readonly IAgreementPartnerDal _agreementPartnerDal;
        private readonly IPartnerDal _partnerDal;
        private readonly IUnitOfWorkDal _uowDal;

        public AgreementManager(IUnitOfWorkDal uowDal, IAgreementDal AgreementDal, IPartnerDal PartnerDal, IAgreementPartnerDal AgreementPartnerDal)
        {
            _uowDal = uowDal;
            _agreementDal = AgreementDal;
            _agreementPartnerDal = AgreementPartnerDal;
            _partnerDal = PartnerDal;
        }

        public void TDelete(Agreement t)
        {
            _agreementDal.Delete(t);
            _uowDal.Save();
        }

        public Agreement TGetByID(int id)
        {
            return _agreementDal.GetByID(id);
        }

        public IQueryable<Agreement> TGetList()
        {
            return _agreementDal.GetQueryableList(); 
        }

        public void TInsert(Agreement t)
        {
            _agreementDal.Insert(t);
            _uowDal.Save();
        }

        public void TUpdate(Agreement t)
        {
            _agreementDal.Update(t);
            _uowDal.Save();
        }

        public Dictionary<string, int> GetAgreementStatusCounts() // Aggregates the number of agreements per status and returns a dictionary of status counts

        {
            var statusCounts = _agreementDal.GetQueryableList()
                .GroupBy(a => a.Status)
                .Select(g => new { Status = g.Key ?? "Bilinmeyen", Count = g.Count() })
                .ToDictionary(x => x.Status, x => x.Count);

            return statusCounts;
        }

        public List<int> GetMonthlyAgreementCounts() // Returns the count of agreements created for each month of the current year.
        {
            var monthlyAgreementCounts = new List<int>(new int[12]);

            var agreements = _agreementDal.GetQueryableList();

            foreach (var agreement in agreements)
            {
                var month = agreement.CreatedDate.Month;
                monthlyAgreementCounts[month - 1]++;
            }

            return monthlyAgreementCounts;
        }

        public Dictionary<string, int> GetIndustryAgreementCounts() // Calculates and returns the agreement count by industry
        {

            var industryCounts = _agreementDal.GetQueryableList()
                                  .Join(_agreementPartnerDal.GetQueryableList(),
                                        a => a.Id,
                                        ap => ap.AgreementId,
                                        (a, ap) => new { a, ap })
                                  .Join(_partnerDal.GetQueryableList(),
                                        x => x.ap.PartnerId,
                                        p => p.Id,
                                        (x, p) => p.Industry)
                                  .GroupBy(i => i)
                                  .Select(group => new { Industry = group.Key, Count = group.Count() })
                                  .ToDictionary(g => g.Industry, g => g.Count);

            return industryCounts;
        }


        public int GetTotalAgreementCountInCurrentYear() // Calculates and returns the total number of agreements created in the current calendar year

        {
            DateTime currentDate = DateTime.Now;
            DateTime firstDayOfYear = new DateTime(currentDate.Year, 1, 1);

            int count = _agreementDal.GetQueryableList()
                .Where(a => a.CreatedDate >= firstDayOfYear && a.CreatedDate <= currentDate)
                .Count();

            return count;
        }

    }
}

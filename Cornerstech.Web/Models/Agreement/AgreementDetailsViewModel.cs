using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cornerstech.Web.Models.Agreement
{
    public class AgreementDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<int>? SelectedPartners { get; set; }
        public List<SelectListItem>? PartnerOptions { get; set; }
        public List<int>? SelectedRisks { get; set; }
        public List<SelectListItem>? RiskOptions { get; set; }
        public List<int>? SelectedSubjects { get; set; }
        public List<SelectListItem>? SubjectOptions { get; set; }
    }

}

using Cornerstech.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Cornerstech.Web.Models.SubjectOfWork
{
    public class SubjectOfWorkDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<int>? SelectedAgreements { get; set; }
        public List<SelectListItem>? AgreementOptions { get; set; }

    }
}

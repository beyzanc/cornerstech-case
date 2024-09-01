using System.ComponentModel.DataAnnotations;

namespace Cornerstech.Web.Models.SubjectOfWork
{
    public class SubjectOfWorkCreateViewModel
    {
        [Required(ErrorMessage = "Anlaşma adını giriniz.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Detay giriniz.")]
        public required string Description { get; set; }

        [Required(ErrorMessage = "Kategori giriniz.")]
        public required string Category { get; set; }
        public List<int>? SelectedAgreements { get; set; }

    }
}

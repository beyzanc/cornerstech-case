using System.ComponentModel.DataAnnotations;

namespace Cornerstech.Web.Models.Agreement
{
    public class AgreementCreateViewModel
    {
        [Required(ErrorMessage = "Anlaşma adını giriniz.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Detay giriniz.")]
        public required string Description { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Tarih formatı hatalı.")]
        public DateTime? StartDate { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Tarih formatı hatalı.")]
        public DateTime? EndDate { get; set; }
        [Required(ErrorMessage = "Durum seçiniz.")]
        public required string Status { get; set; }
        public List<int>? SelectedPartners { get; set; }
        public List<int>? SelectedRisks { get; set; }
        public List<int>? SelectedSubjects { get; set; }
    }
}

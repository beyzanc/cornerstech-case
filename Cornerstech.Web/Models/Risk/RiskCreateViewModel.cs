using System.ComponentModel.DataAnnotations;

namespace Cornerstech.Web.Models.Risk
{
    public class RiskCreateViewModel
    {
        [Required(ErrorMessage = "Risk adı giriniz.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Kategori giriniz.")]
        public string Category { get; set; } = string.Empty;

        [Required(ErrorMessage = "Lütfen bir seviye seçiniz.")]
        public double? SelectedLevel { get; set; }

        [Required(ErrorMessage = "Lütfen bir frekans seçiniz.")]
        public double? SelectedFrequence { get; set; }

        [Required(ErrorMessage = "Lütfen bir olasılık seçiniz.")]
        public double? SelectedPossibility { get; set; }

        public Dictionary<double, string>? LevelOptions { get; set; }
        public Dictionary<double, string>? FrequenceOptions { get; set; }
        public Dictionary<double, string>? PossibilityOptions { get; set; }
    }
}

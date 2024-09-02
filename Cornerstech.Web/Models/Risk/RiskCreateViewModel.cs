using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace Cornerstech.Web.Models.Risk
{
    public class RiskCreateViewModel
    {
        [Required(ErrorMessage = "Risk adı giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Kategori giriniz.")]
        public string Category { get; set; }
        public double SelectedLevel { get; set; }
        public double SelectedFrequence { get; set; }
        public double SelectedPossibility { get; set; }

        public Dictionary<double, string>? LevelOptions { get; set; }
        public Dictionary<double, string>? FrequenceOptions { get; set; }
        public Dictionary<double, string>? PossibilityOptions { get; set; }
    }

}


using System.ComponentModel.DataAnnotations;

namespace Cornerstech.Web.Models.Partner
{
    public class PartnerCreateViewModel
    {
        [Required(ErrorMessage = "Partner adını giriniz.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Mail adresi giriniz.")]
        public required string ContactEmail { get; set; }

        [Required(ErrorMessage = "Telefon numarası giriniz.")]
        public required string PhoneNumber { get; set; }
        public string? City { get; set; }

        [Required(ErrorMessage = "Endüstri seçiniz.")]
        public required string Industry { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}

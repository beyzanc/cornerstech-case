namespace Cornerstech.Web.Models.Partner
{
    public class PartnerDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? ContactEmail { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? Industry { get; set; }
        public DateTime? CreatedDate{ get; set; }
        public List<int>? SelectedAgreements { get; set; }

    }
}

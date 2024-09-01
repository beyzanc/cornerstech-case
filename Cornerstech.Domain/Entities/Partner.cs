namespace Cornerstech.EntityLayer.Entities
{
    public class Partner : BaseEntity
    {
        public required string Name { get; set; }
        public required string ContactEmail { get; set; }
        public required string PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Industry { get; set; }
        public ICollection<AgreementPartner>? AgreementPartners { get; set; }
    }
}

namespace Cornerstech.EntityLayer.Entities
{
    public class Agreement : BaseEntity
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Status { get; set; }
        public ICollection<AgreementPartner>? AgreementPartners { get; set; }
        public ICollection<AgreementSubject>? AgreementSubjects { get; set; }
        public ICollection<AgreementRisk>? AgreementRisks { get; set; }
    }
}

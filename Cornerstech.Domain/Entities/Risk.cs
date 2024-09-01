using Cornerstech.EntityLayer.Enums;

namespace Cornerstech.EntityLayer.Entities
{
    public class Risk : BaseEntity
    {
        public required string Name { get; set; }
        public required RiskCategory Category { get; set; }
        public int RiskCategoryId { get; set; }
        public required RiskLevel Level { get; set; }
        public ICollection<AgreementRisk>? AgreementRisks { get; set; }
    }
}

using Cornerstech.EntityLayer.Enums;

namespace Cornerstech.EntityLayer.Entities
{
    public class Risk : BaseEntity
    {
        public required string Name { get; set; }
        public required RiskCategory Category { get; set; }
        public int RiskCategoryId { get; set; }
        public required double Level { get; set; }
        public required double Frequence { get; set; }
        public required double Possibility { get; set; }
        public ICollection<AgreementRisk>? AgreementRisks { get; set; }
    }
}

using Cornerstech.EntityLayer.Enums;

namespace Cornerstech.EntityLayer.Entities
{
    public class Risk : BaseEntity
    {
        public required string Name { get; set; }
        public required string Category { get; set; }
        public double? Level { get; set; }
        public double? Frequence { get; set; }
        public double? Possibility { get; set; }
        public ICollection<AgreementRisk>? AgreementRisks { get; set; }
    }
}

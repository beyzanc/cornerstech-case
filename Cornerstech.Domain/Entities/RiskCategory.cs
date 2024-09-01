namespace Cornerstech.EntityLayer.Entities
{
    public class RiskCategory : BaseEntity
    {
        public required string Name { get; set; }
        public ICollection<Risk>? Risks { get; set; }

    }
}

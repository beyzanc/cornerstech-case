namespace Cornerstech.EntityLayer.Entities
{
    public class RiskManagement : BaseEntity
    {
        public string RiskCategory { get; set; }

        public string RiskDescription { get; set; }

        public decimal RiskValue { get; set; }
    }
}

namespace Cornerstech.EntityLayer.Entities
{
    public class AgreementRisk : BaseEntity
    {
        public int AgreementId { get; set; }
        public Agreement Agreement { get; set; }
        public int RiskId { get; set; }
        public Risk Risk { get; set; }
    }
}

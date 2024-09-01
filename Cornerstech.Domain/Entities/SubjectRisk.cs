namespace Cornerstech.EntityLayer.Entities
{
    public class SubjectRisk : BaseEntity
    {
        public int SubjectId { get; set; }
        public SubjectOfWork Subject { get; set; }

        public int RiskId { get; set; }
        public Risk Risk { get; set; }
    }

}
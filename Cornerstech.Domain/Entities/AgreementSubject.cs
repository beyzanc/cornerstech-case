namespace Cornerstech.EntityLayer.Entities
{
    public class AgreementSubject : BaseEntity
    {
        public int AgreementId { get; set; }
        public Agreement Agreement { get; set; }

        public int SubjectId { get; set; }
        public SubjectOfWork Subject { get; set; }

    }
}
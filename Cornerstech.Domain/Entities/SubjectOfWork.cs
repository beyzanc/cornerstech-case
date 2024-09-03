namespace Cornerstech.EntityLayer.Entities
{
    public class SubjectOfWork : BaseEntity
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public ICollection<AgreementSubject> AgreementSubjects { get; set; }
    }
}

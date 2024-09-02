using Cornerstech.EntityLayer.Entities;
using Cornerstech.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
    }

    public DbSet<Agreement> Agreements { get; set; }
    public DbSet<Partner> Partners { get; set; }
    public DbSet<Risk> Risks { get; set; }
    public DbSet<SubjectOfWork> SubjectOfWorks { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<AgreementPartner> AgreementPartners { get; set; } 
    public DbSet<AgreementRisk> AgreementRisks { get; set; } 
    public DbSet<AgreementSubject> AgreementSubjects { get; set; } 
    public DbSet<SubjectRisk> SubjectRisks { get; set; } 
    public DbSet<RiskManagement> RiskManagements { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}

using Cornerstech.DataAccessLayer.DataSeeder;
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
    public DbSet<RiskManagement> RiskManagements { get; set; } 
    public DbSet<Notification> Notifications { get; set; } 
    public DbSet<NotificationApplicationUser> NotificationApplicationUsers { get; set; } 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Partner>()
            .HasOne(p => p.User)
            .WithOne(u => u.Partner)
            .HasForeignKey<Partner>(p => p.UserId);

        DataSeeder.Seed(modelBuilder); // Calls the Seed method from the DataSeeder class to populate the database with initial data.

    }
}

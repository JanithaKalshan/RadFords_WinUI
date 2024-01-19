using Microsoft.EntityFrameworkCore;
using RadFordDataAccessLayer.Models;

namespace RadFordDataAccessLayer;

public class RDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Replace this connection string if your server have a password
        //Server=YourServerName;Database=YourDatabaseName;User Id=YourUsername;Password=YourPassword;
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-AMHIEQV;Database=RadFord_DB;Trusted_Connection=True;TrustServerCertificate=True;");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StaffMember>()
            .HasKey(s => s.StaffMemberId);

        modelBuilder.Entity<StaffMember>()
            .Property(s => s.StaffMemberId)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<StaffMember>()
            .HasOne(s => s.Manager)
            .WithMany(m => m.Subordinates)
            .HasForeignKey(s => s.ManagerId)
            .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<StaffMember> StaffMembers { get; set; }

}

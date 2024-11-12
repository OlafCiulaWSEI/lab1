using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class AppDbContext: DbContext
{
    public DbSet<ContactEntity> Contacts {
        get;
        set;
    }

    public DbSet<OrganizationEntity> Organizations { get; set; }
    
    
    private string DbPath { get; set; }
    public AppDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "contacts.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data source={DbPath}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrganizationEntity>()
            .OwnsOne(o => o.Address)
            .HasData(
                new { OrganizationEntityId = 1, City ="Kraków", Street ="św Filipa 18"},
                new { OrganizationEntityId = 2, City ="Kraków", Street ="Buncha"}
            );

        modelBuilder.Entity<ContactEntity>()
            .HasOne<OrganizationEntity>(c => c.Organization)
            .WithMany(o => o.Contacts)
            .HasForeignKey(c => c.OrganizationId);

        modelBuilder.Entity<OrganizationEntity>()
            .HasData(
                new OrganizationEntity()
                {
                    Id = 1,
                    Regon = "74576364",
                    Nip = "12423534",
                    Name = "WSEI"
                },
                new OrganizationEntity()
                {
                    Id = 2,
                    Regon = "7254231",
                    Nip = "864363",
                    Name = "WEBCON"
                }
            );
        
        modelBuilder.Entity<ContactEntity>()
            .HasData(
                new ContactEntity()
                {
                    Id = 1,
                    FirstName = "Adam",
                    LastName = "Nowak",
                    BirthDate = new(2000, 10, 10),
                    PhoneNumber = "333 333 333",
                    Email = "adam@.wsei.edu.pl",
                    Created = DateTime.Now,
                    OrganizationId = 1
                },
                new ContactEntity()
                {
                    Id = 2,
                    FirstName = "Ada",
                    LastName = "Fisak",
                    BirthDate = new(2000, 11, 10),
                    PhoneNumber = "333 333 333",
                    Email = "ada@.wsei.edu.pl",
                    Created = DateTime.Now,
                    OrganizationId = 2
                }
            );
    }
}
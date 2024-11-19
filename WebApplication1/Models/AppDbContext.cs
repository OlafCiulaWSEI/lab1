using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class AppDbContext: IdentityDbContext<IdentityUser>
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
        base.OnModelCreating(modelBuilder);
        
        string ADMIN_ID = Guid.NewGuid().ToString();
        string USER_ID = Guid.NewGuid().ToString();

        modelBuilder.Entity<IdentityRole>()
            .HasData(
                new IdentityRole()
                {
                    Id = ADMIN_ID,
                    Name = "admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = ADMIN_ID
                },
                new IdentityRole()
                {
                    Id = USER_ID,
                    Name = "user",
                    NormalizedName = "USER",
                    ConcurrencyStamp = USER_ID
                }
                );

        var admin = new IdentityUser()
        {
            Id = ADMIN_ID,
            UserName = "Olaf",
            NormalizedUserName = "OLAF",
            Email = "olaf@wsei.edu.pl",
            NormalizedEmail = "OLAF@WSEI.EDU.PL",
            EmailConfirmed = true,
        };

        var user = new IdentityUser()
        {
            Id = USER_ID,
            UserName = "Kuba",
            NormalizedUserName = "KUBA",
            Email = "kuba@wsei.edu.pl",
            NormalizedEmail = "KUBA@WSEI.EDU.PL",
            EmailConfirmed = true
        };

        PasswordHasher<IdentityUser> hasher = new PasswordHasher<IdentityUser>();

        admin.PasswordHash = hasher.HashPassword(admin, "1234!");
        user.PasswordHash = hasher.HashPassword(user, "qwerty123!");

        modelBuilder.Entity<IdentityUser>()
            .HasData(admin, user);

        modelBuilder.Entity<IdentityUserRole<string>>()
            .HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = ADMIN_ID,
                    UserId = ADMIN_ID
                },
                new IdentityUserRole<string>()
                {
                    RoleId = USER_ID,
                    UserId = USER_ID
                }
                );
        
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
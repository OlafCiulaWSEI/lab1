using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public class AppDbContext: DbContext
{
    public DbSet<ContactEntity> Contacts {
        get;
        set;
    }
    
    
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
                    Created = DateTime.Now
                },
                new ContactEntity()
                {
                    Id = 2,
                    FirstName = "Ada",
                    LastName = "Fisak",
                    BirthDate = new(2000, 11, 10),
                    PhoneNumber = "333 333 333",
                    Email = "ada@.wsei.edu.pl",
                    Created = DateTime.Now
                }
            );
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Timesheets.App.Data
{
    public class TimesheetsDbContext : DbContext
    {
        public TimesheetsDbContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "Timesheets.db");
        }

        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Location> Locations { get; set; } = null!;
        public DbSet<Staff> Staff { get; set; } = null!;
        public DbSet<Timesheets> Timesheets { get; set; } = null!;
        public String DbPath { get; set; } = String.Empty;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"data source= {DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Location>()
                .HasMany(l => l.Timesheets)
                .WithOne(l => l.Location)
                .HasForeignKey(l => l.LocationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Staff>()
                .HasMany(s => s.Timesheets)
                .WithOne(s => s.Staff)
                .HasForeignKey(s => s.StaffId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Client>()
                .HasMany(c => c.Timesheets)
                .WithOne(c => c.Client)
                .HasForeignKey(c => c.ClientId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Client>().HasData(
                    new Client(1, "ABC Inc.", "123 Main St, Cityville", "John Doe", 5555555555, "john.doe@abcinc.com"),
                    new Client(2, "XYZ Corporation", "456 Oak Ave, Townsville", "Jane Smith", 5555555556, "jane.smith@xyzcorp.com"),
                    new Client(3, "123 Industries", "789 Elm Rd, Villagetown", "Bob Johnson", 5555555557, "bob.johnson@123ind.com"),
                    new Client(4, "LMN Ltd.", "101 Pine Ln, Hamletville", "Sarah Williams", 5555555558, "sarah.williams@lmnltd.com"),
                    new Client(5, "PQR Enterprises", "202 Cedar Dr, Burgville", "Michael Davis", 5555555559, "michael.davis@pqrent.com")
                    );
            modelBuilder.Entity<Location>().HasData(
                    new Location(1, "Main Office", "123 Main St, Cityville"),
                    new Location(2, "Branch A", "456 Oak Ave, Townsville"),
                    new Location(3, "Factory", "789 Elm Rd, Villagetown"),
                    new Location(4, "Warehouse", "101 Pine Ln, Hamletville"),
                    new Location(5, "Retail Store", "202 Cedar Dr, Burgville")
                    );
            modelBuilder.Entity<Staff>().HasData(
                    new Staff("Doe", 1, "John", "john.doe@example.com"),
                    new Staff("Smith", 2, "Jane", "jane.smith@example.com"),
                    new Staff("Johnson", 3, "Bob", "bob.johnson@example.com"),
                    new Staff("Williams", 4, "Sarah", "sarah.williams@example.com"),
                    new Staff("Davis", 5, "Michael", "michael.davis@example.com")
                    );
            modelBuilder.Entity<Timesheets>().HasData(
                    new Timesheets(1, 480, 4, 3, 2),
                    new Timesheets(2, 520, 2, 5, 1),
                    new Timesheets(3, 420, 1, 2, 4),
                    new Timesheets(4, 450, 5, 4, 3),
                    new Timesheets(5, 490, 3, 1, 5)
                );
        }
    }
}

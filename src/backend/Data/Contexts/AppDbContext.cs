using System.Reflection;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;

namespace Data.Contexts
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Device> Devices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding
            modelBuilder.Entity<Device>().HasData(new Device[]
            {
                new Device
                {
                    Id = 1,
                    Name = "Device 1",
                    Status =  "Available",
                    Temperature = 10,
                    TypeId =  1,
                },
                new Device
                {
                    Id = 2,
                    Name = "Device 2",
                    Status = "Offline",
                    Temperature = 15,
                    TypeId = 3,
                },
                new Device
                {
                    Id = 3,
                    Name = "Device 3",
                    Status = "Available",
                    Temperature = 7,
                    TypeId = 2,
                },
                new Device
                {
                    Id = 4,
                    Name = "Device 4",
                    Status = "Offline",
                    Temperature = 4,
                    TypeId = 1,
                },
                new Device
                {
                    Id = 5,
                    Name = "Device 5",
                    Status = "Offline",
                    Temperature = 20,
                    TypeId = 2,
                },
                new Device
                {
                    Id = 6,
                    Name = "Device 6",
                    Status = "Available",
                    Temperature = 12,
                    TypeId = 3,
                },
                new Device
                {
                    Id = 7,
                    Name = "Device 7",
                    Status = "Available",
                    Temperature = 21,
                    TypeId = 3,
                },
                new Device
                {
                    Id = 8,
                    Name = "Device 8",
                    Status = "Offline",
                    Temperature = 19,
                    TypeId = 2,
                },
                new Device
                {
                    Id = 9,
                    Name = "Device 9",
                    Status = "Offline",
                    Temperature = 22,
                    TypeId = 1,
                },
                new Device
                {
                    Id = 10,
                    Name = "Device 10",
                    Status = "Available",
                    Temperature = 40,
                    TypeId = 2,
                }
            });

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
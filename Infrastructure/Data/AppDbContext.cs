using Domain.Entities;
using Domain.ValueObject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Address> Addresses { get; internal set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Mechanic>()
                       .HasMany(m => m.Appointments)
                       .WithOne(a => a.Mechanic)
                       .HasForeignKey(a => a.MechanicId);
  
            modelBuilder.Entity<Appointment>()
                        .HasOne(a => a.Mechanic)
                        .WithMany(m => m.Appointments)
                        .HasForeignKey(a => a.MechanicId);

            modelBuilder.Entity<Address>()
                        .HasKey(a => a.Id);
        }

    }
}

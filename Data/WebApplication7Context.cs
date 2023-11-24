using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7.Data
{
    public class WebApplication7Context : DbContext
    {
        public WebApplication7Context (DbContextOptions<WebApplication7Context> options)
            : base(options)
        {
        }

        public DbSet<Vehicle> Vehicle { get; set; } = default!;
        public DbSet<MaintenanceReport> MaintenanceReport { get; set; } = default!;
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>()
                .Property(v => v.Id)
                .ValueGeneratedOnAdd();

            // modelBuilder.Entity<MaintenanceReport>()
            //     .Property(v => v.RequestId)
            //     .ValueGeneratedOnAdd();
        }
    }
}

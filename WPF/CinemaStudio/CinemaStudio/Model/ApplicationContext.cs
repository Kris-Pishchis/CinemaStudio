using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CinemaStudio.Model
{
    public class ApplicationContext : DbContext
    {
        public DbSet<AccessRight> AccessRights { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Cinema_studio;Username=postgres;Password=postgres");
        }
    }
}

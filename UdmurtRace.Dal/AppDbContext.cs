using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdmurtRace.Dal.Configuration;
using UdmurtRace.Domain;

namespace UdmurtRace.Dal
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BusRaceConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=UdmurtRaceEF;user=root;password=;port=3306;");
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<BusRace> BusRaces{ get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    }
}

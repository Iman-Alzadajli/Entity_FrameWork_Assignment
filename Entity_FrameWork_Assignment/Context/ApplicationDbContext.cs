using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_FrameWork_Assignment.Model;

namespace Entity_FrameWork_Assignment.Context
{
    class ApplicationDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //Catalog or database 

        {
            optionsBuilder.UseSqlServer("Data Source=ZADJALI\\MSSQLSERVER02;Initial Catalog=ComanyXYZ;Integrated Security=True;Connect Timeout=30;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }

        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Bagger> Baggers { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<CheckPoint> CheckPoints { get; set; }
        public DbSet<Officer> Officers { get; set; }


    }
}

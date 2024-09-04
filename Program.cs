using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Net;

namespace CW_04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ApplicationContext db = new ApplicationContext()) {

               
            }
        }
    }



    public class Country
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Airport> Airports { get; set; } = new();
    }


    public class  Airport
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }


        public int CountryId { get; set; }

        public Country Country { get; set; }
    }


    public class Airplane
    {
        public int Id { get; set; }


        public int Airportid { get; set; }

        public Airport Airport { get; set; }

        public AirplaneCharacteristics AirplaneCharacteristics { get; set; }


    }


    public class AirplaneCharacteristics
    {
        public int Id { get; set; }

        public string PlaneName { get; set; }

        public int PlaceCount { get; set; }

        public string PlaneClass { get; set; }




        public int AirplaneId { get; set; }

        public Airplane Airplane { get; set; }
    }


    public class ApplicationContext: DbContext 
    {
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Country> Countries { get; set; }

        public DbSet<Airplane> Airplanes { get; set; }

        public DbSet<AirplaneCharacteristics> AirplaneCharacteristics{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R3LQDV9;Database = testDB1;Trusted_Connection =True;TrustServerCertificate=True");
        }


    }

}

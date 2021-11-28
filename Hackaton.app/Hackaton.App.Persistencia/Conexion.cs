using Microsoft.EntityFrameworkCore;
using Hackaton.App.Dominio.Entidades;

namespace Hackaton.App.Persistencia
{
    public class Conexion : DbContext
    {
        public DbSet<Migrante> Migrantes {get; set;}
        public DbSet<Entidad> Entidades {get; set;}
        

        protected override void OnConfiguring(DbContextOptionsBuilder conn){
           if(!conn.IsConfigured){
                conn.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = DigitalSolutions2");
           }
       }
    }
}

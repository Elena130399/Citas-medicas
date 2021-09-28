using Microsoft.EntityFrameworkCore;
using CitasMedicas.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
   public class AppContext : DbContext
   {
       public DbSet<Persona> Personas {get;set;}
       public DbSet<Paciente> Pacientes {get;set;}
       
       
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = CitasMedicasData");
                // Conexion por MSSQL visto en clase
                //.UseSqlServer("Initial Catalog=HospiEnCasaData; Data Source=HOMELUNA; Integrated Security=true"); 
           }
       }
   } 
}
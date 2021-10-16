using Microsoft.EntityFrameworkCore;
using CitasMedicas.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
   public class AppContext : DbContext
   {
       public DbSet<Persona> Personas {get;set;}
       public DbSet<Paciente> Pacientes {get;set;}
       public DbSet<Sede> Sedes {get;set;}
       public DbSet<Medico> Medicos {get;set;}
       public DbSet<Agenda> Agendas {get;set;}
       public DbSet<Ciudad> Ciudades {get;set;}
       
       
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder
               //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = CitasMedicasData");
               //.UseSqlServer("Initial Catalog=CitasMedicasFG; Data Source=EN2010449; Integrated Security=true");
                .UseSqlServer("Server=tcp:citasmedicasfg.database.windows.net,1433;Initial Catalog=CitasMedicasFG;Persist Security Info=False;User ID=federicogomez;Password=ClavePrueba!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

           }
       }
   }
}
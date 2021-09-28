using System;
<<<<<<< HEAD
=======
using CitasMedicas.App.Dominio;
using CitasMedicas.App.Persistencia;
>>>>>>> 8b331db5f3de762e9e9546d0efc251406e435797

namespace CitasMedicas.App.Consola
{
    class Program
    {
<<<<<<< HEAD
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
=======
        private static IRepositorioPaciente _repoPaciente=new RepositorioPaciente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddPaciente();
            BuscarPaciente(1);
            
        }
        private static void AddPaciente()
        {
            var paciente =new Paciente
            {
                Nombre="Adriana",
                Apellidos="Vargas",
                NumeroTelefono="3002152014",
                Genero=Genero.Femenino,
                Direccion="cra 41 22-20 sur",
                Ciudad="Bogotá"
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("Nombre: "+paciente.Nombre+" "+paciente.Apellidos+"  Género: "+paciente.Genero);
        }  
    }
}
>>>>>>> 8b331db5f3de762e9e9546d0efc251406e435797

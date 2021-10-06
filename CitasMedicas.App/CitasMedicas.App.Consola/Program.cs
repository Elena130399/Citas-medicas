using System;
using CitasMedicas.App.Dominio;
using CitasMedicas.App.Persistencia;
using System.Collections.Generic;

namespace CitasMedicas.App.Consola
{
    class Program
    {

        //private static IRepositorioPaciente _repoPaciente=new RepositorioPaciente(new Persistencia.AppContext());
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        private static IRepositorioMedico _repoMedico=new RepositorioMedico();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddPaciente();
            //BuscarPaciente(1);
            AddMedico();
            //BuscarMedico(2);
            //MostrarPacientes();
            AsignarMedico();
        }

        private static void AddPaciente()
        {
            var paciente =new Paciente
            {
                Nombre="Paciente Adriana",
                Apellidos="Vargas",
                NumeroTelefono="3002152014",
                Genero=Genero.Femenino,
                Direccion="cra 41 22-20 sur",
                Ciudad="Medellín"
            };
            _repoPaciente.AddPaciente(paciente);
        }
        
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("Nombre: "+paciente.Nombre+" "+paciente.Apellidos+"  Género: "+paciente.Genero);
        }

        private static void MostrarPacientes(){
            IEnumerable<Paciente> pacientes = _repoPaciente.GetAllPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine("Paciente: "+paciente.Nombre+" "+paciente.Apellidos);
            }

        }


        private static void AddMedico()
        {
            var medico =new Medico
            {
                Nombre="Medico nombre",
                Apellidos="Medico apellido",
                NumeroTelefono="3104295302",
                Genero=Genero.Masculino,
                Direccion="cra 41 22-20 sur",
                Especializacion="Dermatologo",
                Codigo="1234",
                RegistroMedico="RETHUS54321",
                TipoMedico="EPS"
            };
            _repoMedico.AddMedico(medico);
            Console.WriteLine("Aca ingresamos el medico bien");
        }

        private static void BuscarMedico(int idMedico)
        {
            Console.WriteLine("Aca empieza a buscar el medico");
            var medico = _repoMedico.GetMedico(idMedico);
            Console.WriteLine("Aca termina de buscar el medico");
            Console.WriteLine("Nombre: "+medico.Nombre);
            //+" "+medico.Apellidos); //+"  Género: "+medico.Genero);
        }  

        
        private static void AsignarMedico()
        {
            var medico = _repoPaciente.AsignarMedico(1, 2);
            Console.WriteLine("Se asignó el medico: "+medico.Nombre+" "+medico.Apellidos );
        }
        


    }
}
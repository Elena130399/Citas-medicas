﻿using System;
using CitasMedicas.App.Dominio;
using CitasMedicas.App.Persistencia;

namespace CitasMedicas.App.Consola
{
    class Program
    {

        private static IRepositorioPaciente _repoPaciente=new RepositorioPaciente(new Persistencia.AppContext());
        private static IRepositorioMedico _repoMedico=new RepositorioMedico(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddPaciente();
            BuscarPaciente(1);
            AddMedico();
            BuscarMedico(2);
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
                Ciudad="Medellín"
            };
            _repoPaciente.AddPaciente(paciente);
        }
        
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("Nombre: "+paciente.Nombre+" "+paciente.Apellidos+"  Género: "+paciente.Genero);
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
                Especializacion="Dermatologo"
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


    }
}
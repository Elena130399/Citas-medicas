using System;
namespace CitasMedicas.App.Dominio
{
    public class Medico:Persona
    {
        public string Codigo{get;set;}
        public Sede Sede{get;set;}
        public string Especializacion{get;set;}
        public string TipoMedico{get;set;}
        public string Agenda{get;set;}
        public string RegistroMedico{get;set;}
       
    }
}
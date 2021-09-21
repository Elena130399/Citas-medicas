using System;
namespace CitasMedicas.App.Dominio
{
    public class Paciente:Persona
    {
        public string TipoPaciente{get;set;}
        public string Historia{get;set;}
        public string Convenio{get;set;}
    }
}
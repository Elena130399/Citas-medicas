using System;

namespace CitasMedicas.App.Dominio
{
    public class Paciente:Persona
    {
        public int Id {get;set;}
        public string Ciudad{get;set;}
        public Medico Medico{get;set;}
        
    }
}
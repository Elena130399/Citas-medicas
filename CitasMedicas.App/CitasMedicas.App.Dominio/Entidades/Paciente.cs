using System;

namespace CitasMedicas.App.Dominio
{
    public class Paciente:Persona
    {

        public string Ciudad{get;set;}
        public Medico Medico{get;set;}
        
    }
}
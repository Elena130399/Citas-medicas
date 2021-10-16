using System;
using System.ComponentModel.DataAnnotations;

namespace CitasMedicas.App.Dominio
{
    public class Paciente:Persona
    {
        [Required(ErrorMessage ="Ciudad es requerida")]
        [StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public string Ciudad{get;set;}
        //public Medico Medico{get;set;}
        
    }
}
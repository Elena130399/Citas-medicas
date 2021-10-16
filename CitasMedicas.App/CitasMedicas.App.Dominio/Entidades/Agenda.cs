using System;
using System.ComponentModel.DataAnnotations;
namespace CitasMedicas.App.Dominio
{
    public class Agenda
    {
        //[Required(ErrorMessage ="Id es requerida")]
        //[StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public int Id {get;set;}
        
        public Sede Sede{get;set;}
        
        public Paciente Paciente{get;set;}
        public Medico Medico{get;set;}
        //[Required(ErrorMessage ="Nota es requerida")]
        //[StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public string Nota{get;set;}
        //[Required(ErrorMessage ="Fecha de la Cita es requerida")]
        //[StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public DateTime FechaCita{get;set;}
        
    }
}
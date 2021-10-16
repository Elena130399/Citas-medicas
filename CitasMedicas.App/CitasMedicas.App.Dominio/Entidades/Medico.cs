using System;
using System.ComponentModel.DataAnnotations;
namespace CitasMedicas.App.Dominio
{
    public class Medico:Persona
    {
        public string Codigo{get;set;}
        public Sede Sede{get;set;}
        public string Especializacion{get;set;}
        [Required(ErrorMessage ="Tipo Medico es requerido")]
        [StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public string TipoMedico{get;set;}
        public string Agenda{get;set;}
        [Required(ErrorMessage ="Registro Medico es requerido")]
        [StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public string RegistroMedico{get;set;}
        public string Ciudad{get;set;}
    }
}
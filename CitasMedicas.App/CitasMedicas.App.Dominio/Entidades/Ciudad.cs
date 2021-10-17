using System;
using System.ComponentModel.DataAnnotations;

namespace CitasMedicas.App.Dominio
{
    public class Ciudad
    {
        
        public int Id {get;set;}
        
        [Required(ErrorMessage ="Nombre es requerido")]
        [StringLength(30, ErrorMessage = "La longitud máxima es 30 caracteres") ]
        public string NombreCiudad{get;set;}
    }
}
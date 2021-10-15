using System;
using System.ComponentModel.DataAnnotations;
namespace CitasMedicas.App.Dominio
{
    public class Ciudad
    {
        public int Id {get;set;}
        [Required(ErrorMessage ="Nombre de la Ciudad es requerido")]
        [StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public string NombreCiudad{get;set;}
    }
}
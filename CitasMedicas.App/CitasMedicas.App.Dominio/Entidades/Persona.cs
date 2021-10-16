using System;
using System.ComponentModel.DataAnnotations;

namespace CitasMedicas.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;}


        [Required(ErrorMessage ="Nombre es requerido")]
        [StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public string Nombre{get;set;}
        [Required(ErrorMessage ="Apellido es requerido")]
        [StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]        
        public string Apellidos{get;set;}
        [Required(ErrorMessage ="Numero de Documento es requerido")]
        [StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public string NumDoc{get;set;}
        [Required(ErrorMessage ="Numero de telefono es requerido")]
        [StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public string NumeroTelefono{get;set;}
        //[Required(ErrorMessage ="Direccion es requerido")]
        //[StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public string Direccion{get;set;}
        [Required(ErrorMessage ="Correo es requerido")]
        [StringLength(20, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public string Correo{get;set;}
        public DateTime FechaNacimiento{get;set;}
        public Genero Genero{get;set;}
        //public bool TieneEps{get;set;}
         
    }
}
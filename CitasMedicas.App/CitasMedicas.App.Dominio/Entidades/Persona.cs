using System;
using System.ComponentModel.DataAnnotations;

namespace CitasMedicas.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;}


        [Required(ErrorMessage ="Nombre es requerido")]
        [StringLength(30, ErrorMessage = "La longitud máxima es 30 caracteres") ]
        public string Nombre{get;set;}

        [Required(ErrorMessage ="Apellido es requerido")]
        [StringLength(30, ErrorMessage = "La longitud máxima es 30 caracteres") ]       
        public string Apellidos{get;set;}
        [Required(ErrorMessage ="Numero de documento es requerido")]
        [StringLength(30, ErrorMessage = "La longitud máxima es 30 caracteres") ]
        public string NumDoc{get;set;}

        [StringLength(10, ErrorMessage = "Longitud máxima para telefono es de 10 caracteres") ]
        public string NumeroTelefono{get;set;}
        public string Direccion{get;set;}

        [Required(ErrorMessage ="Correo es requerido")]
        [StringLength(50, ErrorMessage = "La longitud máxima es 50 caracteres") ]
        public string Correo{get;set;}
        public DateTime FechaNacimiento{get;set;}
        public Genero Genero{get;set;}
        //public bool TieneEps{get;set;}
         
    }
}
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

        [Required(ErrorMessage ="Número de documento requerido")]
        [StringLength(30, ErrorMessage = "La longitud máxima es 30 caracteres") ]        
        public string NumDoc{get;set;}
        public string NumeroTelefono{get;set;}
        public string Direccion{get;set;}
        [Required(ErrorMessage ="Correo es requerido")]
        [StringLength(30, ErrorMessage = "La longitud máxima es 30 caracteres") ]        
        public string Correo{get;set;}
        public DateTime FechaNacimiento{get;set;}
        public Genero Genero{get;set;}
        //public bool TieneEps{get;set;}
         
    }
}
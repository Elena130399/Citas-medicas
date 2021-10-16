using System;
using System.ComponentModel.DataAnnotations;

namespace CitasMedicas.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;}


        [Required(ErrorMessage ="Nombre es requerido")]
        [StringLength(50, ErrorMessage = "La longitud máxima es 20 caracteres") ]
        public string Nombre{get;set;}
        
        public string Apellidos{get;set;}
        public string NumDoc{get;set;}
        public string NumeroTelefono{get;set;}
        public string Direccion{get;set;}
        public string Correo{get;set;}
        public DateTime FechaNacimiento{get;set;}
        public Genero Genero{get;set;}
        //public bool TieneEps{get;set;}
         
    }
}
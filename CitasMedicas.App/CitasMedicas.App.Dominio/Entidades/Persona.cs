using System;
using System.ComponentModel.DataAnnotations;
namespace CitasMedicas.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;}
        public string Nombre{get;set;}
        [Required, StringLength(30)]
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
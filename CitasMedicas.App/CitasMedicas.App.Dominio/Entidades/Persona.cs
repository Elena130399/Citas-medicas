using System;
namespace CitasMedicas.App.Dominio
{
    public class Persona
    {
        public int Id {get;set;}
        public string Nombre{get;set;}
<<<<<<< HEAD
        public string NumDoc{get;set;}
        public string NumTelefono{get;set;}
=======
        public string Apellidos{get;set;}
        public string NumDoc{get;set;}
        public string NumeroTelefono{get;set;}
>>>>>>> 8b331db5f3de762e9e9546d0efc251406e435797
        public string Direccion{get;set;}
        public string Correo{get;set;}
        public string FechaNacimiento{get;set;}
        public Genero Genero{get;set;}
    }
}
using System;
namespace CitasMedicas.App.Dominio
{
    public class Usuario:Persona
    {
        public string TipoUsuario{get;set;}
        public string NomUsuario{get;set;}
        public string Contraseña{get;set;}
    }
}
using System;
using System.Collections.Generic;
using CitasMedicas.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
    public interface IRepositorioSede
    {
        IEnumerable<Sede> GetAllSedes(); //metodo que retorna todos los sedes
        Sede AddSede(Sede sede);
        Sede UpdateSede(Sede sede);
        void DeleteSede(int idSede);
        Sede GetSede(int idSede);
        Ciudad AsignarCiudad(int idSede, int idCiudad);
    }
}
//Interfaz: Conjunto de métodos-encabe

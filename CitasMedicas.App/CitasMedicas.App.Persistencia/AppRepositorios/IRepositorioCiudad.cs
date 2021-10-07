using System;
using System.Collections.Generic;
using CitasMedicas.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
    public interface IRepositorioCiudad
    {
        IEnumerable<Ciudad> GetAllCiudades(); //metodo que retorna todos los ciudads
        Ciudad AddCiudad(Ciudad ciudad);
        Ciudad UpdateCiudad(Ciudad ciudad);
        void DeleteCiudad(int idCiudad);
        Ciudad GetCiudad(int idCiudad);
        //Sede AsignarSede(int idCiudad, int idSede);
    }
}
//Interfaz: Conjunto de métodos-encabe

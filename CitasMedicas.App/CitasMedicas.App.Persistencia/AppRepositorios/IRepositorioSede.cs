using System;
using System.Collections.Generic;
using CitasMedicas.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
    public interface IRepositorioSede
    {
        IEnumerable<Sede> GetAllSedes(); //metodo que retorna todos los ciudads
        Sede AddSede(Sede ciudad);
        Sede UpdateSede(Sede ciudad);
        void DeleteSede(int idSede);
        Sede GetSede(int idSede);
        //Sede AsignarSede(int idSede, int idSede);
    }
}
//Interfaz: Conjunto de métodos-encabe

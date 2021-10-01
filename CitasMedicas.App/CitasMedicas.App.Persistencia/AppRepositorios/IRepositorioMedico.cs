using System;
using System.Collections.Generic;
using CitasMedicas.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
    public interface IRepositorioMedico
    {
        IEnumerable<Medico> GetAllMedicos(); //metodo que retorna todos los medicos
        Medico AddMedico(Medico medico);
        Medico UpdateMedico(Medico medico);
        void DeleteMedico(int idMedico);
        Medico GetMedico(int idMedico);
    }
}
//Interfaz: Conjunto de métodos-encabe

using System;
using System.Collections.Generic;
using CitasMedicas.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
    public interface IRepositorioAgenda
    {
        IEnumerable<Agenda> GetAllAgendas(); //metodo que retorna todos los agendas
        Agenda AddAgenda(Agenda agenda);
        Agenda UpdateAgenda(Agenda agenda);
        void DeleteAgenda(int idAgenda);
        Agenda GetAgenda(int idAgenda);
        Medico AsignarMedico(int idAgenda, int idMedico);
    }
}
//Interfaz: Conjunto de métodos-encabe

using System;
using System.Collections.Generic;
using System.Linq;
using CitasMedicas.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
     public class RepositorioAgenda : IRepositorioAgenda
     {

          private readonly AppContext _appContext = new AppContext();

          Agenda IRepositorioAgenda.AddAgenda(Agenda agenda)
          {
            var agendaAdicionado= _appContext.Agendas.Add(agenda);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return agendaAdicionado.Entity; 
          }

          void IRepositorioAgenda.DeleteAgenda(int idAgenda)
          {
            var agendaEncontrada= _appContext.Agendas.FirstOrDefault(p =>p.Id==idAgenda);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if(agendaEncontrada==null)
            return;
            _appContext.Agendas.Remove(agendaEncontrada);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }

          IEnumerable <Agenda> IRepositorioAgenda.GetAllAgendas  ()
          {
            return _appContext.Agendas;
             
          }

        Agenda IRepositorioAgenda.GetAgenda  (int idAgenda)
          {
           return _appContext.Agendas.FirstOrDefault(p =>p.Id==idAgenda);//retorna lo que encuentra
          }

        Agenda IRepositorioAgenda.UpdateAgenda  (Agenda agenda)
          {
           var agendaEncontrada= _appContext.Agendas.FirstOrDefault(p =>p.Id==agenda.Id);
           //No se busca el idAgenda, se busca el agenda.Id
           if(agendaEncontrada!=null)
           {
                agendaEncontrada.Sede=agenda.Sede;
                agendaEncontrada.Paciente=agenda.Paciente;
                agendaEncontrada.Medico=agenda.Medico;
                agendaEncontrada.Nota=agenda.Nota;
                agendaEncontrada.FechaCita=agenda.FechaCita;
                _appContext.SaveChanges();        
           }
             return agendaEncontrada; //retorna el agenda encontrado


          }

        /*Agenda IRepositorioAgenda.AsignarMedico (int idAgenda, int idMedico)
        {
          var agendaEncontrada = _appContext.Agendas.Find(idAgenda);
          if (agendaEncontrada != null)
          {
            var medicoEncontrado = _appContext.Medicos.Find(idMedico);
            if (medicoEncontrado != null)
            {
              agendaEncontrada.Medico = medicoEncontrado;
              _appContext.SaveChanges();
            }
            return medicoEncontrado;

          }

        }*/

       
        Medico IRepositorioAgenda.AsignarMedico(int idAgenda, int idMedico)
        {
            var agendaEncontrada = _appContext.Agendas.FirstOrDefault(p => p.Id == idAgenda);
            if (agendaEncontrada != null)
            {
                var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
                if (medicoEncontrado != null)
                {
                    agendaEncontrada.Medico = medicoEncontrado;
                    _appContext.SaveChanges();
                }
                return medicoEncontrado;
            }
            return null;

        }

        






     }
}
// implementa la interfaz
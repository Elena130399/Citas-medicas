using System;
using System.Collections.Generic;
using System.Linq;
using CitasMedicas.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
     public class RepositorioCiudad : IRepositorioCiudad
     {

          private readonly AppContext _appContext = new AppContext();

          Ciudad IRepositorioCiudad.AddCiudad(Ciudad ciudad)
          {
            var ciudadAdicionado= _appContext.Ciudades.Add(ciudad);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return ciudadAdicionado.Entity; 
          }

          void IRepositorioCiudad.DeleteCiudad(int idCiudad)
          {
            var ciudadEncontrado= _appContext.Ciudades.FirstOrDefault(p =>p.Id==idCiudad);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if(ciudadEncontrado==null)
            return;
            _appContext.Ciudades.Remove(ciudadEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }

          IEnumerable <Ciudad> IRepositorioCiudad.GetAllCiudades  ()
          {
            return _appContext.Ciudades;
             
          }

        Ciudad IRepositorioCiudad.GetCiudad  (int idCiudad)
          {
           return _appContext.Ciudades.FirstOrDefault(p =>p.Id==idCiudad);//retorna lo que encuentra
          }

        Ciudad IRepositorioCiudad.UpdateCiudad  (Ciudad ciudad)
          {
           var ciudadEncontrado= _appContext.Ciudades.FirstOrDefault(p =>p.Id==ciudad.Id);
           //No se busca el idCiudad, se busca el ciudad.Id
           if(ciudadEncontrado!=null)
           {
                ciudadEncontrado.NombreCiudad=ciudad.NombreCiudad;
                
                _appContext.SaveChanges();        
           }
             return ciudadEncontrado; //retorna el ciudad encontrado
            
          }

        /*Ciudad IRepositorioCiudad.AsignarMedico (int idCiudad, int idMedico)
        {
          var ciudadEncontrado = _appContext.Ciudads.Find(idCiudad);
          if (ciudadEncontrado != null)
          {
            var medicoEncontrado = _appContext.Medicos.Find(idMedico);
            if (medicoEncontrado != null)
            {
              ciudadEncontrado.Medico = medicoEncontrado;
              _appContext.SaveChanges();
            }
            return medicoEncontrado;

          }

        }*/

       /*
        Medico IRepositorioCiudad.AsignarMedico(int idCiudad, int idMedico)
        {
            var ciudadEncontrado = _appContext.Ciudades.FirstOrDefault(p => p.Id == idCiudad);
            if (ciudadEncontrado != null)
            {
                var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedico);
                if (medicoEncontrado != null)
                {
                    ciudadEncontrado.Medico = medicoEncontrado;
                    _appContext.SaveChanges();
                }
                return medicoEncontrado;
            }
            return null;

        }
        */






     }
}
// implementa la interfaz
using System;
using System.Collections.Generic;
using System.Linq;
using CitasMedicas.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
     public class RepositorioSede : IRepositorioSede
     {

          private readonly AppContext _appContext = new AppContext();

          Sede IRepositorioSede.AddSede(Sede sede)
          {
            var sedeAdicionado= _appContext.Sedes.Add(sede);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return sedeAdicionado.Entity; 
          }

          void IRepositorioSede.DeleteSede(int idSede)
          {
            var sedeEncontrado= _appContext.Sedes.FirstOrDefault(p =>p.Id==idSede);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if(sedeEncontrado==null)
            return;
            _appContext.Sedes.Remove(sedeEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }

          IEnumerable <Sede> IRepositorioSede.GetAllSedes  ()
          {
            return _appContext.Sedes;
             
          }

        Sede IRepositorioSede.GetSede  (int idSede)
          {
           return _appContext.Sedes.FirstOrDefault(p =>p.Id==idSede);//retorna lo que encuentra
          }

        Sede IRepositorioSede.UpdateSede  (Sede sede)
          {
           var sedeEncontrado= _appContext.Sedes.FirstOrDefault(p =>p.Id==sede.Id);
           //No se busca el idSede, se busca el sede.Id
           if(sedeEncontrado!=null)
           {
                sedeEncontrado.NombreSede=sede.NombreSede;
                
                _appContext.SaveChanges();        
           }
             return sedeEncontrado; //retorna el sede encontrado
            
          }

        Ciudad IRepositorioSede.AsignarCiudad(int idSede, int idCiudad)
        {
            var sedeEncontrada = _appContext.Sedes.FirstOrDefault(p => p.Id == idSede);
            if (sedeEncontrada != null)
            {
                var ciudadEncontrada = _appContext.Ciudades.FirstOrDefault(m => m.Id == idCiudad);
                if (ciudadEncontrada != null)
                {
                    sedeEncontrada.Ciudad = ciudadEncontrada;
                    _appContext.SaveChanges();
                }
                return ciudadEncontrada;
            }
            return null;

        }


     }
}

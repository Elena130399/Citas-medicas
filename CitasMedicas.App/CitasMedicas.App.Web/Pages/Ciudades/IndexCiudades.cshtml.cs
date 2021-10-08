using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CitasMedicas.App.Dominio;
using CitasMedicas.App.Persistencia;

namespace CitasMedicas.App.Web.Pages
{
    public class IndexCiudadesModel : PageModel
    {
        private readonly IRepositorioCiudad _repoCiudad=new RepositorioCiudad();

        public IEnumerable<Ciudad> ciudades {get;set;}
        public IndexCiudadesModel(IRepositorioCiudad repoCiudad)
        {
            _repoCiudad = repoCiudad;
        } 

        public void OnGet()
        {
            ciudades = _repoCiudad.GetAllCiudades();
        }
    }
}

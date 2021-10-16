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
    public class AddCiudadModel : PageModel
    {
        private readonly IRepositorioSede _repoSede;
        private readonly IRepositorioCiudad _repoCiudad;
        public Sede sede {get;set;}
        public IEnumerable<Ciudad> ciudades {get;set;}

        public AddCiudadModel(IRepositorioSede repoSede, IRepositorioCiudad repoCiudad)
        {
            _repoSede=repoSede;
            _repoCiudad=repoCiudad;
        }

        public void OnGet(int id)
        {
            sede = _repoSede.GetSede(id);
            ciudades = _repoCiudad.GetAllCiudades();
        }

        public IActionResult OnPost(int IdSede, int idCiudad)
        {
            _repoSede.AsignarCiudad(IdSede, idCiudad);
            return RedirectToPage("./IndexSedes");
        }



    }
}

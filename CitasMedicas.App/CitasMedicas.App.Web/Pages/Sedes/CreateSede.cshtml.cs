using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CitasMedicas.App.Dominio;
using CitasMedicas.App.Persistencia;

namespace CitasMedicas.App.Web.Pages.Sedes
{
    public class CreateSedeModel : PageModel
    {
        private readonly IRepositorioSede _repoSede=new RepositorioSede();
        private readonly IRepositorioCiudad _repoCiudad;


        public Sede sede {get;set;}
        public IEnumerable<Ciudad> ciudades {get;set;}
        public CreateSedeModel(IRepositorioSede repoSede, IRepositorioCiudad repoCiudad)
        {
            _repoSede = repoSede;
            _repoCiudad = repoCiudad;
        } 

        public void OnGet()
        {
            sede = new Sede();
            ciudades = _repoCiudad.GetAllCiudades();
        }
        public IActionResult OnPost(Sede sede)
        {
            if (ModelState.IsValid)
            {
                _repoSede.AddSede(sede);
                return RedirectToPage("IndexSedes");


            }else
            {
                return Page();
            }



        }
    }
}

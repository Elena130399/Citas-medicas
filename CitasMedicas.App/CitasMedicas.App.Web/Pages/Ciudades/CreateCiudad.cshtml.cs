using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CitasMedicas.App.Dominio;
using CitasMedicas.App.Persistencia;

namespace CitasMedicas.App.Web.Pages.Ciudades
{
    public class CreateCiudadModel : PageModel
    {
        private readonly IRepositorioCiudad _repoCiudad=new RepositorioCiudad();

        public Ciudad ciudad {get;set;}
        public CreateCiudadModel(IRepositorioCiudad repoCiudad)
        {
            _repoCiudad = repoCiudad;
        } 

        public void OnGet()
        {
            ciudad = new Ciudad();
        }
        public IActionResult OnPost(Ciudad ciudad)
        {
            if (ModelState.IsValid)
            {
                _repoCiudad.AddCiudad(ciudad);
                return RedirectToPage("IndexCiudades");


            }else
            {
                return Page();
            }



        }
    }
}

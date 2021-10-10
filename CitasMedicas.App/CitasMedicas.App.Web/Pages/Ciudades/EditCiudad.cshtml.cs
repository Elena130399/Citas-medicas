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
    public class EditCiudadModel : PageModel
    {
        private readonly IRepositorioCiudad _repoCiudad=new RepositorioCiudad();

        public Ciudad ciudad {get;set;}
        public EditCiudadModel(IRepositorioCiudad repoCiudad)
        {
            _repoCiudad = repoCiudad;
        } 


        public IActionResult OnGet(int id)
        {
            
            ciudad = _repoCiudad.GetCiudad(id);
            
            if(ciudad == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }

        }



        public IActionResult OnPost(Ciudad ciudad)
        {
          
            _repoCiudad.UpdateCiudad(ciudad);
            return RedirectToPage("IndexCiudades");
            
        }

    }
}

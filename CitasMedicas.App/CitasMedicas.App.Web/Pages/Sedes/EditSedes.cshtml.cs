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
    public class EditSedeModel : PageModel
    {
        private readonly IRepositorioSede _repoSede=new RepositorioSede();

        public Sede sede {get;set;}
        public EditSedeModel(IRepositorioSede repoSede)
        {
            _repoSede = repoSede;
        } 


        public IActionResult OnGet(int id)
        {
            
            sede = _repoSede.GetSede(id);
            
            if(sede == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }

        }



        public IActionResult OnPost(Sede sede)
        {
          
            _repoSede.UpdateSede(sede);
            return RedirectToPage("IndexSedes");
            
        }

    }
}

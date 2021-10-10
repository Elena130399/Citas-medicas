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
    public class DeleteSedeModel : PageModel
    {
        private readonly IRepositorioSede _repoSede=new RepositorioSede();

        public Sede sede {get;set;}
        public DeleteSedeModel(IRepositorioSede repoSede)
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
                //delete
                _repoSede.DeleteSede(sede.Id);
                //return Page();
                return RedirectToPage("IndexSedes");
            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CitasMedicas.App.Dominio;
using CitasMedicas.App.Persistencia;


namespace CitasMedicas.App.Web.Pages.Medicos
{
    public class EditMedicoModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico=new RepositorioMedico();

        public Medico medico {get;set;}
        public EditMedicoModel(IRepositorioMedico repoMedico)
        {
            _repoMedico = repoMedico;
        } 


        public IActionResult OnGet(int id)
        {
            
            medico = _repoMedico.GetMedico(id);
            
            if(medico == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }

        }



        public IActionResult OnPost(Medico medico)
        {
          
            _repoMedico.UpdateMedico(medico);
            return RedirectToPage("IndexMedicos");
            
        }

    }
}

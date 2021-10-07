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
    public class CreateMedicoModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico=new RepositorioMedico();

        public Medico medico {get;set;}
        public CreateMedicoModel(IRepositorioMedico repoMedico)
        {
            _repoMedico = repoMedico;
        } 

        public void OnGet()
        {
            medico = new Medico();
        }
        public IActionResult OnPost(Medico medico)
        {
            if (ModelState.IsValid)
            {
                _repoMedico.AddMedico(medico);
                return RedirectToPage("IndexMedicos");


            }else
            {
                return Page();
            }



        }
    }
}

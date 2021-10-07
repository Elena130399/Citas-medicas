using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CitasMedicas.App.Dominio;
using CitasMedicas.App.Persistencia;


namespace CitasMedicas.App.Web.Pages.Pacientes
{
    public class CreatePacientesModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente=new RepositorioPaciente();

        public Paciente paciente {get;set;}
        public CreatePacientesModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente = repoPaciente;
        } 

        public void OnGet()
        {
            paciente = new Paciente();
        }

        public IActionResult OnPost(Paciente paciente)
        {
            if (ModelState.IsValid)
            {
                _repoPaciente.AddPaciente(paciente);
                return RedirectToPage("Index1");


            }else
            {
                return Page();
            }



        }

    }
}

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
    public class DeletePacienteModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente=new RepositorioPaciente();

        public Paciente paciente {get;set;}
        public DeletePacienteModel(IRepositorioPaciente repoPaciente)
        {
            _repoPaciente = repoPaciente;
        } 


        public IActionResult OnGet(int id)
        {
            
            paciente = _repoPaciente.GetPaciente(id);
            
            if(paciente == null)
            {
                return NotFound();
            }else
            {
                //delete
                _repoPaciente.DeletePaciente(paciente.Id);
                //return Page();
                return RedirectToPage("Index1");
            }

        }


    }
}

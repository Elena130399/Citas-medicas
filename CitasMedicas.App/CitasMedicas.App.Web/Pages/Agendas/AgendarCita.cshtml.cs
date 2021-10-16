using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CitasMedicas.App.Dominio;
using CitasMedicas.App.Persistencia;


namespace CitasMedicas.App.Web.Pages.Agendas
{
    public class AgendarCitaModel : PageModel
    {
        private readonly IRepositorioAgenda _repoAgenda=new RepositorioAgenda();
        private readonly IRepositorioMedico _repoMedico;
        private readonly IRepositorioPaciente _repoPaciente;

        public Agenda agenda {get;set;}
        public IEnumerable<Medico> medicos {get;set;}
        public IEnumerable<Paciente> pacientes {get;set;}

        public AgendarCitaModel(IRepositorioAgenda repoAgenda, IRepositorioMedico repoMedico,  IRepositorioPaciente repoPaciente)
        {
            _repoAgenda = repoAgenda;
            _repoMedico=repoMedico;
            _repoPaciente=repoPaciente;
        } 

        public void OnGet()
        {
            agenda = new Agenda();
            medicos = _repoMedico.GetAllMedicos();
            pacientes = _repoPaciente.GetAllPacientes();
        }

        public IActionResult OnPost(Agenda agenda)
        {
            if (ModelState.IsValid)
            {
                _repoAgenda.AddAgenda(agenda);
                return RedirectToPage("IndexAgendas");
                

            }else
            {
                return Page();
            }



        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CitasMedicas.App.Dominio;
using CitasMedicas.App.Persistencia;


namespace CitasMedicas.App.Web.Pages
{
    public class AddMedicoModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;
        private readonly IRepositorioMedico _repoMedico;
        public Paciente paciente {get;set;}
        public IEnumerable<Medico> medicos {get;set;}

        public AddMedicoModel(IRepositorioPaciente repoPaciente, IRepositorioMedico repoMedico)
        {
            _repoPaciente=repoPaciente;
            _repoMedico=repoMedico;
        }

        public void OnGet(int id)
        {
            paciente = _repoPaciente.GetPaciente(id);
            medicos = _repoMedico.GetAllMedicos();
        }

        public IActionResult OnPost(int IdPaciente, int idMedico)
        {
            _repoPaciente.AsignarMedico(IdPaciente, idMedico);
            return RedirectToPage("PacienteDetalles", new {id=IdPaciente});
        }



    }
}

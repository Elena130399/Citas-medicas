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
    public class IndexMedicosModel : PageModel
    {
        private readonly IRepositorioMedico _repoMedico=new RepositorioMedico();

        public IEnumerable<Medico> medicos {get;set;}
        public IndexMedicosModel(IRepositorioMedico repoMedico)
        {
            _repoMedico = repoMedico;
        } 

        public void OnGet()
        {
            medicos = _repoMedico.GetAllMedicos();
        }
    }
}

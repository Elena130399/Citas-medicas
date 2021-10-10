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
    public class IndexSedesModel : PageModel
    {
        private readonly IRepositorioSede _repoSede=new RepositorioSede();

        public IEnumerable<Sede> sedes {get;set;}
        public IndexSedesModel(IRepositorioSede repoSede)
        {
            _repoSede = repoSede;
        } 

        public void OnGet()
        {
            sedes = _repoSede.GetAllSedes();
        }
    }
}

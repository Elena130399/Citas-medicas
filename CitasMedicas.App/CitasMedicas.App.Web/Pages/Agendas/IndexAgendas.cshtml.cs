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
    public class IndexAgendasModel : PageModel
    {
        private readonly IRepositorioAgenda _repoAgenda=new RepositorioAgenda();

        public IEnumerable<Agenda> agendas {get;set;}
        public IndexAgendasModel(IRepositorioAgenda repoAgenda)
        {
            _repoAgenda = repoAgenda;
        } 

        public void OnGet()
        {
            agendas = _repoAgenda.GetAllAgendas();
        }
    }
}

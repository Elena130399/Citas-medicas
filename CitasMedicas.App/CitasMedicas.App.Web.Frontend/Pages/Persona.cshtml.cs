using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CitasMedicas.App.Web.Frontend.Pages
{
    public class Persona : PageModel
    {
        private readonly ILogger<Persona> _logger;

        public Persona(ILogger<Persona> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}

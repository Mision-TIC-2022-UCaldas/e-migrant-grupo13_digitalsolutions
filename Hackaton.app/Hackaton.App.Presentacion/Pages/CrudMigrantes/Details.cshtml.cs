using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hackaton.App.Dominio.Entidades;
using Hackaton.App.Persistencia;

namespace Hackaton.App.Presentacion.Pages.CrudMigrantes
{
    public class DetailsModel : PageModel
    {
        private readonly Hackaton.App.Persistencia.Conexion _context;

        public DetailsModel(Hackaton.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public Migrante Migrante { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Migrante = await _context.Migrantes.FirstOrDefaultAsync(m => m.Id == id);

            if (Migrante == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

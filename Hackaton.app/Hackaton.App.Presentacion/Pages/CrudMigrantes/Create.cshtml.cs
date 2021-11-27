using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hackaton.App.Dominio.Entidades;
using Hackaton.App.Persistencia;

namespace Hackaton.App.Presentacion.Pages.CrudMigrantes
{
    public class CreateModel : PageModel
    {
        private readonly Hackaton.App.Persistencia.Conexion _context;

        public CreateModel(Hackaton.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Migrante Migrante { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Migrantes.Add(Migrante);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Hackaton.App.Dominio.Entidades;
using Hackaton.App.Persistencia;

namespace Hackaton.App.Presentacion.Pages.CrudMigrante
{
    public class EditModel : PageModel
    {
        private readonly Hackaton.App.Persistencia.Conexion _context;

        public EditModel(Hackaton.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Migrante).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MigranteExists(Migrante.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MigranteExists(int id)
        {
            return _context.Migrantes.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Hackaton.App.Dominio.Entidades;
using Hackaton.App.Persistencia;

namespace Hackaton.App.Presentacion.Pages.CrudEntidad
{
    public class DeleteModel : PageModel
    {
        private readonly Hackaton.App.Persistencia.Conexion _context;

        public DeleteModel(Hackaton.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        [BindProperty]
        public Entidad Entidad { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Entidad = await _context.Entidades.FirstOrDefaultAsync(m => m.Id == id);

            if (Entidad == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Entidad = await _context.Entidades.FindAsync(id);

            if (Entidad != null)
            {
                _context.Entidades.Remove(Entidad);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

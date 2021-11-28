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
    public class IndexModel : PageModel
    {
        private readonly Hackaton.App.Persistencia.Conexion _context;

        public IndexModel(Hackaton.App.Persistencia.Conexion context)
        {
            _context = context;
        }

        public IList<Entidad> Entidad { get;set; }

        public async Task OnGetAsync()
        {
            Entidad = await _context.Entidades.ToListAsync();
        }
    }
}

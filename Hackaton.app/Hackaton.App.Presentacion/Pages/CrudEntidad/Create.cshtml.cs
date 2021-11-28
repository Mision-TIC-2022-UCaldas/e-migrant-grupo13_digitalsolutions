using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hackaton.App.Dominio.Entidades;
using Hackaton.App.Persistencia;
using Microsoft.AspNetCore.Http;

namespace Hackaton.App.Presentacion.Pages.CrudEntidad
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
        public Entidad Entidad { get; set; }

        [BindProperty]
        public string MensajeNit { get; set; }

        

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            Conexion conexion = new Conexion();
            Entidad entidad = conexion.Entidades.FirstOrDefault(e => e.Nit == Entidad.Nit);
            
             if(entidad != null){
                
                if(entidad.Nit.Equals(Entidad.Nit)){
                    HttpContext.Session.SetString("nit", Entidad.Nit);
                    MensajeNit = "El Nit ingresado ya existe";
                    return Page();
                    }       
                else{
                    MensajeNit = "Nit correcto";
                }  

                 }else{
                MensajeNit = "Nit correcto";
               
            }





            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Entidades.Add(Entidad);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Hackaton.App.Persistencia;
using Hackaton.App.Dominio.Entidades;

namespace Hackaton.App.Presentacion.Pages
{
    public class CambioPasswordModel : PageModel
    {

        [BindProperty]
        public string Contrasenia { get; set; }
        [BindProperty]
        public string RepeatContrasenia { get; set; }
        [BindProperty]
        public string MensajePassword { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            Conexion conexion = new Conexion();
            var User = HttpContext.Session.GetString("username");
            Migrante migrante = conexion.Migrantes.FirstOrDefault(e => e.Usuario == User);

            if(!Contrasenia.Equals(RepeatContrasenia)){
                MensajePassword = "Las contraseñas no coinciden";
                //return Page();
            }else{
                migrante.Password = Contrasenia;
                conexion.SaveChanges();
                Response.Redirect("/CrudMigrante/Index");
                //return RedirectToPage("../Index");
            }
        }
        



    }
}

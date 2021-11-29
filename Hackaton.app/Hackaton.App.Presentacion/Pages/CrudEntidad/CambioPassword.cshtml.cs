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
    public class CambioPasswordModel2 : PageModel
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
            var User = HttpContext.Session.GetString("username2");
            Entidad entidad = conexion.Entidades.FirstOrDefault(e => e.Usuario == User);

            if(!Contrasenia.Equals(RepeatContrasenia)){
                MensajePassword = "Las contraseñas no coinciden";
                //return Page();
            }else{
                entidad.Password = Contrasenia;
                conexion.SaveChanges();
                Response.Redirect("/CrudEntidad/Details?id="+entidad.Id);
                //return RedirectToPage("../Index");
            }
        }
        



    }
}

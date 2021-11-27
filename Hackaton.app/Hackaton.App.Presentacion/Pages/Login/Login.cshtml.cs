using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hackaton.App.Dominio.Entidades;
using Hackaton.App.Persistencia;
using Microsoft.AspNetCore.Http;


namespace Hackaton.App.Presentacion.Pages
{
    public class LoginModel : PageModel
    {

        [BindProperty]
        public string User { get; set; }

        [BindProperty]
        public string Contrasenia { get; set; }

        [BindProperty]
        public string MensajeUsuario { get; set; }

        [BindProperty]
        public string MensajePassword { get; set; }

        [BindProperty]
        public bool UsuarioAutenticado {get; set;}


        public void OnGet()
        {
            /*var usuarioAutenticado = HttpContext.Session.GetString("usuarioAutenticado");
            if(usuarioAutenticado != null){
                UsuarioAutenticado = true;
            }else{
                UsuarioAutenticado = false;
            }*/

        }

        public IActionResult OnPost(){
            Conexion conexion = new Conexion();
            Migrante migrante = conexion.Migrantes.FirstOrDefault(e => e.Usuario == User);
            if(migrante != null){
                
                if(migrante.Password.Equals(Contrasenia)){
                    Response.Redirect("/CrudMigrante/Index");
                    return Page();
                    }       
                else{
                    MensajePassword = "El password no coincide";
                    return Page();
                }  

                 }else{
                MensajeUsuario = "Usuario no ha sido encontrado";
                return Page();
            }
 


           
            
        }
    }
}

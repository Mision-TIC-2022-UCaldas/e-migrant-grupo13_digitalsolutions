using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hackaton.App.Dominio.Entidades;
using Hackaton.App.Persistencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hackaton.App.Presentacion.Pages
{
    public class LoginEntidadesModel : PageModel
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

        [BindProperty]
        public Entidad Entidad { get; set; }
        public void OnGet()
        {
        }
          

        public IActionResult OnPost(){
            Conexion conexion = new Conexion();
            Entidad entidad = conexion.Entidades.FirstOrDefault(e => e.Usuario == User);
            if(entidad != null){
                
                if(entidad.Password.Equals(Contrasenia)){
                    HttpContext.Session.SetString("username", User);
                    Response.Redirect("/CrudEntidad/Details?id="+ entidad.Id);
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

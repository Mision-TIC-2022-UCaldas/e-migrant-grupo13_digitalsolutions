using System;
using System.ComponentModel.DataAnnotations;

namespace Hackaton.App.Dominio.Entidades
{
    public class Entidad
    {
       
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string RazonSocial { get; set; }
        [Required, StringLength(50)]
        public string Nit { get; set; }
        [Required, StringLength(30)]
        public string Direccion { get; set; }
        [Required, StringLength(11)]
        public string Ciudad { get; set; }
        public string DireccionElectronica { get; set; }
        public string PaginaWeb { get; set; }
        [Required]
        public Sector Sector { get; set; }
        [Required]
        public ServiciosOfrece ServiciosOfrece { get; set; }
        
    }
}
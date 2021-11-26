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
        [Required, StringLength(11)]
        public string DireccionElectronica { get; set; }
        public string PaginaWeb { get; set; }
        [Required, StringLength(30)]
        public string Sector { get; set; }
         [Required, StringLength(30)]
        public string ServiciosOfrece { get; set; }
        
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace Hackaton.App.Dominio.Entidades
{
    public class Migrante
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Nombres { get; set; }
        [Required, StringLength(50)]
        public string Apellidos { get; set; }
        [Required, StringLength(30)]
        public string TipoDocumento { get; set; }
        [Required, StringLength(11)]
        public string NumeroDocumento { get; set; }
        [Required, StringLength(11)]
        public string PaisOrigen { get; set; }
        [Required, StringLength(11)]
        public string FechaNacimiento { get; set; }
        public string DireccionElectronica { get; set; }
        public string NumeroTelefono { get; set; }
        public string DireccionActual { get; set; }
        public string Ciudad { get; set; }
        public string SituacionLaboral { get; set; }

    }
}

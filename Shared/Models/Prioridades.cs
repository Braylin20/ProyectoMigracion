using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shared.Models
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Descripcion { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int DiasCompromiso { get; set; }
        [ForeignKey("PrioridadId")]
        public ICollection<Tickets> Tickets { get; set; } = new List<Tickets>();
    }
}

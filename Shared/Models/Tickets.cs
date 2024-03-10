using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Tickets
    {
        [Key]
        public int TicketId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int? ClientesId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public int? PrioridadesId { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public DateTime Fecha { get; set; }
        
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? SolicitadoPor { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Asunto { get; set; }
        [Required(ErrorMessage = "Este campo es requerido")]
        public string? Descripcion { get; set; }
        [ForeignKey("TicketId")]
        public ICollection<TicketDetalle> TicketDetalle { get; set; } = new List<TicketDetalle>();
    }
}

using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace ProyectoMigracion.Api.Dal
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { }
        public DbSet<Prioridades> Prioridades { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<TicketDetalle> TicketsDetalle { get; set; }
    }
}

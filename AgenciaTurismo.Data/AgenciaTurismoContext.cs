using AgenciaTurismo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgenciaTurismo.Data
{
    public class AgenciaTurismoContext : DbContext
    {
        public AgenciaTurismoContext(DbContextOptions<AgenciaTurismoContext> options)
            : base(options)
        {
        }

        public DbSet<PacoteTuristico> PacotesTuristicos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Hotel> Hoteis { get; set; }
		public DbSet<Endereco> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PacoteTuristico>()
                .HasMany(p => p.Reservas)
                .WithOne(r => r.PacoteTuristico)
                .HasForeignKey(r => r.PacoteTuristicoId);
            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Cliente)
                .WithMany(c => c.Reservas)
                .HasForeignKey(r => r.ClienteId);
			modelBuilder.Entity<Hotel>()
            	.HasOne(h => h.Endereco)
            	.WithMany()
            	.HasForeignKey("EnderecoId"); 
        }
    }
}

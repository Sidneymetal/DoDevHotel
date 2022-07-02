using Microsoft.EntityFrameworkCore;
using DoDevHotel.Lib.Models;

namespace DoDevHotel.Lib.Context
{
    public class DoDevHotelContext : DbContext
    {
        public DoDevHotelContext(DbContextOptions context) : base(context)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estadia>().ToTable("ht_estadia");
            modelBuilder.Entity<Estadia>().HasKey(x => x.Id);
            modelBuilder.Entity<Estadia>().HasOne(x => x.id_responsavel);
            modelBuilder.Entity<Estadia>().HasOne(x => x.id_quarto);
            
            modelBuilder.Entity<EstadiaXHospede>().ToTable("ht_estadia_x_hospede");
            modelBuilder.Entity<EstadiaXHospede>().HasKey(x => x.Id);
            modelBuilder.Entity<EstadiaXHospede>().HasOne(x => x.);
            modelBuilder.Entity<EstadiaXHospede>().HasOne(x => x.id_hospede);

            modelBuilder.Entity<Hospede>().ToTable("ht_hospede");
            modelBuilder.Entity<Hospede>().HasKey(x => x.Id);

            modelBuilder.Entity<Hotel>().ToTable("ht_hotel");
            modelBuilder.Entity<Hotel>().HasKey(x => x.Id);

            modelBuilder.Entity<Quarto>().ToTable("ht_quarto");
            modelBuilder.Entity<Quarto>().HasKey(x => x.Id);
            modelBuilder.Entity<Quarto>().HasOne(x => x.id_hotel).WithMany(x => Quartos).HasForeignKey(x => x.id_hotel);

            modelBuilder.Entity<Servico>().ToTable("ht_servico");
            modelBuilder.Entity<Servico>().HasKey(x => x.Id);

            modelBuilder.Entity<ServicoXHotel>().ToTable("ht_servico_x_hotel");
            modelBuilder.Entity<ServicoXHotel>().HasKey(x => x.Id);

            modelBuilder.Entity<TipoQuarto>().ToTable("ht_tipos_quarto");
            modelBuilder.Entity<TipoQuarto>().HasKey(x => x.Id);            
        }
        public DbSet<Estadia> Estadias { get; set; }
        public DbSet<EstadiaXHospede> EstadiasXHospedes { get; set; }
        public DbSet<Hospede> Hospedes { get; set; }
        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ServicoXHotel> ServicosXHoteis { get; set; }
        public DbSet<TipoQuarto> TiposQuartos { get; set; }
    }
   
}
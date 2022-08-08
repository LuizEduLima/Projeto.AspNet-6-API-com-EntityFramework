using Microsoft.EntityFrameworkCore;
using Projeto06.Data.Mappings;
using Projeto06.Domain.Models;

namespace Projeto06.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DbSet<Atendimento>? Atendimentos { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Servico>? Servicos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtendimentoMap());
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ServicoMap());
        }
    }

}

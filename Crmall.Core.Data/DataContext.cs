using Crmall.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crmall.Core.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> optionsBuilder)
            : base(optionsBuilder) { }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ClienteBuilder.BuilderCliente(modelBuilder);
        }
    }
}

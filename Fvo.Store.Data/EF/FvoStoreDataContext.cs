using Fvo.Store.Data.EF.Maps;
using Fvo.Store.Domain.Entities;
using System.Data.Entity;

namespace Fvo.Store.Data.EF
{
   public class FvoStoreDataContext : DbContext
    {
        public FvoStoreDataContext() : base("Server=(localdb)\\mssqllocaldb;Database=FvoStore")
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoDeProduto> TipoDeProdutos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new TipoDeProdutoMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
        }
    }
}

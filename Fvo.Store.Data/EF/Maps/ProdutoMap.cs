using Fvo.Store.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Fvo.Store.Data.EF.Maps
{
    public class ProdutoMap : EntityTypeConfiguration<Produto>
    {
        public ProdutoMap()
        {
            //tabela
            ToTable(nameof(Produto));

            //PK
            HasKey(p => p.Id);

            //colunas
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.Preco)
                .HasColumnType("money");

            Property(c => c.Qtde)
                .HasColumnName("Quantidade")
                .IsRequired();

            Property(c => c.TipoDeProdutoId);
            
            Property(c => c.DataCadastro);

            //relacionamento
            HasRequired(prod => prod.TipoDeProduto)
                .WithMany(tipo => tipo.Produtos)
                .HasForeignKey(fk => fk.TipoDeProdutoId);


        }
    }
}

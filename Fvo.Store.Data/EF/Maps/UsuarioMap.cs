using Fvo.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fvo.Store.Data.EF.Maps
{
    public class UsuarioMap : EntityTypeConfiguration<Usuario>
    {
        public UsuarioMap()
        {
            //tabela
            ToTable(nameof(Usuario));

            //pk    
            HasKey(pk => pk.Id);

            //colunas
            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Nome)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnAnnotation(IndexAnnotation.AnnotationName,
                new IndexAnnotation(new IndexAttribute("UQ_dbo.Usuario.Email") { IsUnique = true}));


            Property(c => c.Email)
                .HasColumnType("varchar")
                .HasMaxLength(80)
                .IsRequired();

            Property(c => c.Senha)
                .HasColumnType("char")
                .HasMaxLength(88)
                .IsRequired();

            Property(c => c.DataCadastro);
        }
    }
}

using Fvo.Store.Domain.Entities;
using Fvo.Store.Domain.Helpers;
using System.Collections.Generic;
using System.Data.Entity;

namespace Fvo.Store.Data.EF
{
    internal class DbInitializer : CreateDatabaseIfNotExists<FvoStoreDataContext>
    {
        protected override void Seed(FvoStoreDataContext context)
        {
            var alimento = new TipoDeProduto() { Nome = "Alimento" };
            var higiene = new TipoDeProduto() { Nome = "Higiene" };
            var eletrônico = new TipoDeProduto() { Nome = "Eletrônico" };
            var limpeza = new TipoDeProduto() { Nome = "Limpeza" };

            var produtos = new List<Produto>()
            {
                new Produto(){ Nome = "Picanha", Preco = 70.5M, Qtde = 100, TipoDeProduto = alimento},
                new Produto(){ Nome = "Pasta de dente", Preco = 9.5M, Qtde = 250, TipoDeProduto = higiene},
                new Produto(){ Nome = "Desinfetante", Preco = 8.99M, Qtde = 200, TipoDeProduto = eletrônico},
                new Produto(){ Nome = "Telefone", Preco = 125.5M, Qtde = 200, TipoDeProduto = limpeza},

            };

            context.Produtos.AddRange(produtos);

            context.Usuarios.Add(new Usuario
            {
                Nome = "Flavio Leandro",
                Email = "teste@teste.com",
                Senha = "Teste@123".Ecrypt()
            });

            context.SaveChanges();
        }
    }
}

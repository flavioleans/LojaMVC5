using Fvo.Store.Domain.Contracts.Repositories;
using Fvo.Store.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Fvo.Store.Data.EF.Repositories
{
    public class ProdutoRepositoryEF : RepositoryEF<Produto>, IProdutoRepository
    {
        public ProdutoRepositoryEF(FvoStoreDataContext ctx) : base(ctx)
        {
        }

        public IEnumerable<Produto> GetByNameContains(string contains)
        {
            return _ctx.Produtos.Where(c => c.Nome.Contains(contains));
        }
    }
}

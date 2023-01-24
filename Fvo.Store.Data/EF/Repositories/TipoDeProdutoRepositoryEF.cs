using Fvo.Store.Domain.Contracts.Repositories;
using Fvo.Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fvo.Store.Data.EF.Repositories
{
    public class TipoDeProdutoRepositoryEF : RepositoryEF<TipoDeProduto>, ITipoDeProdutoRepository
    {
        public TipoDeProdutoRepositoryEF(FvoStoreDataContext ctx) : base(ctx)
        {
        }
    }
}

using Fvo.Store.Domain.Contracts.Repositories;
using Fvo.Store.Domain.Entities;
using System.Linq;

namespace Fvo.Store.Data.EF.Repositories
{
    public class UsuarioRepositoryEF : RepositoryEF<Usuario>, IUsuarioRepository
    {
        public UsuarioRepositoryEF(FvoStoreDataContext ctx) : base(ctx)
        {
        }

        public Usuario Get(string email)
        {
            return _ctx.Usuarios.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        }
    }
}

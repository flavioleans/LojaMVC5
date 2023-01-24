using Fvo.Store.Domain.Entities;

namespace Fvo.Store.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository: IRepository<Usuario>
    {
        Usuario Get(string email);
    }
}

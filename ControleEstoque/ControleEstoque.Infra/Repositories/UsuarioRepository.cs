using ControleEstoque.Domain.Entities;
using ControleEstoque.Domain.Interfaces;
using ControleEstoque.Infra.Context;

namespace ControleEstoque.Infra.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(MainContext dbContext) : base(dbContext)
        {
        }
    }
}
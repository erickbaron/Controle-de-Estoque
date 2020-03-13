using ControleEstoque.Domain.Entities;
using ControleEstoque.Domain.Interfaces;
using ControleEstoque.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ControleEstoque.Infra.Repositories
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(MainContext dbContext) : base(dbContext)
        {
        }

        public async Task<Usuario> GetByEmailAndPassword(string email, string senha)
        {
            return await _dbContext.Set<Usuario>().AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == email && x.Senha == senha);
        }

        public async Task<Usuario> GetByEmail(string email)
        {
            return await _dbContext.Set<Usuario>().AsNoTracking()
                .FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
using ControleEstoque.Domain.Entities;
using ControleEstoque.Domain.Interfaces;
using ControleEstoque.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Infra.Repositories
{
    public class EstoqueRepository : GenericRepository<Estoque>, IEstoqueRepository
    {
        public EstoqueRepository(MainContext dbContext) : base(dbContext)
        {
        }
        public async Task<IList<Estoque>> GetByLoja(int loja)
        {
            return await _dbContext.Set<Estoque>()
                .Where(e => e.Loja == loja).ToListAsync();
        }
    }
}
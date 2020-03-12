using ControleEstoque.Domain.Entities;
using ControleEstoque.Domain.Interfaces;
using ControleEstoque.Infra.Context;

namespace ControleEstoque.Infra.Repositories
{
    public class EstoqueRepository : GenericRepository<Estoque>, IEstoqueRepository
    {
        public EstoqueRepository(MainContext dbContext) : base(dbContext)
        {
        }
    }
}

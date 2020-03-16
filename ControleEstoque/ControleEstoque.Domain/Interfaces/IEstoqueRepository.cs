using ControleEstoque.Domain.Entities;
using ControleEstoque.Domain.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque.Domain.Interfaces
{
    public interface IEstoqueRepository : IGenericRepository<Estoque>
    {
        Task<IList<Estoque>> GetByLoja(int loja);
    }
}
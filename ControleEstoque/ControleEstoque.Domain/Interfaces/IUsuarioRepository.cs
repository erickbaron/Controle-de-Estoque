using ControleEstoque.Domain.Entities;
using System.Threading.Tasks;

namespace ControleEstoque.Domain.Interfaces
{
    public interface IUsuarioRepository : IGenericRepository<Usuario>
    {
        Task<Usuario> GetByEmailAndPassword(string email, string senha);
        Task<Usuario> GetByEmail(string email);
    }
}
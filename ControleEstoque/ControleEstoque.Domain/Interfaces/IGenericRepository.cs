using ControleEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Domain.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : EntidadeBase
    {
        Task<IList<TEntity>> GetAll();
        Task<TEntity> GetById(Guid id);
        Task Create(TEntity entity);
        Task Update(Guid id, TEntity entity);
        Task Delete(Guid id);
        Task<bool> Exists(Guid id);
    }
}
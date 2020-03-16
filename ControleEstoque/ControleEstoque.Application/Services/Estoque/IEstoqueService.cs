using ControleEstoque.Application.Models.Estoque;
using ControleEstoque.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque.Application.Services.Funcionario
{
    public interface IEstoqueService
    {
        Task Create(EstoqueRequestModel request);
        Task<IList<EstoqueResponseModel>> GetAll();
        Task<IList<EstoqueResponseModel>> GetAllByLoja(int loja);
        Task<EstoqueResponseModel> GetById(Guid id);
        Task Update(Guid id, EstoqueRequestModel request);
        Task Delete(Guid id);
    }
}
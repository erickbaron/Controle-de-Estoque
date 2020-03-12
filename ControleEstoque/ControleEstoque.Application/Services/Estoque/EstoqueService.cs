using ControleEstoque.Application.Models.Estoque;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque.Application.Services.Funcionario
{
    public class EstoqueService : IEstoqueService
    {
        public async Task Create(EstoqueRequestModel request)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<EstoqueResponseModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task Update(Guid id, EstoqueRequestModel request)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
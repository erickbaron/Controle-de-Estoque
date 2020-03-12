using ControleEstoque.Application.Models.Funcionario;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque.Application.Services.Funcionario
{
    public class UsuarioService : IUsuarioService
    {
        public async Task Create(UsuarioRequestModel request)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<UsuarioResponseModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task Update(Guid id, UsuarioRequestModel request)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
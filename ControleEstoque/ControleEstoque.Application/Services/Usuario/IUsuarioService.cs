using ControleEstoque.Application.Models.Funcionario;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque.Application.Services.Funcionario
{
    public interface IUsuarioService
    {
        Task Create(UsuarioRequestModel request);
        Task<IList<UsuarioResponseModel>> GetAll();
        Task Update(Guid id, UsuarioRequestModel request);
        Task Delete(Guid id);
    }
}
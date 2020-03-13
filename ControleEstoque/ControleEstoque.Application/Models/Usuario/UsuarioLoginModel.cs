using ControleEstoque.Application.Models.Funcionario;
using System;

namespace ControleEstoque.Application.Models.Usuario
{
    public class UsuarioLoginModel : UsuarioModelBase
    {
        public Guid Id { get; set; }
        public string Token { get; set; }
    }
}
using System;

namespace ControleEstoque.Application.Models.Funcionario
{
    public class UsuarioModelBase
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
using ControleEstoque.Domain.Utils;
using System;

namespace ControleEstoque.Domain.Entities
{
    public class Funcionario
    {
        public Funcionario(string nome, string cpf, string email, string senha, NiveisAcesso nivelAcesso)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
            Senha = senha;
            DataCriacao = DateTime.Now;
            NivelAcesso = nivelAcesso;
        }

        public string Nome { get; protected set; }
        public string CPF { get; protected set; }
        public string Email { get; protected set; }
        public string Senha { get; protected set; }
        public DateTime DataCriacao { get; protected set; }
        public NiveisAcesso NivelAcesso { get; protected set; }
    }
}
using ControleEstoque.Domain.Utils;
using System;

namespace ControleEstoque.Domain.Entities
{
    public class Usuario : EntidadeBase
    {
        public Usuario(string nome, string cpf, string email, string senha, DateTime dataNascimento, NiveisAcesso nivelAcesso)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
            Senha = senha;
            DataCriacao = DateTime.Now;
            DataNascimento = dataNascimento;
            NivelAcesso = nivelAcesso;
        }
        public void Update(string nome, string cpf, string email, string senha, DateTime dataNascimento, NiveisAcesso nivelAcesso)
        {
            Nome = nome;
            CPF = cpf;
            Email = email;
            Senha = senha;
            DataNascimento = dataNascimento;
            NivelAcesso = nivelAcesso;
        }

        public string Nome { get; protected set; }
        public string CPF { get; protected set; }
        public string Email { get; protected set; }
        public string Senha { get; protected set; }
        public DateTime DataCriacao { get; protected set; }
        public DateTime DataNascimento { get; protected set; }
        public NiveisAcesso NivelAcesso { get; protected set; }
    }
}
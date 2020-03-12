using ControleEstoque.Domain.Utils;

namespace ControleEstoque.Domain.Entities
{
    public class Estoque : EntidadeBase
    {
        public Estoque(Loja loja, string codigo, string nome, string descricao, decimal valorDeCusto, decimal valorDeVenda, decimal percentualVenda, int quantidadeEmEstoque)
        {
            Loja = loja;
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            ValorCusto = valorDeCusto;
            ValorVenda = valorDeVenda;
            PercentualVenda = percentualVenda;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }
        public void Update(Loja loja, string codigo, string nome, string descricao, decimal valorDeCusto, decimal valorDeVenda, decimal percentualVenda, int quantidadeEmEstoque)
        {
            Loja = loja;
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            ValorCusto = valorDeCusto;
            ValorVenda = valorDeVenda;
            PercentualVenda = percentualVenda;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        public Loja Loja { get; protected set; }
        public string Codigo { get; protected set; }
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }
        public decimal ValorCusto { get; protected set; }
        public decimal ValorVenda { get; protected set; }
        public decimal PercentualVenda { get; protected set; }
        public int QuantidadeEmEstoque { get; protected set; }
    }
}

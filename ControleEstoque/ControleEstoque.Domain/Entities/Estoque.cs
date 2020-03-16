namespace ControleEstoque.Domain.Entities
{
    public class Estoque : EntidadeBase
    {
        public Estoque(int loja, string codigo, string nome, string descricao, decimal valorCusto, decimal valorVenda, decimal percentualVenda, int quantidadeEmEstoque)
        {
            Loja = loja;
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            ValorCusto = valorCusto;
            ValorVenda = valorVenda;
            PercentualVenda = percentualVenda;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }
        public void Update(int loja, string codigo, string nome, string descricao, decimal valorCusto, decimal valorVenda, decimal percentualVenda, int quantidadeEmEstoque)
        {
            Loja = loja;
            Codigo = codigo;
            Nome = nome;
            Descricao = descricao;
            ValorCusto = valorCusto;
            ValorVenda = valorVenda;
            PercentualVenda = percentualVenda;
            QuantidadeEmEstoque = quantidadeEmEstoque;
        }

        public int Loja { get; protected set; }
        public string Codigo { get; protected set; }
        public string Nome { get; protected set; }
        public string Descricao { get; protected set; }
        public decimal ValorCusto { get; protected set; }
        public decimal ValorVenda { get; protected set; }
        public decimal PercentualVenda { get; protected set; }
        public int QuantidadeEmEstoque { get; protected set; }
    }
}

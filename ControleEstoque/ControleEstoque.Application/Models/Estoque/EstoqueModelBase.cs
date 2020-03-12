using ControleEstoque.Domain.Utils;

namespace ControleEstoque.Application.Models.Estoque
{
    public class EstoqueModelBase
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal PercentualVenda { get; set; }
        public Loja Loja { get; set; }
    }
}
using ControleEstoque.Domain.Entities;
using ControleEstoque.Domain.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace ControleEstoque.Infra.Mappings
{
    public class EstoqueMapping : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.Property(d => d.Nome).IsRequired();
            builder.Property(d => d.Codigo).IsRequired();
            builder.Property(d => d.Descricao).IsRequired();
            builder.Property(d => d.Loja).IsRequired();
            builder.Property(d => d.PercentualVenda).IsRequired();
            builder.Property(d => d.QuantidadeEmEstoque).IsRequired();
            builder.Property(d => d.ValorCusto).IsRequired();
            builder.Property(d => d.ValorVenda).IsRequired();

            Seed(builder);
        }

        public void Seed(EntityTypeBuilder<Estoque> builder)
        {
            var estoques = new List<Estoque>();

            var estoqueAncora = new Estoque(Loja.AncoraStore, "UC200", "Faca", "Uma bela faca", (decimal)20.00, (decimal)50.00, (decimal)250.00, 50);
            estoqueAncora.SetId(Guid.NewGuid());

            var estoqueUniverso = new Estoque(Loja.UniversoDeeles, "UC200", "Faca 2.0", "Uma bela faca 2.0", (decimal)20.00, (decimal)50.00, (decimal)250.00, 50);
            estoqueUniverso.SetId(Guid.NewGuid());

            estoques.Add(estoqueAncora);
            estoques.Add(estoqueUniverso);

            builder.HasData(estoques);
        }
    }
}
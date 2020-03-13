using ControleEstoque.Application.Models.Estoque;
using ControleEstoque.Domain.Entities;
using ControleEstoque.Domain.Interfaces;
using ControleEstoque.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Application.Services.Funcionario
{
    public class EstoqueService : IEstoqueService
    {
        private readonly IEstoqueRepository _estoqueRepository;
        public EstoqueService(IEstoqueRepository estoqueRepository)
        {
            _estoqueRepository = estoqueRepository;
        }

        public async Task Create(EstoqueRequestModel request)
        {
            var estoque = new Estoque
            (
                request.Loja,
                request.Codigo,
                request.Nome,
                request.Descricao,
                request.ValorCompra,
                request.ValorVenda,
                request.PercentualVenda,
                request.QuantidadeEmEstoque
            );
            await _estoqueRepository.Create(estoque);
        }
        public async Task Delete(Guid id)
        {
            var estoque = await _estoqueRepository.GetById(id);
            if (estoque == null)
            {
                throw new Exception("O estoque não foi encontrado");
            }

            estoque.Disable(id);
            await _estoqueRepository.Update(id, estoque);
        }

        public async Task<IList<EstoqueResponseModel>> GetAll()
        {
            var result = await _estoqueRepository.GetAll();
            return result.Select(x => new EstoqueResponseModel
            {
                Codigo = x.Codigo,
                Nome = x.Nome,
                Descricao = x.Descricao,
                Loja = x.Loja,
                ValorCompra = x.ValorCusto,
                ValorVenda = x.ValorVenda,
                PercentualVenda = x.PercentualVenda,
                QuantidadeEmEstoque = x.QuantidadeEmEstoque
            }).ToList();

        }

        public async Task<EstoqueResponseModel> GetById(Guid id)
        {
            var estoque = await _estoqueRepository.GetById(id);
            if (estoque == null)
                throw new Exception("Erro ao encontrar o estoque");

            return new EstoqueResponseModel
            {
                Codigo = estoque.Codigo,
                Nome = estoque.Nome,
                Descricao = estoque.Descricao,
                Loja = estoque.Loja,
                ValorCompra = estoque.ValorCusto,
                ValorVenda = estoque.ValorVenda,
                PercentualVenda = estoque.PercentualVenda,
                QuantidadeEmEstoque = estoque.QuantidadeEmEstoque
            };
        }

        public async Task Update(Guid id, EstoqueRequestModel request)
        {
            var estoque = await _estoqueRepository.GetById(id);
            if (estoque == null)
                throw new Exception("Não foi possível encontrar esse estoque");

            estoque.Update(request.Loja, request.Codigo, request.Nome, request.Descricao, request.ValorVenda, request.ValorVenda, request.PercentualVenda, request.QuantidadeEmEstoque);
            await _estoqueRepository.Update(id, estoque);
        }

        public async Task<IList<EstoqueResponseModel>> GetAllByLoja(Loja loja)
        {
            var estoques = await _estoqueRepository.GetByLoja(loja);
            if (estoques.Count < 1)
                throw new Exception("Nenhum estoque na loja selecionada");

            return estoques.Select(x => new EstoqueResponseModel
            {
                Codigo = x.Codigo,
                Nome = x.Nome,
                Descricao = x.Descricao,
                Loja = x.Loja,
                ValorCompra = x.ValorCusto,
                ValorVenda = x.ValorVenda,
                PercentualVenda = x.PercentualVenda,
                QuantidadeEmEstoque = x.QuantidadeEmEstoque
            }).ToList();
        }
    }
}
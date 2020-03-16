using ControleEstoque.Application.Models.Estoque;
using ControleEstoque.Application.Services.Funcionario;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControleEstoque.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoqueController : Controller
    {

        private readonly IEstoqueService _estoqueService;

        public EstoqueController(IEstoqueService estoqueService)
        {
            _estoqueService = estoqueService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EstoqueRequestModel request)
        {
            await _estoqueService.Create(request);
            return NoContent();
        }

        [HttpPatch]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] EstoqueRequestModel request)
        {
            await _estoqueService.Update(id, request);
            return NoContent();
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await _estoqueService.Delete(id);
            return NoContent();
        }

        [HttpGet]
        public async Task<IList<EstoqueResponseModel>> GetAll()
        {
            
            return await _estoqueService.GetAll();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<EstoqueResponseModel> GetById([FromRoute] Guid id)
        {
            return await _estoqueService.GetById(id);
        }

        [HttpGet]
        [Route("{loja}")]
        public async Task<IList<EstoqueResponseModel>> GetByLoja([FromRoute] int loja)
        {
            return await _estoqueService.GetAllByLoja(loja);
        }
    }
}
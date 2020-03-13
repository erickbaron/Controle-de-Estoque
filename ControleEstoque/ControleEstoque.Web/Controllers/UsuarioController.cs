using ControleEstoque.Application.Models.Funcionario;
using ControleEstoque.Application.Services.Funcionario;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoque.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UsuarioRequestModel request)
        {
            try
            {
                await _usuarioService.Create(request);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
            return NoContent();
        }

        [HttpGet]
        public async Task<IList<UsuarioResponseModel>> GetAll()
        {
            return await _usuarioService.GetAll();
        }
    }
}
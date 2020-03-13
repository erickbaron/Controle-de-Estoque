using ControleEstoque.Application.Models.Funcionario;
using ControleEstoque.Application.Models.Usuario;
using ControleEstoque.Domain.Entities;
using ControleEstoque.Domain.Interfaces;
using ControleEstoque.Domain.Utils;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Application.Services.Funcionario
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IConfiguration _configuration;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task Create(UsuarioRequestModel request)
        {
            var emailExistente = await _usuarioRepository.GetByEmail(request.Email);
            if (emailExistente != null)
                throw new Exception("Já existe um usuário cadastrado com este email.");

            var senha = HashUtils.GetHashSha256(request.Senha);

            var usuario = new Usuario(request.Nome,
                         request.Email,
                         senha,
                         request.DataNascimento,
                         (NiveisAcesso)request.NiveisAcesso);

            //usuario.Validate();

            await _usuarioRepository.Create(usuario);
        }

        public async Task<IList<UsuarioResponseModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task Update(Guid id, UsuarioRequestModel request)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<UsuarioLoginModel> Login(UsuarioLoginModel request)
        {
            var hashPassword = HashUtils.GetHashSha256(request.Senha);
            var user = await _usuarioRepository.GetByEmailAndPassword(request.Email, hashPassword);
            if (user != null)
            {
                var newUser = new UsuarioLoginModel
                {
                    Email = user.Email,
                    NiveisAcesso = (int)user.NivelAcesso
                };
                var tokenString = GetTokenJWT(newUser);
                return new UsuarioLoginModel
                {
                    Id = user.Id,
                    Nome = user.Nome,
                    Email = user.Email,
                    Senha = user.Senha,
                    DataCriacao = user.DataCriacao,
                    DataNascimento = user.DataNascimento,
                    Token = tokenString
                };
            }
            throw new Exception("Credenciais inválidas.");
        }

        private string GetTokenJWT(UsuarioLoginModel user)
        {
            var accessLevel = "";
            switch (user.NiveisAcesso)
            {
                case 0:
                    accessLevel = NiveisAcesso.Administrador.ToString();
                    break;

                case 1:
                    accessLevel = NiveisAcesso.UsuarioLoja1.ToString();
                    break;

                default:
                    accessLevel = NiveisAcesso.UsuarioLoja2.ToString();
                    break;
            }
            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role, accessLevel),
            };

            var token = new JwtSecurityToken(
                 issuer: "ControleEstoque",
                 audience: "ErickBaitola",
                 expires: DateTime.Now.AddMonths(3),
                 claims: claims,
                 signingCredentials: new SigningCredentials(
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes("KAINBHU@#MKBKAKM9776JKINJI!!@#IBNHUOGA@UUHBN#NK")),
                        SecurityAlgorithms.HmacSha256
                    )
                 );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
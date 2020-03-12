using ControleEstoque.Domain.Entities;
using ControleEstoque.Domain.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace ControleEstoque.Infra.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(d => d.Nome).IsRequired();
            builder.Property(d => d.Email).IsRequired();
            builder.Property(d => d.Senha).IsRequired();
            builder.Property(d => d.DataCriacao).IsRequired();
            builder.Property(d => d.DataNascimento).IsRequired();
            builder.Property(d => d.NivelAcesso).IsRequired();

            Seed(builder);
        }

        public void Seed(EntityTypeBuilder<Usuario> builder)
        {
            var usuarios = new List<Usuario>();

            var senha = HashUtils.GetHashSha256("123");

            var administrador = new Usuario("Fred", "fred@gmail.com", senha, new DateTime(2001, 02, 13), NiveisAcesso.Administrador);
            administrador.SetId(Guid.NewGuid());

            var funcionario1 = new Usuario("Gabriela", "gabriela@gmail.com", senha, new DateTime(2001, 02, 13), NiveisAcesso.UsuarioLoja1);
            funcionario1.SetId(Guid.NewGuid());

            var funcionario2 = new Usuario("Ericka", "ericka@gmail.com", senha, new DateTime(2001, 02, 13), NiveisAcesso.UsuarioLoja2);
            funcionario2.SetId(Guid.NewGuid());

            usuarios.Add(administrador);
            usuarios.Add(funcionario1);
            usuarios.Add(funcionario2);

            builder.HasData(usuarios);
        }
    }
}
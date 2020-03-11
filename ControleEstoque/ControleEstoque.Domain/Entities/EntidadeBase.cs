using System;

namespace ControleEstoque.Domain.Entities
{
    public abstract class EntidadeBase
    {
        public Guid Id { get; protected set; }
    }
}
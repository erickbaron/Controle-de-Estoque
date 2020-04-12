using System;

namespace ControleEstoque.Domain.Entities
{
    public abstract class EntidadeBase
    {
        public Guid Id { get; protected set; }
        public bool Ativo { get; set; }

        public void SetId(Guid id)
        {
            Id = id;
        }

        public void Disable(Guid id)
        {
            Ativo = false;
        }
    }
}
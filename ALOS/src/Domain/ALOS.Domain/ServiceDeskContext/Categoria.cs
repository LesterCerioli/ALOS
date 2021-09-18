using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.ServiceDeskContext
{
    public class Categoria : Entity, IAggregateRoot
    {
        public Categoria(Guid id, string categoriaNome, string subCategoria, string subCategoria2, string subCategoria3, bool ativo)
        {
            Id = id;
            CategoriaNome = categoriaNome;
            SubCategoria = subCategoria;
            SubCategoria2 = subCategoria2;
            SubCategoria3 = subCategoria3;
            Ativo = ativo;
        }

        protected Categoria() { }
        public string CategoriaNome { get; private set; }
        public string SubCategoria { get; private set; }
        public string SubCategoria2 { get; private set; }
        public string SubCategoria3 { get; private set; }
        public bool Ativo { get; private set; }
        
    }
}

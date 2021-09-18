using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.ServiceDeskContext
{
    public class OrdemServico : Entity, IAggregateRoot
    {
        public OrdemServico(Guid id, string oSNumero, IList<Customer> customers)
        {
            Id = id;
            OSNumero = oSNumero;
            Customers = new List<Customer>();
        }

        protected OrdemServico() { }
        public string OSNumero { get; private set; }
        public Categoria Categoria { get; private set; }
        public IList<Customer> Customers { get; private set; } = new List<Customer>();
    }
}

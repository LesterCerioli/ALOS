using System;
using ALOS.Domain.Enums;
using NetDevPack.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Models.HR
{
    public class Funcionario : Entity, IAggregateRoot
    {

        
        protected Funcionario() { }
        public Name Name { get; private set; }
        public Address Address { get; private set; }
        public TituloEleito TituloEleitor { get; private set; }
        
    }
}
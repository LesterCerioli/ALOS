using System;
using NetDevPack.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ALOS.Domain.Models.Core
{
    public class UF : Entity, IAggregateRoot
    {
        public UF(Guid id, string uFSl)
        {
            Id = Id;
            UFSl = uFSl;
        }

        protected UF() { }
        public string UFSl {get; private set; }

        
    }
}
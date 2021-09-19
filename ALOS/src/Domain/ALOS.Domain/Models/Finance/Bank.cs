using NetDevPack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALOS.Domain.Models.Finance
{
    public class Bank : Entity, IAggregateRoot
    {
        public Bank(Guid id, string name) 
        {
            Id = id;
            Name = name;
               
        }
        
        protected Bank() { }
        public string Name { get; private set; }
        
    }
}